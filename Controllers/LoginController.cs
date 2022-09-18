using Shop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;
using Shop.SendMail;

namespace AdminWeb.Controllers
{
    public class LoginController : Controller
    {
        private readonly DataFashionContext _context;
        public LoginController(DataFashionContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var user = HttpContext.Session.GetString("user");
            if(user != null)
            {
                return Redirect("/Home");
            }
            else
            {
                return View();
            }
           
        }
        public IActionResult IndexRes()
        {
            var user = HttpContext.Session.GetString("user");
            if (user != null)
            {
                return Redirect("/Home");
            }
            else
            {
                return View();
            }
        }
        [TempData]
        public string Message { get; set; }
        [HttpPost]
        public ActionResult LoginAdmin()
        {
            String email = HttpContext.Request.Form["Email"];
            String Pass = HttpContext.Request.Form["pass"];
            String btnLogin = HttpContext.Request.Form["login"];
            if(btnLogin != null)
            {
                var dataFashionContext = _context.Users.Include(u => u.Role);
                var data = dataFashionContext.Where(s => s.Email.Equals(email) && s.Password.Equals(encryption(Pass)) && s.Status == 1 && s.RoleId.Equals("Customer")).ToList();
                if(data.Count > 0)
                {
                    HttpContext.Session.SetString("user", data.FirstOrDefault().Id.ToString());
                    
                    TempData["AlertType"] = "alert-success";
                    TempData["AlertMessage"] = "Login Success";
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                  
                    var dataAdmin = dataFashionContext.Where(s => s.Email.Equals(email) && s.Password.Equals(Pass) && s.Status == 1 && s.RoleId != "Customer").ToList();
                    if (dataAdmin.Count > 0)
                    {
                        HttpContext.Session.SetString("user", dataAdmin.FirstOrDefault().Id.ToString());
                        HttpContext.Session.SetString("role", dataAdmin.FirstOrDefault().RoleId.ToString());
                        Message = dataAdmin.FirstOrDefault().Fullname;
                        ViewBag.Message = "Success";
                        return Redirect("/HomeAdmin");
                    }
                    TempData["AlertType"] = "alert-warning";
                    TempData["AlertMessage"] = "Wrong pass or Email";
                    return Redirect("/Login");

                }
            }
            TempData["AlertType"] = "alert-warning";
            TempData["AlertMessage"] = "Wrong pass or Email";
            return Redirect("/Login");
        }
        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            ViewBag.Message = "Success";
            return Redirect("/Login");
        }
        [HttpPost]
        public ActionResult Res()
        {
          //  Id,Email,Password,Fullname,Phone,Address,Status,RoleId
               String email = HttpContext.Request.Form["Email"];
            String Pass = HttpContext.Request.Form["Password"];
            String Fullname = HttpContext.Request.Form["Fullname"];
            String Address = HttpContext.Request.Form["Address"];
            String Phone = HttpContext.Request.Form["Phone"];
            String btnRes= HttpContext.Request.Form["res"];
            if(btnRes != null)
            {
                if (checkEmailExist(email) == false)
                {
                    TempData["AlertType"] = "alert-warning";
                    TempData["AlertMessage"] = "Email is Exist";
                    return Redirect("/Login/IndexRes");
                }
                else
                {
                    User user = new User();
                    user.Email = email;
                    user.Password = encryption(Pass);
                    user.Address = Address;
                    user.Phone = Phone;
                    user.Fullname = Fullname;
                    user.Status = 1;
                    user.RoleId = "Customer";
                    _context.Users.Add(user);
                    _context.SaveChanges();
                    MailUtils.SendMailGoogleSmtp("huytnqce140520@fpt.edu.vn", email, "Confirm Password", "Please  https://localhost:44398/Login",
                                     "huytnqce140520@fpt.edu.vn", "0917077087").Wait();
                    
                    return Redirect("/Login");
                }
            
            }
            TempData["AlertType"] = "alert-warning";
            TempData["AlertMessage"] = "Fail";
            return Redirect("/Login");
        }
     
        public ActionResult ChangeInfo()
        {
            String email = HttpContext.Request.Form["Email"];
            String Pass = HttpContext.Request.Form["Password"];
            String Fullname = HttpContext.Request.Form["Fullname"];
            String Address = HttpContext.Request.Form["Address"];
            String Phone = HttpContext.Request.Form["Phone"];
            String btnRes = HttpContext.Request.Form["res"];
           
             if (btnRes != null)
            {
                if (checkEmailExist(email) == false)
                {
                    ViewBag.Message = "Email is Exist";
                    return Redirect("/Login");
                }
                else
                {
                    User user = new User();
                    user.Email = email;
                    user.Password = Pass;
                    user.Address = Address;
                    user.Phone = Phone;
                    user.Fullname = Fullname;
                    user.Status = 1;
                    user.RoleId = "Customer";
                    _context.Users.Add(user);
                    _context.SaveChanges();
                   
                    return Redirect("/Login");
                }
               
            }
            return Redirect("");
        }
        public bool checkEmailExist(string Email)
        {
            var dataFashionContext = _context.Users.Include(u => u.Role);
            var data = dataFashionContext.Where(s => s.Email.Equals(Email)).ToList();
            if(data.Count() > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
          
        }
        public string encryption(String password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            //encrypt the given password string into Encrypted data  
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();
            //Create a new string by using the encrypted data  
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
        }

    }
}

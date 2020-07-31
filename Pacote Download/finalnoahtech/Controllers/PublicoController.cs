using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Noahtech.Models;
using NoahTech.Models;

namespace Noahtech.Controllers
{
    public class PublicoController : Controller
    {

        public readonly Context _context;
       

        public PublicoController(Context context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }



        public IActionResult Logar()
        {
            return View();
        }

        public IActionResult AcessoNegado()
        {
            return View();
        }

        
        public IActionResult Logout()
        {
            CookieOptions cookie = new CookieOptions();
            cookie.Expires = DateTime.Now.AddMinutes(5);
            Response.Cookies.Append("Email", "", cookie);

            return RedirectToAction("Logar", "Publico");
        }

        public IActionResult Create()
        {
            return RedirectToAction("Create" , "Usuarios");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgotPassword()
        {
            return View();
        }


        //[HttpPost]
        //[AllowAnonymous]
        //public async Task<IActionResult> FrogotPassword(ForgotPassword model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var user = await userManager.FindByEmailAsync(model.Email);

        //        if (user != null && await userManager.IsEmailConfirmedAsync(user)) ;
        //        {
        //            var token = await userManger.GeneratePasswordResetTokenAsync(user);
        //            var passwordResetLink = Url.Action("ResetPassword", "Publico",
        //                new { email = model.Email, token = token }, Request.Scheme);

        //            Logger.Log(LogLevel.Warning, passwordResetLink);
        //            return View("ForgotPasswordConfirmation");
        //        }
        //        return View("ForgotPasswordConfirmation");
        //    }
        //    return View(model);
        //}



        [HttpPost]
        public IActionResult Logar(string email, string senha)
        {
            string user = AutenticarUser(email, senha);

            if(user == "")
            {
                ViewBag.Error = "E-mail e/ou senha incorreto(s).";
                return View();
            }
           
            else
            {
                CookieOptions cookie = new CookieOptions();
                cookie.Expires = DateTime.Now.AddMinutes(5);
                Response.Cookies.Append("Email", user, cookie);
                return RedirectToAction("Index", "Home");
            }
        }

        public string AutenticarUser(string email, string senha)
        {
            var query = (from u in _context.Usuarios where u.Email == email && u.Senha == senha 
                         select u).SingleOrDefault();

            if (query == null)
            {
                return "";
            }
            else
            {
                return query.Email;
            }              
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
//using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Owin;
using CoreStandDesign.Models;

namespace CoreStandDesign.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
       // private ApplicationUserManager _userManager;

        public AccountController()
        {
        }

      

      

        //
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

      
     
    }
}
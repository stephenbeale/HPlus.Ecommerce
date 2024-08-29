using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HPlus.Ecommerce.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        //Must check user is validated before proceeding
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}
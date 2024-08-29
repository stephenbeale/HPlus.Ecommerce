using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HPlus.Ecommerce.Controllers
{
    //Saves writing this for all in this class
    [RoutePrefix("product")]
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        [RoutePrefix("list")]
        public ActionResult List()
        {
            return View();
        }
    }
}
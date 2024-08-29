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

        //Allows you to override default names if needed (here it's redundant but just as an example)
        [Route("list")]
        public ActionResult List()
        {
            return View();
        }

        //Example of advanced attribute routing e.g. custom parameters

        [Route("product/{productName}")]
        public ActionResult Detail(string productName)
        {
            //lookup the product name in the database
            return View();

        }
    }
}
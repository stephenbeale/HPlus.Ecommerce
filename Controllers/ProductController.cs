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
        //Parameter must match the agrument
        [Route("product/{productName}")]
        public ActionResult Detail(string productName)
        {
            //lookup the product name in the database
            return View();

        }

        //Example of advanced attribute routing with constraints on data type passed in
        //Constraint here enforces user ID to be an int
        [Route("profile/{userId:int}")]
        public ActionResult UserDetail(int userId)
        {
            //lookup the product name in the database
            return View();

        }

        //Example of advanced attribute routing with constraints on data type passed in
        //Constraint here enforces user ID to be an int, with an optional 
        //Argument must also be defaulted to a null value
        [Route("profile/{id?}")]
        public ActionResult UserId(int? id = null)
        {
            //lookup the product name in the database
            return View();

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public string Index()
        {
            return "Navigate to a URL to show an Example";
        }

        public ViewResult AutoProperty()
        {
            // create a new Product object
            Product myProduct = new Product();

            //set the property value
            myProduct.Name = "Kayak";

            //get the property
            string productName = myProduct.Name;

            // Generate the view
            return View("result", (object)String.Format("Product name: {0}", productName));
        }
    }
}

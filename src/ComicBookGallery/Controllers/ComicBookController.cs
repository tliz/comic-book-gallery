using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBookController : Controller
        // : Controller - > inherit from base class
    {
        // public string Detail()
        //{
             //return "Hello from comic books controller!";
        //}
        //public ContentResult Detail()
        public ActionResult Detail()
        {
            if ( DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            {
                // casting action result type to contentResult
                //return (ContentResult) new RedirectResult("/");
                // redirectResult object
                // return new RedirectResult("/");

                // call to redirect method
                return Redirect("/");
            }

            // content result method
            // instance of content result class
            //return new ContentResult()
            //{
            // use content result content property to set content
            //  Content = "Hello from comic books controller!"
            // };  

            // replace contentResult method with call to content object 
            return Content("Hello from comic books controller!");
        }
    }
}
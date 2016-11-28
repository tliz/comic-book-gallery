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
        public string Detail()
        {
            return "Hello from comic books controller!";
        }
    }
}
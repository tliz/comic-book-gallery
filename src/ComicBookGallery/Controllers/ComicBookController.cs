using ComicBookGallery.Models;
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
        // public ActionResult Detail()
        //{
        // if ( DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
        //   {
        // casting action result type to contentResult
        //return (ContentResult) new RedirectResult("/");
        // redirectResult object
        // return new RedirectResult("/");

        // call to redirect method
        //     return Redirect("/");
        //  }

        // content result method
        // instance of content result class
        //return new ContentResult()
        //{
        // use content result content property to set content
        //  Content = "Hello from comic books controller!"
        // };  

        // replace contentResult method with call to content object 
        //return Content("Hello from comic books controller!");
        //}

        public ActionResult Detail()
        {
            //instantiate combic book object
          //  var comicBook = new ComicBook();
        
        // SETTING INSTANCE PROPERTY VALUES:
            //1. use comicBook variable to set properties
            //comicBook.SeriesTitle = "";

            // 2. or object initializer syntax
             var comicBook = new ComicBook()
             {
                 SeriesTitle = "The Amazing Spider-Man",
                 IssueNumber = 700,
                 DescriptionHtml = "<p>Final issue! Witness the final hoour of Doctor Octopus'life and his one, last, greate act of revenge! Even if Spider-Man survives... <strong> will Peter Parker?</strong></p>",
                 
                // instantiate array
                Artists = new Artist[]
                {
                    new Artist() { Name = "Dan Slott", Role = "Script"},
                    new Artist() { Name = "Humberto Ramos", Role = "Pencils"},
                    new Artist() { Name = "Victor Olazaba", Role = "Inks"},
                    new Artist() { Name = "Edgar Delgado", Role = "Colors"},
                    new Artist() { Name = "Chris Eliopoulos", Role = "Letters"}
                }
        };

            // Properties
            //ViewBag.SeriesTitle = "The Amazing Spider-Man";
            //ViewBag.IssueNumber = 700;
            //ViewBag.Description = "<p>Final issue! Witness the final hoour of Doctor Octopus'life and his one, last, greate act of revenge! Even if Spider-Man survives... <strong> will Peter Parker?</strong></p>";
            //ViewBag.Artists = new string[]
            //    {
            //        "Script: Dan Slott",
            //        "Pencils: Humberto Ramos",
            //        "Inks: Victor Olazaba",
            //        "Colors: Edgar Delgado",
            //        "Letters: Chris Eliopoulos"
            //    };
            //return View();

            // Pass comic book model to view
            // ViewBag.ComicBook = comicBook;
            return View(comicBook);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        // Attributes defined using properties
        public int ID { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        //public string[] Artists { get; set; }
        // change artist property to be array of artists
        public Artist[] Artists { get; set; }
        public bool Favorite { get; set; }
    }
}
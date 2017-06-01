using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PluralsightExample.Models
{
    public class BookReview
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public string Size { get; set; }
        public int Rating { get; set; }
    }
}
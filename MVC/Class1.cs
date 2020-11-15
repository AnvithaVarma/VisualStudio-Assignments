using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace practisingMVC.Models
{
    public class Class1
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string  ReleaseDate { get; set; }
        public string Genre { get; set; }

        public string GetDateTime()
        {
            return DateTime.Now.ToString();
        }
            
    }
}
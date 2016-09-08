using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Tutorial.Models
{
    public class Album
    {
        public int AlbumID { get; set; }

        public string Title { get; set; }

        public Artist Artist { get; set; }

        public virtual List<Review> Review { get; set; } // Otherside of 1 to many relationship in Review.cs.  A list of Reviews per Album
    }
}
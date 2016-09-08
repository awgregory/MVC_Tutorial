using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Tutorial.Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        public int AlbumID { get; set; }  // Creates a Foreign Key in Reviews and drop down box in Reviews Create View
        public virtual Album Album { get; set; } // Otherside of 1 to many relationship in Album, enables Lazy Loading

        public string Contents { get; set; }

        [Required()]   //Things broke when I changed this on my model AFTER creating my database (located in App_Data Folder)
        [Display(Name="Email Address")]
        [DataType(DataType.EmailAddress)]  // Only need to add DataType here, and it propogates everywhere by name ReviewerEmail
        public string ReviewerEmail { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Tutorial.Models
{
    public class MVC_TutorialContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MVC_TutorialContext() : base("name=MVC_TutorialContext")
        {
        }

        public System.Data.Entity.DbSet<MVC_Tutorial.Models.Album> Albums { get; set; }

        public System.Data.Entity.DbSet<MVC_Tutorial.Models.Review> Reviews { get; set; }
    
    }
}

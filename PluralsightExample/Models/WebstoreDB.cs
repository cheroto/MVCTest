using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PluralsightExample.Models
{
    public class WebstoreDB : DbContext
    {
        //public WebstoreDB() : base("name = DefaultConnection")
        public WebstoreDB() : base("Data Source=.;Initial Catalog=Northwind;Integrated Security=True;MultipleActiveResultSets=True")
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
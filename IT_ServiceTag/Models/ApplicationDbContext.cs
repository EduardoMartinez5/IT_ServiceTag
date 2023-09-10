using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IT_ServiceTag.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }

        public ApplicationDbContext() : base("connectDB")
        {

        }


    }
}
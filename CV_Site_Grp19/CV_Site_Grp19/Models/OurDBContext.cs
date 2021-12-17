using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CV_Site_Grp19.Models
{
    public class OurDBContext : DbContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<CV> cvs { get; set; }
        public DbSet<Message> messages { get; set; }
        public DbSet<Project> projects { get; set; }

        
        public OurDBContext() : base("DefaultConnection")
        {

        }
    }
}
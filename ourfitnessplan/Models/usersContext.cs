using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ourfitnessplan.Models
{
    public class usersContext : DbContext
    {
        public usersContext() : base("name=DataContext")
        {

        }
        public DbSet<users> users { get; set; }

        public DbSet<tbl_posts> tbl_Posts { get; set; }
        public DbSet<tbl_Category> tbl_Category { get; set; }
    }
}
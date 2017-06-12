using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using HogWarsh.Models;

namespace HogWarsh
{
    public class Context : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<House> Houses { get; set; }
    }
}
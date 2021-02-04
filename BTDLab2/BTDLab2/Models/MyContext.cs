using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BTDLab2.Models
{
    public class MyContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Word> Words { get; set; }
    }
}
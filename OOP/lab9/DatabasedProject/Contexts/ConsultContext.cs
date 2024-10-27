using DatabasedProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasedProject.Contexts
{
    internal class ConsultContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<User> Users { get; set;}
        public DbSet<Subject> Subjects { get; set; }
        readonly string CS = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CS);
            base.OnConfiguring(optionsBuilder);
        }

        public ConsultContext()
        {
            Database.EnsureCreated();
        }
    }
}

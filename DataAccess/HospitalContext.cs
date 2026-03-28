using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace DataAccess
{
    internal class HospitalContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=DESKTOP-ALDICMG;Initial Catalog=HMSDB;Integrated Security=True;TrustServerCertificate=True");

            optionsBuilder.LogTo(log => Debug.WriteLine(log));
        }
    }
}

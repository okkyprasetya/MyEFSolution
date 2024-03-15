using Microsoft.EntityFrameworkCore;
using MyEFSolution.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEFSolution.Data
{
    public class SamuraiContext:DbContext
    {
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quotes> Quotes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\BSISqlExpress;Initial Catalog=LatihanDb;Integrated Security=True;TrustServerCertificate=True;");
        }
    }
}

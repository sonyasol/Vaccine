using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vaccine.Core.Dtos;

namespace Vaccine.Core
{
    public class DataContext:DbContext
    {
        public DbSet<VaccineDto> Vaccines { get; set; }

        public DbSet<UserDto> Users { get; set; }

        public DbSet<SertificateDto> Sertificates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server = localhost; Port = 5432; User Id = postgres; Password = Trololo0+; Database = Vaccine3";
            optionsBuilder.UseNpgsql(connectionString);
        }
    }
}

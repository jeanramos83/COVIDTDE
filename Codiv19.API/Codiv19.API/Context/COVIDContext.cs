using Codiv19.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codiv19.API.Context
{
    public class COVIDContext : DbContext
    {
        public COVIDContext()
        {

        }

        public COVIDContext(DbContextOptions<COVIDContext> options) : base(options)
        {

        }
        public virtual DbSet<Login> login { get; set; }
        public virtual DbSet<Paciente> paciente { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                                        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                                        .AddJsonFile("appsettings.json")
                                        .Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("Covid"));
            }
        }
    }
}

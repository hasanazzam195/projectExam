using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecoundExam.data
{
    public class ClincContext :DbContext
    {
        private  IConfiguration configuration;

        public ClincContext()
        {

        }

        public ClincContext(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        public DbSet<patiant> patiantContext { get; set; }
        public DbSet<Room> roomContext { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Conection"));
            base.OnConfiguring(optionsBuilder);
        }
    }
}

using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;

namespace ASP_NET_Razor_Page_Work_DB.Model
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ElectricalElement> DataBlock_t { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            string? connectionSring = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionSring);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostgreSQL.Domain;
using Microsoft.Extensions.Configuration;

namespace PostgreSQL
{
    public class LastSportDBContext : DbContext
    {
        protected readonly IConfiguration _configuration;

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<HistoryLogin> HistoryLogins { get; set; }

        public LastSportDBContext()
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer();
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=SportDB;Username=postgres;Password=ABRIKOSik2015");
        }
    }
}

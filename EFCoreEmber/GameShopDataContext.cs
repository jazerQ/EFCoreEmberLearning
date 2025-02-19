using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCoreEmber.Model;
using Microsoft.EntityFrameworkCore;

namespace EFCoreEmber
{
    public class GameShopDataContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public GameShopDataContext(DbContextOptions<GameShopDataContext> options) : base(options)
        {
            
        }
        public GameShopDataContext()
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

    }
}

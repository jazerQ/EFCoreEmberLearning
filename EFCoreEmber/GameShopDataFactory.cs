using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EFCoreEmber
{
    public class GameShopDataFactory : IDesignTimeDbContextFactory<GameShopDataContext>
    {
        public GameShopDataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<GameShopDataContext>();
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\jazer\\source\\repos\\EFCoreEmber\\EFCoreEmber\\MyDb.db");
            return new GameShopDataContext(optionsBuilder.Options);
        }
    }
}

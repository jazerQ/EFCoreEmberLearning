using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCoreEmber.Model;
using EFCoreEmber.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace EFCoreEmber
{
    public static class GameShopDataFactory
    {
        private static readonly string pathJson = "C:\\Users\\jazer\\source\\repos\\EFCoreEmber\\EFCoreEmber\\ConnectionString.json";
        public static IServiceProvider DataFactoryCreate()
        {
            IServiceProvider serviceProvider;
            var services = new ServiceCollection();
            string path = ReadPathFromJson();
            services.AddDbContext<GameShopDataContext>(optionsBuilder => optionsBuilder.UseSqlite(path));
            services.AddScoped<IPlayer, PlayerRepository>();
            serviceProvider = services.BuildServiceProvider();
            return serviceProvider;
        }
        private static string ReadPathFromJson() 
        {
            string text = "";
            using (StreamReader reader = new StreamReader(pathJson)) 
            {
                text = reader.ReadToEnd();
            }
            ConString conString = JsonConvert.DeserializeObject<ConString>(text) ?? throw new Exception("I cant convert thisJson");
            return conString.ConnectionString;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCoreEmber.Model;

namespace EFCoreEmber.Repositories
{
    public interface IPlayer
    {
        IEnumerable<Player> GetAll();
        Player GetByEmail(string Email);
        void Add(Player player);
        void Update(Player player);
        void Delete(string Email);
    }
}

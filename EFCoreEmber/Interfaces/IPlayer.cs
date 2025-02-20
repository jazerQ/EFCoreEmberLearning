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
        Task<IEnumerable<Player>> GetAll();
        Task<Player> GetByEmail(string Email);
        Task Add(Player player);
        Task Update(Player player);
        Task Delete(string Email);
    }
}

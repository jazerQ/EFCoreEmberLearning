using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCoreEmber.Model;
using Microsoft.EntityFrameworkCore;

namespace EFCoreEmber.Repositories
{
    public class PlayerRepository : IPlayer
    {
        private readonly GameShopDataContext _context;
        public PlayerRepository(GameShopDataContext context)
        {
            _context = context;
        }
        public void Add(Player player)
        {
            _context.Players.Add(player);
            _context.SaveChanges();
        }

        public void Delete(string Email)
        {
            var player = GetByEmail(Email);
            _context.Players.Remove(player);
        }

        public IEnumerable<Player> GetAll()
        {
            return _context.Players.ToList();
        }

        public Player GetByEmail(string Email)
        {
            var foundPlayer = _context.Players.FirstOrDefault(p => p.Email == Email) ?? throw new Exception("I cant find it");
            return foundPlayer;
        }

        public void Update(Player player)
        {
            _context.Entry(player).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void AnotherWayToUpdate(Player player) 
        {
            _context.Players.Where(p => p == player).ExecuteUpdateAsync(pl => pl.SetProperty(pr => pr.Username, player.Username)
                                                                                            .SetProperty(pr => pr.Name, player.Name)
                                                                                            .SetProperty(pr => pr.Email, player.Email)
                                                                                            );
            _context.SaveChanges();
        }
    }
}

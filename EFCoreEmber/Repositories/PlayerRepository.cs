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
        public async Task Add(Player player)
        {
            await _context.Players.AddAsync(player);
        }

        public async Task Delete(string Email)
        {
            await _context.Players.Where(p => p.Email == "Email").ExecuteDeleteAsync();
        }

        public async Task<IEnumerable<Player>> GetAll()
        {
            return await _context.Players.ToListAsync();
        }

        public async Task<Player> GetByEmail(string Email)
        {
            var foundPlayer = await _context.Players.FirstOrDefaultAsync(p => p.Email == Email) ?? throw new Exception("I cant find it");
            return foundPlayer;
        }

        public async Task Update(Player player)
        {
            _context.Entry(player).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task AnotherWayToUpdate(Player player) 
        {
            await _context.Players.Where(p => p == player).ExecuteUpdateAsync(pl => pl.SetProperty(pr => pr.Username, player.Username)
                                                                                            .SetProperty(pr => pr.Name, player.Name)
                                                                                            .SetProperty(pr => pr.Email, player.Email)
                                                                                            );
            await _context.SaveChangesAsync();
        }
    }
}

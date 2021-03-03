using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPlayersService
    {
        Task<Player> AddPlayer(Player player);
        Task<List<Player>> GetPlayers();
        Task<Player> FindPlayer(int id);
        Task<Player> UpdatePlayer(Player player);
        Task DeletePlayer(int id);
    }
}

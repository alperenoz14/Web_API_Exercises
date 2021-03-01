using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPlayersService
    {
        Player AddPlayer(Player player);
        List<Player> GetPlayers();
        Player FindPlayer(int id);
        Player UpdatePlayer(Player player);
        void DeletePlayer(int id);
    }
}

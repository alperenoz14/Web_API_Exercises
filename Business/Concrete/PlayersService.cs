using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PlayersService : IPlayersService
    {
        IPlayersDAL _playersDal;
        public PlayersService(IPlayersDAL playersDal)
        {
            _playersDal = playersDal;
        }

        public async Task<Player> AddPlayer(Player player)
        {
            return await _playersDal.AddPlayer(player);
        }

        public async Task DeletePlayer(int id)
        {
            await _playersDal.DeletePlayer(id);
        }

        public async Task<Player> FindPlayer(int id)
        {
            return await _playersDal.FindPlayer(id);
        }

        public async Task<List<Player>> GetPlayers()
        {
            return await _playersDal.GetPlayers();
        }

        public async Task<Player> UpdatePlayer(Player player)
        {
            return await _playersDal.UpdatePlayer(player);
        }
    }
}

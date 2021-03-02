using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PlayersService : IPlayersService
    {
        IPlayersDAL _playersDal;
        public PlayersService(IPlayersDAL playersDal)
        {
            _playersDal = playersDal;
        }

        public Player AddPlayer(Player player)
        {
            return _playersDal.AddPlayer(player);
        }

        public void DeletePlayer(int id)
        {
            _playersDal.DeletePlayer(id);
        }

        public Player FindPlayer(int id)
        {
            return _playersDal.FindPlayer(id);
        }

        public List<Player> GetPlayers()
        {
            return _playersDal.GetPlayers();
        }

        public Player UpdatePlayer(Player player)
        {
            return _playersDal.UpdatePlayer(player);
        }
    }
}

using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class PlayersDAL : IPlayersDAL
    {
        public Player AddPlayer(Player player)
        {
            using (var _myContext= new TeamContext())
            {
                _myContext.Players.Add(player);
                _myContext.SaveChanges();
                return player;
            }
        }

        public void DeletePlayer(int id)
        {
            using (var _myContext = new TeamContext())
            {
                var playerToDelete = _myContext.Players.Find(id);
                _myContext.Players.Remove(playerToDelete);
                _myContext.SaveChanges();
            }
        }

        public Player FindPlayer(int id)
        {
            using (var _myContext = new TeamContext())
            {
                return _myContext.Players.Find(id);
                
            }
        }

        public List<Player> GetPlayers()
        {
            using (var _myContext = new TeamContext())
            {
                return _myContext.Players.ToList();
            }
        }

        public Player UpdatePlayer(Player player)
        {
            using (var _myContext = new TeamContext())
            {
                _myContext.Players.Update(player);
                _myContext.SaveChanges();
                return player;
            }
        }
    }
}

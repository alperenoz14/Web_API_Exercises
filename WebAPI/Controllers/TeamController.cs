using Business.Abstract;
using Business.Concrete;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private IPlayersService _IPlayerService;
        public TeamController(IPlayersService playersService)
        {
            _IPlayerService = playersService;
        }

        [HttpPost]
        public Player Add([FromBody]Player player)
        {
            return _IPlayerService.AddPlayer(player);
        }

        [HttpGet]
        public List<Player> GetAll()
        {
            return _IPlayerService.GetPlayers();
        }

        [HttpGet("{id}")]
        public Player Find(int id)
        {
            return _IPlayerService.FindPlayer(id);
        }

        [HttpPut]
        public Player Update([FromBody]Player player)
        {
            return _IPlayerService.UpdatePlayer(player);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _IPlayerService.DeletePlayer(id);
        }
    }
}

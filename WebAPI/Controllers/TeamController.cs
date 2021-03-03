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
        [Route("[action]")]
        public async Task<IActionResult> AddPlayer([FromBody] Player player)
        {
            var createdPlayer = await _IPlayerService.AddPlayer(player);
            return CreatedAtAction("FindPlayer", new { id = createdPlayer.ID }, createdPlayer); //201 + createdPlayer
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllPlayers()
        {
            return Ok(await _IPlayerService.GetPlayers());
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> FindPlayer(int id)
        {
            var player = await _IPlayerService.FindPlayer(id);
            if (player != null)
            {
                return Ok(await _IPlayerService.FindPlayer(id)); //200+ player
            }
            return NotFound(); //404
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdatePlayer([FromBody] Player player)
        {
            if (await _IPlayerService.FindPlayer(player.ID) != null)
            {
                return Ok(await _IPlayerService.UpdatePlayer(player)); //200 ok
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task<IActionResult> DeletePlayer(int id)
        {
            if (await _IPlayerService.FindPlayer(id) != null)
            {
                await _IPlayerService.DeletePlayer(id);
                return Ok();
            }
            return NotFound();
        }
    }
}

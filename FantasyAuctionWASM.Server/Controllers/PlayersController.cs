// FantasyAuctionWASM.Server/Controllers/PlayersController.cs
using Microsoft.AspNetCore.Mvc;
using FantasyAuctionWASM.Shared;
using FantasyAuctionWASM.Server.Services;
using System.Collections.Generic;

namespace FantasyAuctionWASM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly PlayerService _playerService;

        public PlayersController(PlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpGet]
        public ActionResult<List<Player>> GetAvailablePlayers()
        {
            return Ok(_playerService.GetAvailablePlayers());
        }
    }
}

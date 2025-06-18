// FantasyAuctionWASM.Server/Services/PlayerService.cs
using System.Collections.Generic;
using FantasyAuctionWASM.Shared; // Added using for Shared models

namespace FantasyAuctionWASM.Server.Services // Updated namespace
{
    public class PlayerService
    {
        // TODO: Implement methods for managing players
        public List<Player> GetAvailablePlayers() => new List<Player> { new Player { Id = 1, Name = "Player 1", Position = "QB" } };
    }
}

// FantasyAuctionApp/Services/PlayerService.cs
using System.Collections.Generic;
namespace FantasyAuctionApp.Services
{
    public class Player // Basic player model
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Default Player";
        public string Position { get; set; } = "Default Position";
    }

    public class PlayerService
    {
        // TODO: Implement methods for managing players
        public List<Player> GetAvailablePlayers() => new List<Player> { new Player { Id = 1, Name = "Player 1", Position = "QB" } };
    }
}

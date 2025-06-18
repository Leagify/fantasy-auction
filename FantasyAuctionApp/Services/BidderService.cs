// FantasyAuctionApp/Services/BidderService.cs
using System.Collections.Generic;
namespace FantasyAuctionApp.Services
{
    public class Bidder // Basic bidder model
    {
        public string Id { get; set; } = "DefaultBidder";
        public string Name { get; set; } = "Bidder Name";
        public double Budget { get; set; } = 100.00;
        public List<Player> Roster { get; set; } = new List<Player>();
    }

    public class BidderService
    {
        // TODO: Implement methods for managing bidders (add, update budget, manage roster)
        public Bidder GetBidderDetails(string bidderId) => new Bidder { Id = bidderId, Name = "Test Bidder" };
    }
}

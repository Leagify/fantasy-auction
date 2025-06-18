// FantasyAuctionWASM.Server/Services/BidderService.cs
using FantasyAuctionWASM.Shared; // Added using for Shared models

namespace FantasyAuctionWASM.Server.Services // Updated namespace
{
    public class BidderService
    {
        // TODO: Implement methods for managing bidders (add, update budget, manage roster)
        public Bidder GetBidderDetails(string bidderId) => new Bidder { Id = bidderId, Name = "Test Bidder" };
    }
}

// FantasyAuctionWASM.Shared/Bidder.cs
using System.Collections.Generic; // Added for List<T>
// Assuming Player class is also in FantasyAuctionWASM.Shared, so no explicit using needed if in same namespace
// If Player is in a different sub-namespace of Shared, or if this file structure implies it, that might need adjustment.
// For now, assuming Player is directly under FantasyAuctionWASM.Shared.

namespace FantasyAuctionWASM.Shared // Updated namespace
{
    public class Bidder // Basic bidder model
    {
        public string Id { get; set; } = "DefaultBidder";
        public string Name { get; set; } = "Bidder Name";
        public double Budget { get; set; } = 100.00;
        public List<Player> Roster { get; set; } = new List<Player>();
    }
}

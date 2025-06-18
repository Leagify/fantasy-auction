// FantasyAuctionWASM.Shared/Player.cs
namespace FantasyAuctionWASM.Shared // Updated namespace
{
    public class Player // Basic player model
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Default Player";
        public string Position { get; set; } = "Default Position";
    }
}

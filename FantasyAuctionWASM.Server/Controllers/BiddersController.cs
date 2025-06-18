// FantasyAuctionWASM.Server/Controllers/BiddersController.cs
using Microsoft.AspNetCore.Mvc;
using FantasyAuctionWASM.Shared;
using FantasyAuctionWASM.Server.Services;

namespace FantasyAuctionWASM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BiddersController : ControllerBase
    {
        private readonly BidderService _bidderService;

        public BiddersController(BidderService bidderService)
        {
            _bidderService = bidderService;
        }

        [HttpGet("{id}")]
        public ActionResult<Bidder> GetBidder(string id)
        {
            // In a real app, you'd validate the ID and handle not found cases
            var bidder = _bidderService.GetBidderDetails(id);
            if (bidder == null)
            {
                // The current GetBidderDetails stub always returns a bidder,
                // but in a real scenario, it might return null.
                return NotFound();
            }
            return Ok(bidder);
        }
    }
}

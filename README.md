# fantasy-auction
A fantasy auction drafter for custom and obscure leagues

Likely, this repository will be some sort of C# SignalR web application.

## General design:
+ Items up for auction will have two properties (similar to Player and Position)
+ Each bidder will be trying to fill a "roster" of "positions"
+ Each bidder will have a budget, which is editable before the auction begins, but not afterwards.
+ Bidders agree to join an "auction" and the auction order is set up in a normal order.
+ The auction includes a known list of potential "players" (no values are pre-assigned, at this point)
+ Each bidder can view:
  - The remaining "players" available
  - The "player" up for bid
  - The current bid
  - Current highest bidder
  - The bidder's "roster"
  - The bidder's available money
+ Each bidder can put a "player" up for bid.
+ Bidding continues until all other players pass or no other player can afford to bid (determined by remaining spots in roster multiplied by minimum bid amount).
+ After bidding completes, the "player" is placed on the bidders roster, and the amount is deducted from the bidders budget.
+ If a bidder's roster is full, they can no longer nominate players for bid.
+ Bidding continues until each player's roster is full.
+ At the completion of the auction, a CSV can be downloaded, which contains:
  - The bidder name
  - The player name
  - The position
  - The auction cost
  
Nice to haves:

+ We could save the auction CSV result file somewhere on the server for later viewing
+ We could color code the "positions"

Technologies:
+ ASP.NET (or ASP.NET Core)
+ SignalR
+ Blazor? (not required, but an interesting idea)
  
  Potential repositories to view for inspiration:
  + https://github.com/moozzyk/SignalRCoreAuction
  + https://github.com/badunk/fantasy-auction
  + https://github.com/hasael/AuctionHouse
  + https://github.com/HDaoud/AuctionSite
  + https://github.com/elyor0529/Luxurious-Artworks
  + https://github.com/m7schumacher/FantasyFootballApplication

## Development in GitHub Codespaces

This project is configured for development in [GitHub Codespaces](https://github.com/features/codespaces).

To get started:

1.  Click the **Code** button on the repository page.
2.  Select the **Open with Codespaces** tab.
3.  Click **New codespace**. GitHub will prepare a development environment for you.

Once the Codespace is ready:

*   The solution (`FantasyAuctionWASM.sln`) will be automatically built due to the `postCreateCommand` in the `devcontainer.json` configuration.
*   To run and debug the application:
    1.  Open the **Run and Debug** view in the VS Code sidebar (usually a play button with a bug icon).
    2.  Select the **"Launch Server (WASM Hosted)"** configuration from the dropdown menu.
    3.  Click the green play button (Start Debugging) or press F5.
*   The server will start, and Codespaces should automatically forward the necessary port. A browser tab might open automatically, or you can open it manually using the URL provided in the "Ports" tab in VS Code.

This setup allows you to build, run, debug, and test the application entirely within your browser.

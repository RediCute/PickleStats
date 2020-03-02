using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PickleStats.Data
{
    public class Auctions
    {
        [JsonProperty("auction")]
        public List<Auction> Auction { get; }
    }

    public class Auction
    {
        [JsonProperty("uuid")]
        public string Uuid { get; }

        [JsonProperty("auctioneer")]
        public string Auctioneer { get; }

        [JsonProperty("profile_id")]
        public string ProfileId { get; }

        [JsonProperty("coop")]
        public List<string> Coop { get; }

        [JsonProperty("Start")]
        public DateTime Start { get; }

        [JsonProperty("End")]
        public DateTime End { get; }

        [JsonProperty("item_name")]
        public string ItemName { get; }

        [JsonProperty("item_lore")]
        public string item_lore { get; }

        [JsonProperty("extra")]
        public string Extra { get; }

        [JsonProperty("catagory")]
        public string Catagory { get; }

        [JsonProperty("tier")]
        public string Tier { get; }

        [JsonProperty("starting_bid")]
        public int StartingBid { get; }

        [JsonProperty("item_bytes")]
        public string ItemBytes { get; }

        [JsonProperty("claimed")]
        public bool Claimed { get; }

        [JsonProperty("claimed_bidders")]
        public List<string> ClaimedBidders { get; }

        [JsonProperty("highest_bid_amount")]
        public int HighestBidAmount { get; }

        [JsonProperty("bids")]
        public List<Bid> Bids { get; }
    }

    public class Bid
    {
        [JsonProperty("auction_id")]
        public string AuctionId { get; }

        [JsonProperty("bidder")]
        public string Bidder { get; }

        [JsonProperty("profile_id")]
        public string ProfileId { get; }

        [JsonProperty("amount")]
        public int Amount { get; }

        [JsonProperty("Timestamp")]
        public string Timestamp { get; }
    }
}

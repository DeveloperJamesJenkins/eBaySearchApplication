using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindingAPI
{
    public partial class findItemsAdvanced
    {

        /// <summary>
        /// Sort the returned items according to a single specified sort order.
        /// </summary>
        /// 
        [Serializable()]
        public enum eBaySortOrder
        {
            /// <summary>
            ///  Sorts items by Best Match, which is based on community buying activity and other relevance-based factors.
            /// </summary>
            BestMatch,
            /// <summary>
            /// Sorts items by the number of bids they have received, with items that have received the fewest bids first. 
            /// </summary>
            BidCountFewest,
            /// <summary>
            /// Sorts items by the number of bids they have received, with items that have received the most bids first. 
            /// </summary>
            BidCountMost,
            /// <summary>
            /// Sorts items available on the the given site by the country in which they are located. For CountryAscending, items located in the country most closely associated with the site appear first, followed by items in related countries, and then items from other countries. 
            /// </summary>
            CountryAscending,
            /// <summary>
            /// Sorts items available on the the given site by the country in which they are located. For CountryDescending, items are sorted in reverse order of CountryAscending. That is, items in countries not specifically related to the site appear first, sorted in descending alphabetical order by English country name. For example, when searching the Ireland site, items located in countries like Yugoslavia or Uganda are returned first. Items located in Ireland (IE) will be returned last. 
            /// </summary>
            CountryDescending,
            /// <summary>
            ///  Sorts items by their current price, with the highest price first.
            /// </summary>
            CurrentPriceHighest,
            /// <summary>
            /// Sorts items by distance from the buyer in ascending order. The request must also include a buyerPostalCode.
            /// </summary>
            DistanceNearest,
            /// <summary>
            /// Sorts items by end time, with items ending soonest listed first.
            /// </summary>
            EndTimeSoonest,
            /// <summary>
            /// Sorts items by the combined cost of the item price plus the shipping cost, with highest combined price items listed first. Items are returned in the following groupings: highest total-cost items (for items where shipping was properly specified) appear first, followed by freight- shipping items, and then items for which no shipping was specified. Each group is sorted by price.
            /// </summary>
            PricePlusShippingHighest,
            /// <summary>
            /// Sorts items by the combined cost of the item price plus the shipping cost, with the lowest combined price items listed first. Items are returned in the following groupings: lowest total-cost items (for items where shipping was properly specified) appear first, followed by freight- shipping items, and then items for which no shipping was specified. Each group is sorted by price.
            /// </summary>
            PricePlusShippingLowest,
            /// <summary>
            /// Sorts items by the start time, the most recently listed (newest) items appear first.
            /// </summary>
            StartTimeNewest

        }
    }
  
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindingAPI
{
    public partial class findItemsAdvancedResponse
    {
        [Serializable()]
        public class eBaySellingStatus
        {
            public int BidCount { get; set; }
            public eBayListingInfo.AmountType ConvertedCurrentPrice { get; set; }
            public eBayListingInfo.AmountType CurrentPrice { get; set; }
            public SellingStateType SellingState { get; set; }
            public TimeSpan TimeLeft { get; set; }


            [Serializable()]
            public enum SellingStateType
            {
                /// <summary>
                /// The listing is still live. It is also possible that the auction has recently ended, but eBay has not completed the final processing (e.g., the high bidder is still being determined). 
                /// </summary>
                Active,
                /// <summary>
                /// The listing has been canceled by either the seller or eBay. 
                /// </summary>
                Canceled, 
                /// <summary>
                /// The listing has ended and eBay has completed the processing of the sale (if any). 
                /// </summary>
                Ended ,
                /// <summary>
                /// The listing has been ended with sales. 
                /// </summary>
                EndedWithSales ,
                /// <summary>
                /// The listing has been ended without sales. 
                /// </summary>
                EndedWithoutSales 


            }
             
        }
    }
}

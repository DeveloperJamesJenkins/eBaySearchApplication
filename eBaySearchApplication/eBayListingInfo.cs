using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindingAPI
{
    public partial class findItemsAdvancedResponse
    {
        [Serializable()]
        public class eBayListingInfo
        {
            public bool BestOfferEnabled { get; set; }
            public bool BuyItNowAvailable { get; set; }
            public AmountType BuyItNowPrice { get; set; }
            public AmountType ConvertedBuyItNowPrice { get; set; }
            public DateTime EndTime { get; set; }
            public bool Gift { get; set; }
            public findItemsAdvanced.ItemFilters.eBayListingType ListingType { get; set; }
            public DateTime startTime { get; set; }



            [Serializable()]
            public class AmountType
            {
                public double Amount { get; set; }
                public string CurrencyID { get; set; }
            }
        }
    }
}

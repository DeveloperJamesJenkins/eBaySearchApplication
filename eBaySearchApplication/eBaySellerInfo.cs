using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindingAPI
{
    public partial class findItemsAdvancedResponse
    {
        [Serializable()]
        public class eBaySellerInfo
        {
            public string FeedbackRatingStar { get; set; }
            public long FeedbackScore { get; set; }
            public double PositiveFeedbackPercent { get; set; }
            public string SellerUserName { get; set; }
            public bool TopRatedSeller { get; set; }
        }
    }
}

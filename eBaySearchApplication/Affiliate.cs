using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindingAPI
{
    /// <summary>
    /// Container for affiliate details
    /// </summary>
    /// 
    [Serializable()]
    public class Affiliate
    {
        /// <summary>
        /// You can define an affiliate customId if you want an ID to monitor your marketing efforts. Chose an ID up to up to 256 characters in length. If you are using the eBay Partner Network, and you provide a customId, the tracking URL returned by the eBay Partner Network will contain your customId value. 
        /// </summary>
        public string CustomID { get; set; }
        /// <summary>
        /// Specifies whether or not to return a lgeo affiliate link. If this parameter is set to 1, a roverized geo-targeted affiliate link is returned.
        /// </summary>
        public bool GeoTargeting { get; set; }
        /// <summary>
        /// Specifies your tracking partner for affiliate commissions. Affiliates earn money from eBay for driving traffic to eBay. This field is required if you specify a tracking ID. Depending on your tracking partner, specify one of the following values. Not all partners are valid for all sites. For PlaceOffer, only the eBay Partner Network and Mediaplex are valid: 
        /// </summary>
        public NetWorkID NetworkID { get; set; }
        /// <summary>
        /// Specify the affiliate value obtained from your tracking partner. For the eBay Partner Network, the tracking ID is the provided Campaign ID ("campid"). A Campaign ID is a unique 10-digit number used for associating traffic and is valid across all programs to which you have been accepted. Another example of this value is the Affiliate ID given to you by TradeDoubler. 
        /// </summary>
        public string TrackingId { get; set; }

        [Serializable()]
        public enum NetWorkID
        {
            BeFree = 2,
            Affilinet = 3,
            TradeDoubler = 4,
            Mediaplex = 5,
            DoubleClick = 6,
            Allyes = 7,
            BJMT = 8,
            eBayPartnerNetwork = 9
        }

    }
}

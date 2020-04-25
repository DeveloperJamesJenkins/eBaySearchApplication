using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FindingAPI
{
    public partial class findItemsAdvancedResponse
    {
        [Serializable()]
        public class Category
        {
            public string CategoryName { get; set; }
            public string CategoryID { get; set; }

        }

        [Serializable()]
        public class eBayItem
        {
            public bool Viewed { get; set; }

            public string CharityID { get; set; }
            public string Compatibility { get; set; }


            public string GlobalID { get; set; }
            public string Country { get; set; }
            public Category SecondaryCategory { get; set; }
            public Category PrimaryCategory { get; set; }
            public string PostalCode { get; set; }

            public string ProductID { get; set; }

            public bool ReturnsAccepted { get; set; }

            public List<string> GalleryPlusPictureURL { get; set; }
            public string PictureURLLarge { get; set; }
            public string PictureURLSuperSize { get; set; }

            public bool GetItFast { get; set; }
            public string ItemId { get; set; }
            public string Title { get; set; }

            public string GalleryURL { get; set; }

            public List<GalleryUrl> GalleryInfoContainer { get; set; }

            public string ViewItemURL { get; set; }
            public List<eBayPaymentMethod> PaymentMethods { get; set; }
            public bool AutoPay { get; set; }
            public string Location { get; set; }
            public ShippingInfo  ShippingInfo { get; set; }
            public eBaySellingStatus SellingStatus { get; set; }
            public eBayListingInfo ListingInfo { get; set; }
            public DistanceType Distance { get; set; }
            public findItemsAdvancedResponse.Condition Condition { get; set; }

            public eBaySellerInfo SellerInfo { get; set; }

            public eBayStoreInfo StoreInfo { get; set; }

            public string SubTitle { get; set; }

           


        }
    }
}

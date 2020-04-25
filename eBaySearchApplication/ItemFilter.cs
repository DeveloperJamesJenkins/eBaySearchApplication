using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace FindingAPI
{
    public partial class findItemsAdvanced
    {
        public ItemFilters ItemFilterList { get; set; }
        /// <summary>
        /// Reduce the number of items returned by a find request using item filters. You can include multiple item filters in a single request. 
        /// </summary>
        /// 
        [Serializable()]
        public class ItemFilters
        {
            

            //put in each item as deriving from a common class with name and that...
            public ItemFilters()
            {

                this.ConditionTypes = new List<int>();
                this.ExcludeCategories = new List<int>();
                this.ExcludeSellers = new List<string>();
                this.ListingTypes = new List<eBayListingType>();
                this.Sellers = new List<string>();
                

            }


           


            /// <summary>
            /// Limits items to those available to the specified country only. Item filter LocatedIn cannot be used together with item filter AvailableTo. 
            /// </summary>
            public eBayServiceCredentials.GlobalID AvailableTo { get; set; }
            public bool AvailableToUsed { get; set; }
            /// <summary>
            /// If true, the search results are limited to only items that have Best Offer enabled. Default is false. 
            /// </summary>
            public bool BestOfferOnly { get; set; }
            /// <summary>
            /// If true, the search results are limited to items for which all or part of the proceeds are given to a charity. Each item in the search results will include the ID of the given charity. Default is false. 
            /// </summary>
            public bool CharityOnly { get; set; }
            /// <summary>
            /// Limits items to those that have the matching item condition. The order of the results depends on the sortOrder you specify (not ordered by conditions). 
            /// </summary>
            public List<int> ConditionTypes { get; set; }
            /// <summary>
            /// Limits results to items listed with the specified currency only. 
            /// </summary>
            public eBayCurrencyIdType Currency { get; set; }
            public bool CurrencyUsed { get; set; }
            /// <summary>
            /// Limits the results to items ending on or after the specified time. Specify a time in the future. 
            /// GMT TIMES ONLY
            /// </summary>
            public DateTime EndTimeFrom { get; set; }
            /// <summary>
            /// Limits the results to items ending on or before the specified time. Specify a time in the future. 
            /// GMT TIMES ONLY
            /// </summary>
            public DateTime EndTimeTo { get; set; }
            /// <summary>
            /// If true, excludes all items requiring immediate payment. Default is false. 
            /// </summary>
            public bool ExcludeAutoPay { get; set; }
            /// <summary>
            /// Specify one or more category IDs. Search results will not include items from the specified categories or their child categories. 
            /// </summary>
            public List<int> ExcludeCategories { get; set; }
            /// <summary>
            /// Specify one or more seller names. Search results will not include items from the specified sellers. The ExcludeSeller item filter cannot be used together with either the Seller or TopRatedSellerOnly item filters. 
            /// </summary>
            public List<string> ExcludeSellers { get; set; }
            /// <summary>
            /// Specifies the type of expedited shipping. You can specify either Expedited or OneDayShipping. Only items that can be shipped by the specified type are returned. 
            //// ExpeditedShippingType is used together with the MaxHandlingTime and ReturnsAcceptedOnly filters to filter items for certain kinds of gifting events such as birthdays or holidays where the items must be delivered by a certain date. If you wish to mimic the behavior of the eBay holiday filters, you would use ExpeditedShippingType set to either Expedited or OneDayShipping, MaxHandlingTime to 1, ReturnsAcceptedOnly set to true, and for the Germany site, set PaymentMethod to PayPal. 
            /// </summary>
            public ExpeditedShippingType ExpeditedShipping { get; set; }
            public bool ExpeditedShippingTypeUsed { get; set; } //untested
            /// <summary>
            /// If true, the search results are limited to featured item listings only. Default is false.
            /// </summary>
            public bool FeaturedOnly { get; set; }
            /// <summary>
            /// Specifies the maximum feedback score of a seller whose items can be included in the response. If FeedbackScoreMin is also specified, the FeedbackScoreMax value must be greater than or equal to the FeedbackScoreMin value. 
            /// </summary>
            public int FeedbackScoreMax { get; set; }
            /// <summary>
            /// ecifies the mininum feedback score of a seller whose items can be included in the response. If FeedbackScoreMax is also specified, the FeedbackScoreMax value must be greater than or equal to the FeedbackScoreMin value. 
            /// </summary>
            public int FeedbackScoreMin { get; set; }
            /// <summary>
            /// If true, the search results are limited to only items with free shipping to the site specified in the request 
            /// </summary>
            public bool FreeShippingOnly { get; set; }
            /// <summary>
            /// If true, the search results are limited to only Get It Fast listings. Default is false. 
            /// </summary>
            public bool GetItFastOnly { get; set; }
            /// <summary>
            /// If true, and there are duplicate items for an item in the search results, the subsequent duplicates will not appear in the results. Default is false.
            ///Item listings are considered duplicates when all of the ollowing conditions are met:
            ///1. Items are listed by the same seller
            ///2. Items have exactly the same item title
            ///3. Items have similar listing formats: 
            ///- Auctions (Auction Items and Auction BIN items)
            ///- Fixed Price (Fixed Price, Multi-quantity Fixed Price, Fixed Price with Best Offer, and Store Inventory Format items)
            ///- Classified Ads
            ///For Auctions, items must also have the same price and number of bids to be considered duplicates. 
            /// </summary>
            public bool HideDuplicateItems { get; set; }
            /// <summary>
            /// The site on which the items were originally listed. This can be useful for buyers who wish to see only items on their domestic site either for delivery cost reasons or time reasons, such as for gifting occasions like birthdays or holidays. 
            /// </summary>
            public eBayServiceCredentials.GlobalID ListedIn { get; set; }
            public bool ListedInUsed { get; set; }
            /// <summary>
            /// Filters items based listing type information. Default behavior is to return all matching items, except Store Inventory format listings. 
            /// </summary>
            public List<eBayListingType> ListingTypes { get; set; }
            /// <summary>
            /// If true, the search results are limited to only items which have local pickup available. Default is false. 
            /// </summary>
            public bool LocalPickupOnly { get; set; }

            [Serializable()]
            public class ProximityType
            {
                public string BuyerPostalCode { get; set; }
                public int MaxDistance { get; set; }
                /// <summary>
                /// If true, the search results are limited to only matching items with the Local Inventory Listing Options (LILO). Must be used together with the MaxDistance item filter, and the request must also specify buyerPostalCode. Currently, this is only available for the Motors site
                /// </summary>
                public bool LocalSearchOnly { get; set; }
            }
            /// <summary>
            /// For Local Searches using PostCode and MaxDistance
            /// </summary>
            public ProximityType Proximity { get; set; }
            /// <summary>
            /// Limits the result set to just those items located in the specified country. Item filter AvailableTo cannot be used together with item filter LocatedIn.
            /// </summary>
            public eBayServiceCredentials.GlobalID LocatedIn { get; set; }
            public bool LocatedInUsed { get; set; }
            /// <summary>
            /// If true, the search results are limited to only matching listings for which the lot size is 2 or more. Default is false. 
            /// </summary>
            public bool LotsOnly { get; set; }
            //Limits the results to items with bid counts less than or equal to the specified value. If MinBids is also specified, the MaxBids value must be greater than or equal to the MinBids value. 
            public int MaxBids { get; set; }
            /// <summary>
            /// Specifies the maximum number of handling days the seller requires to ship the item. Only items with a handling time less than or equal to this number will be returned. (The handling time is the amount of time, in days, required by the seller to get the item ready to ship and handed off to the actual carrier who does the delivery. It does not include the time required by the carrier to deliver the item. 
            ///ExpeditedShippingType is used together with the MaxHandlingTime and ReturnsAcceptedOnly filters to filter items for certain kinds of gifting events such as birthdays or holidays where the items must be delivered by a certain date.
            /// </summary>
            public int MaxHandlingTime { get; set; }
            /// <summary>
            /// Specifies the maximum current price an item can have to be included in the response. Optionally, you can also specify a currency ID, using the paramName and paramValue fields (e.g., ¶mName=Currency¶mValue=EUR). If using with MinPrice to specify a price range, the MaxPrice value must be greater than or equal to MinPrice
            /// </summary>
            public decimal MaxPrice { get; set; }
            /// <summary>
            /// Limits the results to listings with a quantity less than or equal to the specified value. If MinQuantity is also specified, the MaxQuantity value must be greater than or equal to the MinQuantity value. 
            /// </summary>
            public int MaxQuantity { get; set; }
            /// <summary>
            /// Limits the results to items with bid counts greater than or equal to the specified value. If MaxBids is also specified, the MaxBids value must be greater than or equal to the MinBids value. 
            /// </summary>
            public int MinBids { get; set; }
            /// <summary>
            /// Specifies the minimum current price an item can have to be included in the response. Optionally, you can also specify a currency ID, using the paramName and paramValue fields (e.g., ¶mName=Currency¶mValue=EUR). If using with MaxPrice to specify a price range, the MaxPrice value must be greater than or equal to MinPrice. 
            /// </summary>
            public decimal MinPrice { get; set; }
            /// <summary>
            /// Limits the results to listings with a quantity greater than or equal to the specified value. If MaxQuantity is also specified, the MaxQuantity value must be greater than or equal to the MinQuantity value. 
            /// </summary>
            public int MinQuantity { get; set; }
            /// <summary>
            /// Limits the results to active items whose status has changed since the specified time. Specify a time in the past. Time must be in GMT. 
            /// </summary>
            public DateTime ModTimeFrom { get; set; }
            /// <summary>
            /// Limits results to items that accept the specified payment method. 
            /// </summary>
            public List<eBayPaymentMethod> PaymentMethods { get; set; }
            public bool PaymentMethodUsed{get; set;}
            /// <summary>
            /// If set to true, returns only items where the seller accepts returns. 
            /// ExpeditedShippingType is used together with the MaxHandlingTime and ReturnsAcceptedOnly filters to filter items for certain kinds of gifting events such as birthdays or holidays where the items must be delivered by a certain date.
            /// </summary>
            public bool ReturnsAcceptedOnly { get; set; }
            /// <summary>
            /// Specify one or more seller names. Search results will include items from the specified sellers only. The Seller item filter cannot be used together with either the ExcludeSeller or TopRatedSellerOnly item filters. 
            /// </summary>
            public List<string> Sellers { get; set; }
            /// <summary>
            /// Restricts the items to those that are from sellers whose business type is the specified value. Only one value can be specified. 
            ///Not supported on all sites. Applies only to the following sites, which support seller business features: 
            /// </summary>
            public SellerBusinessType BusinessType { get; set; }
            public bool BusinessTypeUsed { get; set; }
            /// <summary>
            /// If true, the search results are limited to only matching items where the seller qualifies as a top-rated seller on the specified site. 
            /// The TopRatedSellerOnly item filter is supported for the following sites only: US , Motors , UK, IE , DE , AT  and CH. 
            /// </summary>
            public bool TopRatedSellerOnly { get; set; }
            /// <summary>
            /// This filter can be used in conjunction with the sortOrder PricePlusShippingLowest to return competitively priced items from eBay top-rated sellers that have a BuyItNow price, with the lowest priced item at the top of the list. This filter returns items from categories that are catalog-enabled; items from non catalog-enabled categories are not returned. Sellers can use this item filter to determine competitive pricing; buying applications can use it to obtain competitive items from top rated sellers that are likely to sell quickly. 
            /// </summary>
            public bool ValueBoxInventory{get; set;}
            /// <summary>
            /// If true, the search results are limited to only items listed in the World of Good marketplace. Defaults to false.
            /// </summary>
            public bool WorldOfGoodOnly { get; set; }

            [Serializable()]
            public enum eBayListingType
            {
                /// <summary>
                /// Retrieve matching auction listings (i.e., listings eligible for competitive bidding at auction) only. Excludes auction items with Buy It Now. 
                /// </summary>
                Auction,
                /// <summary>
                /// Retrieve all matching auction listings with Buy It Now available. Excludes auction listings without Buy It Now. An auction listed with Buy It Now will not be returned if a valid bid has been placed on the auction. 
                /// </summary>
                AuctionWithBIN,
                /// <summary>
                /// Retrieve matching fixed price items only. Excludes Store Inventory format items. 
                /// </summary>
                FixedPrice,
                /// <summary>
                /// Retrieves Classified Ad format (i.e., Classified and AdFormat listing type) listings only. 
                /// </summary>
                Classified,
                /// <summary>
                /// Retrieve Store Inventory format items only. 
                /// </summary>
                StoreInventory,
                /// <summary>
                /// Retrieve matching items for any listing type.
                /// </summary>
                All

            }

            [Serializable()]
            public enum eBayConditionType
            {
                /// <summary>
                /// New (or the equivalent). Excludes items with used, refurbished, for parts, or unspecified conditions. 
                /// </summary>
                New = 1000,
                /// <summary>
                /// New other (see details) 
                /// </summary>
                New_Other = 1500,
                /// <summary>
                /// New with defects
                /// </summary>
                New_With_Defects = 1750,
                /// <summary>
                /// Manufacturer refurbished 
                /// </summary>
                Manufacturer_Refurbished = 2000,
                /// <summary>
                /// Seller refurbished 
                /// </summary>
                Seller_Refurbished = 2500,
                /// <summary>
                /// Used, refurbished, or for parts. Excludes items with new or unspecified conditions. 
                /// </summary>
                Used = 3000,
                /// <summary>
                /// Very Good 
                /// </summary>
                Very_Good = 4000,
                /// <summary>
                /// Good stuff
                /// </summary>
                Good = 5000,
                /// <summary>
                /// Acceptable
                /// </summary>
                Acceptable = 6000,
                /// <summary>
                /// For parts or not working 
                /// </summary>
                For_Parts_Or_Not_Working = 7000



            }

            [Serializable()]
            public enum eBayCurrencyIdType
            {
                /// <summary>
                /// Australian Dollar
                /// </summary>
                AUD,
                /// <summary>
                /// Canadian Dollar.
                /// </summary>
                CAD,
                /// <summary>
                /// Swiss Franc.
                /// </summary>
                CHF,
                /// <summary>
                /// Chinese Chinese Renminbi.
                /// </summary>
                CNY,
                /// <summary>
                /// Euro
                /// </summary>
                EUR,
                /// <summary>
                /// Pound Sterling
                /// </summary>
                GBP,
                /// <summary>
                /// Hong Kong Dollar.
                /// </summary>
                HKD,
                /// <summary>
                /// Indian Rupee.
                /// </summary>
                INR,
                /// <summary>
                /// Malaysian Ringgit.
                /// </summary>
                MYR,
                /// <summary>
                /// Philippines Peso. 
                /// </summary>
                PHP,
                /// <summary>
                /// Poland, Zloty
                /// </summary>
                PLN,
                /// <summary>
                /// Swedish Krona.
                /// </summary>
                SEK,
                /// <summary>
                /// Singapore Dollar.
                /// </summary>
                SGD,
                /// <summary>
                /// New Taiwan Dollar. 
                /// </summary>
                TWD,
                /// <summary>
                /// US Dollar.
                /// </summary>
                USD
            }

            [Serializable()]
            public enum ExpeditedShippingType
            {
                Expedited,
                OneDayShipping
            }


            [Serializable()]
            public enum SellerBusinessType
            {
                /// <summary>
                /// The seller is registered as a business on eBay. 
                /// </summary>
                Business,
                /// <summary>
                /// The seller is registered as an individual on eBay. 
                /// </summary>
                Private

            }

        }



        private string GetFilters(ItemFilters itemFilters)
        {
            int val = 0; //for each value increment
            int findx = 0; // for itemFilter Index

            string searl = "";

            if (itemFilters.AvailableToUsed)
            {
                searl += "&itemFilter(" + findx.ToString() + ").name=AvailableTo";
                searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=" + itemFilters.AvailableTo;
                findx++;
            }


            if (itemFilters.BestOfferOnly)
            {
                searl += "&itemFilter(" + findx.ToString() + ").name=BestOfferOnly";
                searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=true";
                findx++;
            }


            if (itemFilters.CharityOnly)
            {
                searl += "&itemFilter(" + findx.ToString() + ").name=CharityOnly";
                searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=true";
                findx++;
            }


            if (itemFilters.ConditionTypes.Count > 0)
            {
                searl += "&itemFilter(" + findx.ToString() + ").name=Condition";
                foreach (int elt in itemFilters.ConditionTypes)
                {
                   //  object op = Enum.Parse(typeof(findItemsAdvanced.ItemFilters.eBayConditionType), elt.ToString());

                  //  object op = Enum.Parse(typeof(ItemFilters.eBayConditionType), elt.ToString());

                    //test
                   // searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=1000";

                   searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=" + elt.ToString();
                    val++;
                }

                val = 0; //reset after for each new itemFilter id
                findx++; // increment itemFilter Index
            }



            if (itemFilters.CurrencyUsed)
            {
                searl += "&itemFilter(" + findx.ToString() + ").name=Currency";
                searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=" + itemFilters.Currency;
                findx++;
            }

            if (itemFilters.EndTimeFrom > DateTime.UtcNow)
            {
                searl += "&itemFilter(" + findx.ToString() + ").name=EndTimeFrom";
                searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=" + itemFilters.EndTimeFrom.ToString("o");
                findx++;
            }


            if (itemFilters.EndTimeTo > DateTime.UtcNow)
            {
                searl += "&itemFilter(" + findx.ToString() + ").name=EndTimeTo";
                searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=" + itemFilters.EndTimeTo.ToString("o");
                findx++;
            }

            if (itemFilters.ExcludeAutoPay)
            {
                searl += "&itemFilter(" + findx.ToString() + ").name=ExcludeAutoPay";
                searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=true";
                findx++;
            }


            if (itemFilters.ExcludeCategories.Count > 0)
            {
                searl += "&itemFilter(" + findx.ToString() + ").name=ExcludeCategory";


                foreach (int elt in itemFilters.ExcludeCategories)
                {
                    searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=" + elt.ToString();
                    val++;
                }

                val = 0; //reset after for each new itemFilter id
                findx++; // increment itemFilter Index
            }


            if (itemFilters.ExcludeSellers.Count > 0)
            {
                searl += "&itemFilter(" + findx.ToString() + ").name=ExcludeSeller";


                foreach (string elt in itemFilters.ExcludeSellers)
                {
                    searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=" + elt.ToString();
                    val++;
                }

                val = 0; //reset after for each new itemFilter id
                findx++; // increment itemFilter Index
            }


            if (itemFilters.ExpeditedShippingTypeUsed)
            {
                searl += "&itemFilter(" + findx.ToString() + ").name=ExpeditedShippingType";
                searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=" + itemFilters.ExpeditedShipping;


                findx++; // increment itemFilter Index
            }


            if (itemFilters.FeaturedOnly)
            {
                searl += "&itemFilter(" + findx.ToString() + ").name=FeaturedOnly";
                searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=true";


                findx++; // increment itemFilter Index
            }


            if ((itemFilters.FeedbackScoreMin < itemFilters.FeedbackScoreMax) & itemFilters.FeedbackScoreMin > 0)
            {
                searl += "&itemFilter(" + findx.ToString() + ").name=FeedbackScoreMin";
                searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=" + itemFilters.FeedbackScoreMin;



                findx++; // increment itemFilter Index
            }


            if ((itemFilters.FeedbackScoreMax > itemFilters.FeedbackScoreMin) & itemFilters.FeedbackScoreMax > 0)
            {
                searl += "&itemFilter(" + findx.ToString() + ").name=FeedbackScoreMax";
                searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=" + itemFilters.FeedbackScoreMax;


                findx++; // increment itemFilter Index
            }


            if (itemFilters.FreeShippingOnly)
            {
                searl += "&itemFilter(" + findx.ToString() + ").name=FreeShippingOnly";
                searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=true";


                findx++; // increment itemFilter Index
            }

            if (itemFilters.GetItFastOnly)
            {
                searl += "&itemFilter(" + findx.ToString() + ").name=GetItFastOnly";
                searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=true";


                findx++; // increment itemFilter Index
            }


            if (itemFilters.HideDuplicateItems)
            {
                searl += "&itemFilter(" + findx.ToString() + ").name=HideDuplicateItems";
                searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=true";


                findx++; // increment itemFilter Index
            }


            if (itemFilters.ListedInUsed)
            {
                searl += "&itemFilter(" + findx.ToString() + ").name=ListedIn";
                searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=EBAY-" + itemFilters.ListedIn;


                findx++; // increment itemFilter Index
            }



            if (itemFilters.ListingTypes.Count > 0)
            {
                searl += "&itemFilter(" + findx.ToString() + ").name=ListingType";


                foreach (ItemFilters.eBayListingType elt in itemFilters.ListingTypes)
                {
                    searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=" + elt.ToString();
                    val++;
                }

                val = 0; //reset after for each new itemFilter id
                findx++; // increment itemFilter Index
            }


            if (itemFilters.LocalPickupOnly)
            {
                searl += "&itemFilter(" + findx.ToString() + ").name=LocalPickupOnly";
                searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=true";


                findx++; // increment itemFilter Index
            }


            if (itemFilters.LocatedInUsed)
            {
                searl += "&itemFilter(" + findx.ToString() + ").name=LocatedIn";
                searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=" + itemFilters.LocatedIn;
                findx++; // increment itemFilter Index
            }


            if (itemFilters.LotsOnly)
            {
                searl += "&itemFilter(" + findx.ToString() + ").name=LotsOnly";
                searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=true";
                findx++; // increment itemFilter Index
            }


            if (itemFilters.MaxBids > 0)
            {
                searl += "&itemFilter(" + findx.ToString() + ").name=MaxBids";
                searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=" + itemFilters.MaxBids.ToString();
                findx++; // increment itemFilter Index
            }

            if (itemFilters.MaxHandlingTime > 0)
            {
                searl += "&itemFilter(" + findx.ToString() + ").name=MaxHandlingTime";
                searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=" + itemFilters.MaxHandlingTime.ToString();
                findx++; // increment itemFilter Index
            }


            if (itemFilters.MaxPrice > 0)
            {
                searl += "&itemFilter(" + findx.ToString() + ").name=MaxPrice";
                searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=" + itemFilters.MaxPrice.ToString();
                findx++; // increment itemFilter Index
            }

            if (itemFilters.MaxQuantity > 0)
            {
                searl += "&itemFilter(" + findx.ToString() + ").name=MaxQuantity";
                searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=" + itemFilters.MaxQuantity.ToString();
                findx++; // increment itemFilter Index
            }

            if (itemFilters.MinBids > 0)
            {
                searl += "&itemFilter(" + findx.ToString() + ").name=MinBids";
                searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=" + itemFilters.MinBids.ToString();
                findx++; // increment itemFilter Index
            }


            if (itemFilters.MinPrice > 0)
            {
                searl += "&itemFilter(" + findx.ToString() + ").name=MinPrice";
                searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=" + itemFilters.MinPrice.ToString();
                findx++; // increment itemFilter Index
            }


            if ((itemFilters.ModTimeFrom < DateTime.UtcNow) & (itemFilters.ModTimeFrom > new DateTime(2000, 1, 1)))
            {
                searl += "&itemFilter(" + findx.ToString() + ").name=ModTimeFrom";
                searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=" + itemFilters.ModTimeFrom.ToString("o");
                findx++;
            }


            if (itemFilters.PaymentMethodUsed)
            {

                if (itemFilters.PaymentMethods.Count > 0)
                {
                    searl += "&itemFilter(" + findx.ToString() + ").name=paymentMethod";


                    foreach (eBayPaymentMethod elt in itemFilters.PaymentMethods)
                    {
                        searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=" + elt.ToString();
                        val++;
                    }

                    val = 0; //reset after for each new itemFilter id
                    findx++; // increment itemFilter Index
                }

                //put as list...
                searl += "&itemFilter(" + findx.ToString() + ").name=PaymentMethod";
                searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=" + itemFilters.PaymentMethods.ToString();
                findx++;
            }

            if (itemFilters.ReturnsAcceptedOnly)
            {
                searl += "&itemFilter(" + findx.ToString() + ").name=ReturnsAcceptedOnly";
                searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=" + itemFilters.ReturnsAcceptedOnly.ToString();
                findx++;
            }


            if (itemFilters.Sellers.Count > 0)
            {
                searl += "&itemFilter(" + findx.ToString() + ").name=Seller";


                foreach (string elt in itemFilters.Sellers)
                {
                    searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=" + elt.ToString();
                    val++;
                }

                val = 0; //reset after for each new itemFilter id
                findx++; // increment itemFilter Index
            }


            if (itemFilters.BusinessTypeUsed)
            {
                searl += "&itemFilter(" + findx.ToString() + ").name=SellerBusinessType";
                searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=" + itemFilters.BusinessType.ToString();
                findx++;
            }


            if (itemFilters.TopRatedSellerOnly)
            {
                searl += "&itemFilter(" + findx.ToString() + ").name=TopRatedSellerOnly";
                searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=true";
                findx++;
            }


            //last
            if (itemFilters.Proximity != null)
            {
                if (itemFilters.Proximity.LocalSearchOnly)
                {
                    searl += "&itemFilter(" + findx.ToString() + ").name=LocalSearchOnly";
                    searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=true";
                    findx++; // increment itemFilter Index
                }



                if (itemFilters.Proximity.MaxDistance > 0)
                {
                    searl += "&itemFilter(" + findx.ToString() + ").name=MaxDistance";
                    searl += "&itemFilter(" + findx.ToString() + ").value(" + val.ToString() + ")=" + itemFilters.Proximity.MaxDistance.ToString();
                    findx++; // increment itemFilter Index

                }


                if (itemFilters.Proximity.BuyerPostalCode != null)
                {
                    searl += "&buyerPostalCode=" + itemFilters.Proximity.BuyerPostalCode;

                }


            }


            return searl;
        }

    }
}

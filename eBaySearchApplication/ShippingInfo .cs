using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindingAPI
{
    public partial class findItemsAdvancedResponse
    {
        [Serializable()]
        public class ShippingInfo
        {
            public bool ExpeditedShipping { get; set; }
            public int HandlingTime { get; set; }
            public bool OneDayShippingAvailable { get; set; }
            public eBayListingInfo.AmountType ShippingServiceCost { get; set; }

            public ShippingTypes ShippingType { get; set; }
            public List<string> ShipToLocations { get; set; }


            [Serializable()]
            public enum ShippingTypes
            {
                Calculated, 
                CalculatedDomesticFlatInternational ,
                Flat ,
                FlatDomesticCalculatedInternational ,
                Free ,
                FreePickup ,
                Freight ,
                FreightFlat ,
                NotSpecified ,


            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindingAPI
{
    partial class findItemsAdvancedResponse
    {
        [Serializable()]
        public class DiscountPriceInfo
        {
            public MapExposureType minimumAdvertisedPriceExposure { get; set; }
            public double originalRetailPrice { get; set; }
            public PriceTreatmentType pricingTreatment { get; set; }
            public bool soldOffEbay { get; set; }
            public bool soldOnEbay { get; set; }

            [Serializable()]
            public enum MapExposureType
            {
                DuringCheckout,
                PreCheckout
            }

            [Serializable()]
            public enum PriceTreatmentType
            {
                MAP,
                STP
            }

        }




    }
}

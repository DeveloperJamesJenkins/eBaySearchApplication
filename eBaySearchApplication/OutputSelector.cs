using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindingAPI
{
    public partial class findItemsAdvanced
    {
        /// <summary>
        /// Defines what data to return, in addition to the default set of data, in a response. 
        ////If you don't specify this field, eBay returns a default set of item fields. Use outputSelector to include more information in the response. The additional data is grouped into discrete nodes. You can specify multiple nodes by including this field multiple times, as needed, in the request. 
        ////If you specify this field, the additional fields returned can affect the call's response time (performance), including in the case with feedback data. 
        /// </summary>
        /// 
        [Serializable()]
        public enum OutputSelector
        {
            /// <summary>
            /// Include an AspectHistogram container with information about aspects from the domain that is most relevant to your search.
            /// MUST SET A CATEGORY ID FOR AspectHistogram!!!
            /// </summary>
            AspectHistogram,
            /// <summary>
            /// Include a CategoryHistogram container with information about categories that match your search.
            /// </summary>
            CategoryHistogram,
            /// <summary>
            ///  Include a ConditionHistogram container with the number of items found per condition (e.g., how many items are new). This value has no effect when Condition is specified as an item filter. Supported for all eBay sites except US eBay Motors, India (IN), Malaysia (MY) and Philippines (PH).
            /// </summary>
            ConditionHistogram,
            /// <summary>
            /// Include the GalleryInfoContainer, which contains URLs for three thumbnail images of the item in different sizes: large, medium, and small.
            /// </summary>
            GalleryInfo,
            /// <summary>
            ///  Include a URL to a picture of the item that is 400x400 pixels in size.
            /// </summary>
            PictureURLLarge,
            /// <summary>
            ///  Include a URL to a picture of the item that is 800x800 pixels in size.
            /// </summary>
            PictureURLSuperSize,
            /// <summary>
            ///  Include information about the seller in the response.
            /// </summary>
            SellerInfo,
            /// <summary>
            /// Include information about the seller's eBay store in the response.
            /// </summary>
            StoreInfo
        }


        private string GetOutputSelectors(List<OutputSelector> list)
        {
            string searl = "";
            int val = 0;

            if (list.Count > 0)
            {


                foreach (OutputSelector elt in list)
                {
                    searl += "&outputSelector(" + val.ToString() + ")=" + elt.ToString(); //

                    val++;

                    //aspectFilter.aspectName=Megapixels&   aspectFilter.aspectValueName=
                }

                val = 0; //reset after for each new itemFilter id

            }


            return searl;
        }
    }
}

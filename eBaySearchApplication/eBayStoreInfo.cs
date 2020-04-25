using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindingAPI
{
    public partial class findItemsAdvancedResponse
    {
        [Serializable()]
      public  class eBayStoreInfo
        {
          public string StoreName { get; set; }
          public string StoreURL { get; set; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindingAPI
{
    public partial class findItemsAdvancedResponse
    {
        [Serializable()]
        public class eBayAspect
        {
            public List<AspectValueHistogram> ValueHistograms { get; set; }
            public string Name { get; set; }

            [Serializable()]
            public class AspectValueHistogram
            {
                public string ValueName { get; set; }
                public long Count { get; set; }
            }
        }
    }
}

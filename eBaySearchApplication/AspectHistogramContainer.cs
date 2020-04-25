using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindingAPI
{
    public partial class findItemsAdvancedResponse
    {
        [Serializable()]
        public class AspectHistogramContainer
        {
            public List<eBayAspect> Aspects { get; set; }
            public string DomainDisplayName { get; set; }
            public string DomainName { get; set; }
                 
        }
    }
}

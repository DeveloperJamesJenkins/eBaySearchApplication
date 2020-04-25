using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindingAPI
{
    public partial class findItemsAdvancedResponse
    {
        [Serializable()]
        public class DistanceType
        {
            public string Unit { get; set; }
            public decimal Distance { get; set; }
        }
    }
}

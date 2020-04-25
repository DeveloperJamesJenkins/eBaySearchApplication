using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindingAPI
{
    public partial class findItemsAdvanced
    {
        [Serializable()]
        public class DomainFilterType
        {
            public string DomainName { get; set; }
        }
    }
}

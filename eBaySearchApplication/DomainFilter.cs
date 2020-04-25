using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindingAPI
{
    /// <summary>
    /// Specify the name of the domain to which you want to restrict search results. Only items listed within the specified domain will be returned in the search results. Domain names can be retrieved from an aspect histogram.
    /// </summary>
    /// 
    [Serializable()]
    public class DomainFilter
    {
        public string DomainName { get; set; }
    }
}

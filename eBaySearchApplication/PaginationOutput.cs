using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindingAPI
{
    public partial class findItemsAdvancedResponse
    {
        [Serializable()]
        public class PaginationOutput
        {
            public int PageNumber { get; set; }
            public int EntriesPerPage { get; set; }
            public int TotalPages { get; set; }
            public int TotalEntries { get; set; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindingAPI
{
    public partial class findItemsAdvanced
    {
        /// <summary>
        /// Controls the pagination of the result set. Child elements specify the maximum number of item listings to return per call and the page of data to return. Controls the number of listings returned in the response, but does not specify the details to return for each listing. 
        /// </summary>
        /// 
        [Serializable()]
        public class PaginationInput
        {
            public int EntriesPerPage { get; set; }
            public int PageNumber { get; set; }


            public PaginationInput()
            {
                this.EntriesPerPage = 100;
                this.PageNumber = 1;
            }
        }
    }
}

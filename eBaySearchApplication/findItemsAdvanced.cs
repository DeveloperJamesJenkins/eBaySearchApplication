using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace FindingAPI
{
    public partial class findItemsAdvanced
    {

        private readonly string FindingServiceURI = "http://svcs.ebay.com/services/search/FindingService/v1?";

        public eBayServiceCredentials Credentials{get; set;}
        public Affiliate Affiliate { get; set; }

        public DomainFilterType DomainFilter { get; set; }

        public bool DescriptionSearch { get; set; }

        public List<string> ExcludeKeywords { get; set; }

        /// <summary>
        /// Quick Keyword Search
        /// </summary>
        /// <param name="Query"></param>
        /// <param name="SortOrder"></param>
        /// <param name="Pagination"></param>
        public findItemsAdvancedResponse Search(string Query)
        {
            string  searl = FindingServiceURI;

            searl += getHeaders("findItemsAdvanced");

            searl += "keywords=" + Query.Replace(" ","%20");

            searl += GetExcludeKeywords();

            if (this.DescriptionSearch)
            {
                searl += "&descriptionSearch=true";

            }

            //now add each item filter...
            if(this.ItemFilterList != null)
                searl += GetFilters(this.ItemFilterList);

           
            if(this.AspectFilterTypes != null)
                searl += GetAspectFilters(this.AspectFilterTypes);

            if (this.OutputSelectors != null)
                searl += GetOutputSelectors(this.OutputSelectors);


            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(searl);

            if (!FindErrors(xdoc))
            {
                findItemsAdvancedResponse f = findItemsAdvancedResponse.ParseResponse(xdoc);
                return f;
            }

            return null;
  
        }


        private string GetExcludeKeywords()
        {
            string searl = "";

            if (this.ExcludeKeywords != null)
            {
                foreach (string s in this.ExcludeKeywords)
                    searl += "%20-" + s;
            }

            return searl;

        }

    
        /// <summary>
        /// Quick Keyword Search with Pagination & SortOrder
        /// </summary>
        /// <param name="Query"></param>
        /// <param name="SortOrder"></param>
        /// <param name="Pagination"></param>
        public findItemsAdvancedResponse Search(string Query, eBaySortOrder SortOrder, PaginationInput Pagination)
        {
            string searl = FindingServiceURI;

            searl += getHeaders("findItemsAdvanced");

            searl += "keywords=" + Query.Replace(" ", "%20"); ;

            searl += GetExcludeKeywords();

            if (this.DescriptionSearch)
            {
                searl += "&descriptionSearch=true";

            }

            searl += "&sortOrder=" + SortOrder.ToString();

            if (Pagination != null)
            {
                searl += "&paginationInput.entriesPerPage=" + Pagination.EntriesPerPage.ToString();
                searl += "&paginationInput.pageNumber= " + Pagination.PageNumber.ToString();
            }


            //now add each item filter...
            if (this.ItemFilterList != null)
                searl += GetFilters(this.ItemFilterList);

            if (this.AspectFilterTypes != null)
                searl += GetAspectFilters(this.AspectFilterTypes);

            if (this.OutputSelectors != null)
                searl += GetOutputSelectors(this.OutputSelectors);


                XmlDocument xdoc = new XmlDocument();


                try
                {
                    xdoc.Load(searl);
                }
                catch (eBayException ex)
                {
                    MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

            if (!FindErrors(xdoc))
            {
                findItemsAdvancedResponse f = findItemsAdvancedResponse.ParseResponse(xdoc);
                return f;
            }

            return null;

        }


        /// <summary>
        /// Search using Category
        /// </summary>
        /// <param name="Query"></param>
        /// <param name="CategoryID"></param>
        /// <param name="SortOrder"></param>
        /// <param name="Pagination"></param>
        public findItemsAdvancedResponse Search(string Query, int CategoryID)
        {
            string searl = FindingServiceURI;

            searl += getHeaders("findItemsAdvanced");

            searl += "keywords=" + Query.Replace(" ", "%20"); ;

            searl += GetExcludeKeywords();

            if (this.DescriptionSearch)
            {
                searl += "&descriptionSearch=true";

            }

            searl += "&categoryId=" + CategoryID.ToString();

            //now add each item filter...
            if (this.ItemFilterList != null)
                searl += GetFilters(this.ItemFilterList);

            if (this.AspectFilterTypes != null)
                searl += GetAspectFilters(this.AspectFilterTypes);

            if (this.OutputSelectors != null)
                searl += GetOutputSelectors(this.OutputSelectors);

         

            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(searl);

            if (!FindErrors(xdoc))
            {
                findItemsAdvancedResponse f = findItemsAdvancedResponse.ParseResponse(xdoc);
                return f;
            }


            return null;
        }



        /// <summary>
        /// Search using Category  SortOrder and Pagination
        /// </summary>
        /// <param name="Query"></param>
        /// <param name="CategoryID"></param>
        /// <param name="SortOrder"></param>
        /// <param name="Pagination"></param>
        public findItemsAdvancedResponse Search(string Query, int CategoryID, eBaySortOrder SortOrder, PaginationInput Pagination)
        {

            string searl = FindingServiceURI;

            searl += getHeaders("findItemsAdvanced");

            searl += "keywords=" + Query.Replace(" ", "%20");

            searl += GetExcludeKeywords();


            if (this.DescriptionSearch)
            {
                searl += "&descriptionSearch=true";

            }

            searl += "&categoryId=" + CategoryID.ToString();

            searl += "&sortOrder=" + SortOrder.ToString();

            if (Pagination != null)
            {
                searl += "&paginationInput.entriesPerPage=" + Pagination.EntriesPerPage.ToString();
                searl += "&paginationInput.pageNumber= " + Pagination.PageNumber.ToString();
            }

            //now add each item filter...
            if (this.ItemFilterList != null)
                searl += GetFilters(this.ItemFilterList);

            if (this.AspectFilterTypes != null)
                searl += GetAspectFilters(this.AspectFilterTypes);

            if (this.OutputSelectors != null)
                searl += GetOutputSelectors(this.OutputSelectors);

  

            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(searl);

            
            if (!FindErrors(xdoc))
            {
                findItemsAdvancedResponse f = findItemsAdvancedResponse.ParseResponse(xdoc);
                return f;
            }


            return null;
        }



        private bool FindErrors(XmlDocument xdoc)
        {
            try
            {
                XmlNode xAck = xdoc.GetElementsByTagName("ack")[0];  //xdoc.DocumentElement.ChildNodes[0];
                XmlNode xMessage = xdoc.GetElementsByTagName("message")[0];

                if (xAck.InnerText == "Failure")
                {


                    throw new eBayException(xMessage.InnerText);

                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new eBayException(ex.Message);
            }

        }



        private string getHeaders(string CallName)
        {
            string country = this.Credentials.xEBAY_SOA_GLOBAL_ID.ToString();
            string searl = "X-EBAY-SOA-GLOBAL-ID=EBAY-" + country; //X-EBAY-SOA-
            searl += "&OPERATION-NAME=" + CallName;
            searl += "&SERVICE-VERSION=" + this.Credentials.SERVICE_VERSION + "&";
            searl += "SECURITY-APPNAME=" + this.Credentials.SECURITY_APPNAME + "&";
            searl += "RESPONSE-DATA-FORMAT=XML&";
            searl += "REST-PAYLOAD&";

            if (this.Affiliate != null)
            {

                searl += "affiliate.networkId=" + (int)this.Affiliate.NetworkID + "&";
                searl += "affiliate.trackingId=" + this.Affiliate.TrackingId + "&";
                searl += "affiliate.customId=" + this.Affiliate.CustomID + "&";
            }
            return searl;
        }




      
    }
}

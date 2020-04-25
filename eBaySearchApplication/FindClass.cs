using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FindingAPI;
using System.Windows.Forms;
using eBaySearchApplication.Properties;
using System.IO;
using System.Web;

namespace eBaySearchApplication
{
    /// <summary>
    /// connects to ebay with search criteria
    /// </summary>
    public class FindClass
    {
        public findItemsAdvancedResponse Search(SearchType Search, eBayServiceCredentials.GlobalID GlobalId)
        {
            eBayServiceCredentials creds = new eBayServiceCredentials();
            creds.SECURITY_APPNAME = "Kimberle-7d94-45a7-a79d-344c094ee62b";
            creds.SERVICE_VERSION = "1.11.0";

            creds.xEBAY_SOA_GLOBAL_ID = GlobalId;// eBayServiceCredentials.GlobalID.GB;

            findItemsAdvanced fia = new findItemsAdvanced();
            fia.Affiliate = new Affiliate() { NetworkID= Affiliate.NetWorkID.eBayPartnerNetwork, TrackingId= "5338256679", CustomID="ESA" };

            fia.Credentials = creds;

            

            if(Search.DescriptionSearch)
                 fia.DescriptionSearch = Search.DescriptionSearch;

            fia.ItemFilterList = new findItemsAdvanced.ItemFilters();
            fia.ItemFilterList.LocatedInUsed = true;
            fia.ItemFilterList.LocatedIn = eBayServiceCredentials.GlobalID.GB;

            findItemsAdvanced.eBaySortOrder so = findItemsAdvanced.eBaySortOrder.StartTimeNewest;

            if (Search.UsePriceRange)
            {
                fia.ItemFilterList.MaxPrice = Search.MaxPrice;
                fia.ItemFilterList.MinPrice = Search.MinPrice;
            }


            if (Search.IncludeAuctionsWithoutBIN) { }
            else
            {
                fia.ItemFilterList.ListingTypes = new List<findItemsAdvanced.ItemFilters.eBayListingType>();
                fia.ItemFilterList.ListingTypes.Add(findItemsAdvanced.ItemFilters.eBayListingType.FixedPrice);
            }

            


            fia.ItemFilterList.HideDuplicateItems = true;

            if (Search.OnlyPaypal)
            {
                fia.ItemFilterList.PaymentMethods = new List<eBayPaymentMethod>();
                fia.ItemFilterList.PaymentMethods.Add(eBayPaymentMethod.PayPal);
            }


            //start exclude sellers
            if (Search.ExcludeSellers != null)
            {


                fia.ItemFilterList.ExcludeSellers = Search.ExcludeSellers;
                
            }

            //find out if this tab has an exclusions
            Tabs.Tab tabby = null;
            foreach (Tabs.Tab t in Tabs.TabList)
            {
                if (t.Name == Search.SearchTab.Name)
                {
                    tabby = t;
                }
            }

            
                   
                
            

            //end exclude sellers
              

            if (Search.ExcludeKeywords != null)
            {
                fia.ExcludeKeywords = Search.ExcludeKeywords;
            }

            if (tabby.ExcludeKeywords)
            {
                string excKeyowordssFile = Settings.Default.ExcludeKeywordsFile;
                if (File.Exists(excKeyowordssFile))
                {
                    if (File.Exists(excKeyowordssFile))
                    {
                        //load file and append to the excludesellers...
                        string exList = File.ReadAllText(excKeyowordssFile);
                        string[] words = exList.Split(new char[] { ',' });
                        foreach (string word in words)
                            fia.ExcludeKeywords.Add(word);
                    }

                }

            }



          
            
            if(Search.Conditions != null)
            {
                fia.ItemFilterList.ConditionTypes = new List<int>();
                foreach (int co in Search.Conditions)
                {
                    
                    fia.ItemFilterList.ConditionTypes.Add(co);
                }
            }

            if (Search.Proximity != null)
            {
                fia.ItemFilterList.Proximity = Search.Proximity;
            }


            findItemsAdvanced.PaginationInput pi = new findItemsAdvanced.PaginationInput();
            pi.EntriesPerPage = 25;
            pi.PageNumber = 1;


            findItemsAdvancedResponse fir;
            if (Search.Category != null)
            {
                fir = fia.Search(urlEncode(Search.Query), Search.Category.CategoryID, so, pi);
            }
            else
                fir = fia.Search(urlEncode(Search.Query), so, pi);

            //start to update the serch totalitems and bestprice etc...
          //  SetSearchValues(fir, Search);

            return fir;
        }


        private string urlEncode(string input)
        {
            string output = "";

            output = input.Replace(" ", "%20");
            output = output.Replace("!", "%21");
            output = output.Replace("\"", "%22");
            output = output.Replace("#", "%23");
            output = output.Replace("$", "%24");
            //output = output.Replace("%", "%25"); 
            output = output.Replace("&", "%26");
            output = output.Replace("'", "%27");
            output = output.Replace("(", "%28");
            output = output.Replace(")", "%29");
            output = output.Replace("*", "%2A");
            output = output.Replace("+", "%2B");
            //output = output.Replace(",", "%2C");
            //output = output.Replace("-", "%2D");
            //output = output.Replace("", "%2E");
            output = output.Replace("/", "%2F");

            return output;

        }
      
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FindingAPI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace eBaySearchApplication
{
    public class Search
    {
        public static List<SearchType> Searches { get; set; }


        public static void AddSearch(SearchType Search)
        {

            if (Searches == null)
                Searches = new List<SearchType>();

            Searches.Insert(0, Search);
           // SaveSearches(Application.StartupPath + @"\searches.bin");
        }

      

        public static List<SearchType> GetSearches()
        {
            return Searches;

        }


        public static void SaveSearches()
        {
            string FilePath = Application.StartupPath + @"\searches.bin";
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(FilePath, FileMode.Create);
            bf.Serialize(fs, Searches);
            fs.Close();

        }

        public static void LoadSearches()
        {
            string FilePath = Application.StartupPath + @"\searches.bin";
            if(File.Exists(FilePath))
            {

            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(FilePath, FileMode.Open);
            List<SearchType> searches = (List<SearchType>) bf.Deserialize(fs);
            Searches = searches;
            fs.Close();

          //  return Searches.Count;
            }

          //  return 0;

        }






        internal static void Remove(SearchType st)
        {
            SearchType sty = (SearchType)Search.GetSearches().Find((SearchType s) => s.SearchName.Equals(st.SearchName));

            if (sty != null)
            {
                Searches.Remove(sty);

               // SaveSearches(Application.StartupPath + @"\searches.bin");

                
            }
        }
    }


    [Serializable()]
    public class SearchType
    {
        public SearchType()
        {
            
        }

        public string SearchName { get; set; }

        public bool AutoCheck { get; set; }
        public Tabs.Tab SearchTab { get; set; }

        public List<int> Conditions { get; set; }

        //public double BestPrice { get; set; }
        //public int NewResults { get; set; }
       
        //deprecated
      //  public int TotalResults { get; set; }

        public string DisplayName{get; set;}

        public bool OnlyPaypal { get; set; }
        public bool PopupAlert { get; set; }
        public bool SoundAlert { get; set; }
        public bool EmailAlert { get; set; }

        public bool DescriptionSearch { get; set; }
        public bool IncludeAuctionsWithoutBIN { get; set; }

        public string Query { get; set; }
        public Categories.Category Category { get; set; }

        public bool UsePriceRange { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }


        public findItemsAdvanced.ItemFilters.ProximityType Proximity { get; set; }

     
     
        public List<string> ExcludeSellers { get; set; }
        public List<string> ExcludeKeywords { get; set; }


    }
}

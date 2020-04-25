using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FindingAPI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;
using eBaySearchApplication.Properties;

namespace eBaySearchApplication
{
    public class eBayItems
    {
        private static Dictionary<string, List<findItemsAdvancedResponse.eBayItem>> CurrentItems = new Dictionary<string,List<findItemsAdvancedResponse.eBayItem>>();

        //for displayOnly in listview
        private static Dictionary<string, int> NewItems = new Dictionary<string,int>();


        public static void DeleteSearches(SearchType ss)
        {
            if (CurrentItems.ContainsKey(ss.SearchName))
            {
                if (CurrentItems[ss.SearchName] != null)
                {
                    CurrentItems.Remove(ss.SearchName);
                }

            }
        }


        public static void SetAllAsViewed(SearchType ss)
        {
            if (CurrentItems.ContainsKey(ss.SearchName))
            {
                if (CurrentItems[ss.SearchName] != null)
                {
                    findItemsAdvancedResponse.eBayItem[] a = new findItemsAdvancedResponse.eBayItem[CurrentItems[ss.SearchName].Count];
                    CurrentItems[ss.SearchName].CopyTo(a);
                    foreach (findItemsAdvancedResponse.eBayItem eb in a)
                    {
                        findItemsAdvancedResponse.eBayItem b = eb;
                        b.Viewed = true;
                        CurrentItems[ss.SearchName].Remove(eb);
                        
                        CurrentItems[ss.SearchName].Add(b);
                    }
                }

            }

        }

        public static void SetAsViewed(SearchType ss, findItemsAdvancedResponse.eBayItem eBayItem)
        {
            if (eBayItem == null)
                return;

            if (CurrentItems.ContainsKey(ss.SearchName))
            {
                if (CurrentItems[ss.SearchName] != null)
                {

                    findItemsAdvancedResponse.eBayItem sty = (findItemsAdvancedResponse.eBayItem)CurrentItems[ss.SearchName].Find((findItemsAdvancedResponse.eBayItem ei) => ei.ItemId.Equals(eBayItem.ItemId));


                  

                    sty.Viewed = true;
                    CurrentItems[ss.SearchName].Remove(sty);
//
                    CurrentItems[ss.SearchName].Add(sty);


                    
                    
                }
                

            }


        }



        public static void ResetNewItems(SearchType ss)
        {
            if (NewItems == null)
                return;

            if (NewItems.ContainsKey(ss.SearchName))
            {
                NewItems[ss.SearchName] = 0;
            }

        }

        public static int GetListNewItemCount(SearchType ss)
        {
            

            if (NewItems == null)
                return 0;

            if (NewItems.ContainsKey(ss.SearchName))
            {
                
                return NewItems[ss.SearchName];
            }
            else
                return 0;

        }


        public static List<findItemsAdvancedResponse.eBayItem> GetItems(SearchType Search)
        {

            if (CurrentItems.ContainsKey(Search.SearchName))
            {
                if (CurrentItems[Search.SearchName] != null)
                {

                    CurrentItems[Search.SearchName].Reverse();
                    return CurrentItems[Search.SearchName] ;
                }
            }

            return null;

        }


        public static List<findItemsAdvancedResponse.eBayItem> GetUnViewed(SearchType Search)
        {

            if (CurrentItems.ContainsKey(Search.SearchName))
            {
                if (CurrentItems[Search.SearchName] != null)
                {
                    List<findItemsAdvancedResponse.eBayItem> viewedItems = CurrentItems[Search.SearchName].FindAll(NotViewed);
                    viewedItems.Reverse();

                    return viewedItems;
                }
            }

            return null;

        }


        private static bool NotViewed(findItemsAdvancedResponse.eBayItem item)
        {
           

            return !item.Viewed;

        }



        //viewed
        public static List<findItemsAdvancedResponse.eBayItem> GetViewed(SearchType Search)
        {

            if (CurrentItems.ContainsKey(Search.SearchName))
            {
                if (CurrentItems[Search.SearchName] != null)
                {
                    List<findItemsAdvancedResponse.eBayItem> viewedItems = CurrentItems[Search.SearchName].FindAll(Viewed);
                    viewedItems.Reverse();
                    return viewedItems;
                }
            }

            return null;

        }


        private static bool Viewed(findItemsAdvancedResponse.eBayItem item)
        {


            return item.Viewed;

        }

        public static double GetBestPrice(SearchType Search)
        {
            //find best preice from currentITems
            double lowest = 10000000000;

            if (!CurrentItems.ContainsKey(Search.SearchName))
                return lowest;


            if (CurrentItems[Search.SearchName] != null)
            {
                findItemsAdvancedResponse.eBayItem[] list = new findItemsAdvancedResponse.eBayItem[CurrentItems[Search.SearchName].Count];

                CurrentItems[Search.SearchName].CopyTo(list);

                if (list != null)
                {


                    foreach (findItemsAdvancedResponse.eBayItem item in list)
                    {
                        if (item.SellingStatus.CurrentPrice != null)
                        {
                            if (item.SellingStatus.CurrentPrice.Amount < lowest)
                                lowest = item.SellingStatus.CurrentPrice.Amount;

                        }
                        //if (item.ListingInfo.BuyItNowPrice != null)
                        //{
                        //    if (item.ListingInfo.BuyItNowPrice.Amount < lowest)
                        //        lowest = item.ListingInfo.BuyItNowPrice.Amount;
                        //}
                    }
                }

            }
            return lowest;



        }


        public static int GetNewItemCount(SearchType Search)
        {
            
            if (CurrentItems.ContainsKey(Search.SearchName))
            {
                if (CurrentItems[Search.SearchName] != null)
                {
                    List<findItemsAdvancedResponse.eBayItem> viewedItems = CurrentItems[Search.SearchName].FindAll(NotViewed);
                    return viewedItems.Count;
                }
                else
                    return 0;

            }

        

            return 0;

        }


        public static void SaveItems()
        {
                    //save to disc...
                     string FilePath = Application.StartupPath + @"\SearchItems.bin";

            
                    BinaryFormatter bf = new BinaryFormatter();
                    FileStream fs = new FileStream(FilePath, FileMode.Create);
                    bf.Serialize(fs, CurrentItems);
                    fs.Close();
            
        }

        public static void LoadItems()
        {
         

            string FilePath = Application.StartupPath + @"\SearchItems.bin";
            if (File.Exists(FilePath))
            {

                //get from disc...

                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream(FilePath, FileMode.Open);
                fs.Position = 0;
                Dictionary<string, List<findItemsAdvancedResponse.eBayItem>> items = (Dictionary<string, List<findItemsAdvancedResponse.eBayItem>>)bf.Deserialize(fs);
                fs.Close();

                 CurrentItems = items;
                
                
            }
           

        }


        public static int GetItemCount(SearchType ss)
        {
            int ret = 0;


            if (CurrentItems == null)
                return ret;

            if (!CurrentItems.ContainsKey(ss.SearchName))
                CurrentItems.Add(ss.SearchName, null);

            if (CurrentItems[ss.SearchName] != null)
            {
                ret = CurrentItems[ss.SearchName].Count;
            }

            return ret;
        }

        public static void AddItem(findItemsAdvancedResponse.eBayItem eBayItem, SearchType ss)
        {



            if (!CurrentItems.ContainsKey(ss.SearchName))
                CurrentItems.Add(ss.SearchName, null);

                if (CurrentItems[ss.SearchName] == null)
                {
                    CurrentItems[ss.SearchName] = new List<findItemsAdvancedResponse.eBayItem>();
                }

                //if (CurrentItems.Count > 0)
                //{


                    findItemsAdvancedResponse.eBayItem sty = (findItemsAdvancedResponse.eBayItem)CurrentItems[ss.SearchName].Find((findItemsAdvancedResponse.eBayItem ei) => ei.ItemId.Equals(eBayItem.ItemId));

                    if (sty == null)
                    {
                        CurrentItems[ss.SearchName].Add(eBayItem);
                        //Fire New Item event here
                        onNewItem(eBayItem, ss);
                    }
                    else
                    {
                        //TODO: COuld make this update here

                        //CurrentItems[ss.SearchName].Remove(sty);
                        //CurrentItems[ss.SearchName].Add(eBayItem);
                    }
                    



                //}
                //else
                //{
                //    CurrentItems[ss.SearchName].Add(eBayItem);

                //    //Fire New Item event here
                //    onNewItem(eBayItem);
                //}


            }

        //public delegate void d_NewItem(findItemsAdvancedResponse.eBayItem ei, SearchType ss);

        //public static event d_NewItem NewItem;

        private static void onNewItem(findItemsAdvancedResponse.eBayItem ei, SearchType ss)
        {
            //add to the NewItems for later

            if (NewItems == null)
                NewItems = new Dictionary<string, int>();

            if (!NewItems.ContainsKey(ss.SearchName))
                NewItems.Add(ss.SearchName, 0);


            NewItems[ss.SearchName]++;// = (NewItems[ss.SearchName]+1);
          

        }


        //removes all out of date items...
        public static void CleanItems()
        {

            //foreach search in search remove ones out of date
            
        }
    }
}

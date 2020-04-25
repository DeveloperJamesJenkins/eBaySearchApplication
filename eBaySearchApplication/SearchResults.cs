using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FindingAPI;
using eBaySearchApplication.Properties;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Diagnostics;

namespace eBaySearchApplication
{
    public partial class SearchResults : Form
    {
        private SearchType thisSearch;

        public SearchResults()
        {
            InitializeComponent();
            

        }


        public delegate void d_OnViewed(SearchType ss, findItemsAdvancedResponse.eBayItem eb);
        public event d_OnViewed ItemViewed;


        private void onViewed(SearchType ss, findItemsAdvancedResponse.eBayItem eb)
        {
            if (ItemViewed != null)
                ItemViewed(ss, eb);
        }

        

        public SearchResults(SearchType Search)
        {
            thisSearch = Search;

            InitializeComponent();

            //ParameterizedThreadStart pst = new ParameterizedThreadStart(LoadItems);
            //Thread t = new Thread(pst);
            //t.Start(Search);

            this.Show();
            Thread.SpinWait(10);


            GetUnViewed(Search);

            this.groupBox1.Text = Search.DisplayName;
        }

        private void GetItems(SearchType p)
        {
            this.dataGridView1.Rows.Clear();

             
            List<findItemsAdvancedResponse.eBayItem> lfi = eBayItems.GetItems(p);

            if (lfi == null)
                return;

            int row = 0;

            foreach (findItemsAdvancedResponse.eBayItem item in lfi)
            {

                Image thumb = null;

                row = this.dataGridView1.Rows.Add(new object[] { "" });


                double binPrice = 0;
                if (item.ListingInfo.BuyItNowPrice != null)
                    binPrice = item.ListingInfo.BuyItNowPrice.Amount;

                double shipCost = 0;
                if (item.ShippingInfo.ShippingServiceCost != null)
                    shipCost = item.ShippingInfo.ShippingServiceCost.Amount;

                //string currency = item.SellingStatus.CurrentPrice.CurrencyID;

                object[] args = new object[] { thumb, item.ItemId, item.Title,  item.SellingStatus.CurrentPrice.Amount, shipCost, (item.SellingStatus.CurrentPrice.Amount + shipCost), item.ListingInfo.EndTime.ToString() };


                this.dataGridView1.Rows[row].Tag = item;

                this.dataGridView1.Rows[row].SetValues(args);

                if (item.Viewed)
                {
                    this.dataGridView1.Rows[row].DefaultCellStyle.BackColor = Settings.Default.ViewedColour;
                }




                UriRow uri = new UriRow();
                uri.Row = row;
                uri.Uri = item.GalleryURL;

                ParameterizedThreadStart pst = new ParameterizedThreadStart(GetThumb);
                Thread t = new Thread(pst);
                t.Start(uri);



            }

        }

      

        /// <summary>
        /// loads the items to view from the searchitems
        /// </summary>
        /// <param name="p"></param>
        private void GetUnViewed(SearchType p)
        {
            this.dataGridView1.Rows.Clear();

            

            List<findItemsAdvancedResponse.eBayItem> lfi = eBayItems.GetUnViewed((SearchType)p);

            if (lfi == null)
                return;
            
            int row = 0;

            foreach (findItemsAdvancedResponse.eBayItem item in lfi)
            {

                Image thumb = null;

                row = this.dataGridView1.Rows.Add(new object[] { "" });


                double binPrice = 0;
                if (item.ListingInfo.BuyItNowPrice != null)
                    binPrice = item.ListingInfo.BuyItNowPrice.Amount;

                double shipCost = 0;
                if (item.ShippingInfo.ShippingServiceCost != null)
                    shipCost = item.ShippingInfo.ShippingServiceCost.Amount;

                //string currency = item.SellingStatus.CurrentPrice.CurrencyID;
                object[] args = new object[] { thumb, item.ItemId, item.Title,  item.SellingStatus.CurrentPrice.Amount, shipCost, (item.SellingStatus.CurrentPrice.Amount + shipCost), item.ListingInfo.EndTime.ToString() };


                this.dataGridView1.Rows[row].Tag = item;

                this.dataGridView1.Rows[row].SetValues(args);

                //  this.dataGridView1.Refresh();




                UriRow uri = new UriRow();
                uri.Row = row;
                uri.Uri = item.GalleryURL;

                ParameterizedThreadStart pst = new ParameterizedThreadStart(GetThumb);
                Thread t = new Thread(pst);
                t.Start(uri);



            }

        }


        private void GetViewed(SearchType p)
        {

            this.dataGridView1.Rows.Clear();

           
            List<findItemsAdvancedResponse.eBayItem> lfi = eBayItems.GetViewed((SearchType)p);

            if (lfi == null)
                return;

            int row = 0;

            foreach (findItemsAdvancedResponse.eBayItem item in lfi)
            {

                Image thumb = null;

                row = this.dataGridView1.Rows.Add(new object[] { "" });


                double binPrice = 0;
                if (item.ListingInfo.BuyItNowPrice != null)
                    binPrice = item.ListingInfo.BuyItNowPrice.Amount;

                double shipCost = 0;
                if (item.ShippingInfo.ShippingServiceCost != null)
                    shipCost = item.ShippingInfo.ShippingServiceCost.Amount;

             //   string currency = item.SellingStatus.CurrentPrice.CurrencyID;

                object[] args = new object[] { thumb, item.ItemId, item.Title, item.SellingStatus.CurrentPrice.Amount, shipCost,(item.SellingStatus.CurrentPrice.Amount + shipCost), item.ListingInfo.EndTime.ToString() };


                this.dataGridView1.Rows[row].Tag = item;

                this.dataGridView1.Rows[row].SetValues(args);

                //  this.dataGridView1.Refresh();




                UriRow uri = new UriRow();
                uri.Row = row;
                uri.Uri = item.GalleryURL;

                ParameterizedThreadStart pst = new ParameterizedThreadStart(GetThumb);
                Thread t = new Thread(pst);
                t.Start(uri);



            }




        }

       

        private void ResetSearch()
        {

        }

        

        private class UriRow
        {
            public string Uri{get; set;}
            public int Row { get; set; }
        }

        
        private void GetThumb(object UriRow)
        {
            //lock(this)
            //{
            Image img = Resources.end ;

            UriRow uri = (UriRow)UriRow;

            if ((Settings.Default.DownloadThumbs) & (uri.Uri != null))
            {
                //download

                //then invoke

                try
                {
                    WebClient wc = new WebClient();
                    byte[] imgBytes = wc.DownloadData(uri.Uri);

                    MemoryStream ms = new MemoryStream(imgBytes);
                    img = Image.FromStream(ms);
                    ms.Close();
                    

              
                    Invoke(new d_ThumbArrival(ThumbArrival), new object[] { img, uri.Row });


                }
                catch (Exception ex)
                {

                }

            }
            else
            {
                // img = Resources.end;
                //Invoke(new d_ThumbArrival(ThumbArrival), new object[] { img, uri.Row });
            }
                        


           // }
        }

        delegate void d_ThumbArrival(Image Thumb, int row);
        private void ThumbArrival(Image Thumb, int row)
        {
             try
              {
                    dataGridView1.Rows[row].SetValues(new object[] { Thumb });
                    dataGridView1.Rows[row].Height = 100;
              }
             catch (Exception ex)
             {

             }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                findItemsAdvancedResponse.eBayItem eb = (findItemsAdvancedResponse.eBayItem)dataGridView1.SelectedRows[0].Tag;
                

                Process.Start(eb.ViewItemURL);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MarkAllAsRead();
        }

        private void MarkAllAsRead()
        {
            //mark all items in this search as read...

            foreach (DataGridViewRow dvr in dataGridView1.Rows)
            {
                findItemsAdvancedResponse.eBayItem ei = (findItemsAdvancedResponse.eBayItem)dvr.Tag;
                if (ei != null)
                {
                    eBayItems.SetAsViewed(thisSearch, ei);
                    
                   
                }
            }


            eBayItems.SaveItems();


            onViewed(thisSearch, null);
            
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                findItemsAdvancedResponse.eBayItem eb = (findItemsAdvancedResponse.eBayItem)dataGridView1.SelectedRows[0].Tag;
                eBayItems.SetAsViewed(thisSearch, eb);
               
                //eBayItems.SaveItems();

                onViewed(thisSearch, eb);

               // Process.Start(eb.ViewItemURL);


            }

         

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            GetViewed(thisSearch);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GetItems(thisSearch);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GetUnViewed(thisSearch);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //remove all this searhces items from ebayItems.

            eBayItems.DeleteSearches(thisSearch);
            eBayItems.SaveItems();

            dataGridView1.Rows.Clear();
            onViewed(thisSearch, null);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                findItemsAdvancedResponse.eBayItem eb = (findItemsAdvancedResponse.eBayItem)dataGridView1.SelectedRows[0].Tag;

         

                Process.Start(eb.ViewItemURL);
            }
        }









    }
}

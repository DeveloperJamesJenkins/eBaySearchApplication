using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FindingAPI;
using System.Threading;
using eBaySearchApplication.Properties;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Net.Mail;
using Microsoft.Win32;
using static FindingAPI.eBayServiceCredentials;

namespace eBaySearchApplication
{
    public partial class Form1 : Form
    {

        private eBayServiceCredentials.GlobalID Country;// = eBayServiceCredentials.GlobalID.GB;

        public Form1()
        {
            InitializeComponent();

            SystemEvents.PowerModeChanged += new PowerModeChangedEventHandler(SystemEvents_PowerModeChanged);

            lock (this)
            {
                eBayItems.LoadItems();
                
                
            }

            LoadGlobalIds();

            Search.LoadSearches();

            timerAutoCheck.Interval = ((60000) * Settings.Default.IntervalMinutes);
        }

        private void LoadGlobalIds()
        {

            Country = (GlobalID) Enum.Parse(typeof(GlobalID), Settings.Default.GlobalID );

            foreach (string f in Enum.GetNames( typeof( eBayServiceCredentials.GlobalID ) ))
            {
                var item = tsmCountry.DropDownItems.Add(f);
                item.Tag = Enum.Parse(typeof(GlobalID), f);
                item.Click += Item_Click;

                if((GlobalID)Enum.Parse(typeof(GlobalID),f) == Country)
                {
                    ToolStripMenuItem tmi = (ToolStripMenuItem)item;
                    tmi.Checked = true;
                }
            }
        }

        private void Item_Click(object sender, EventArgs e)
        {

            foreach(ToolStripMenuItem mi in tsmCountry.DropDownItems)
            {
                mi.Checked = false;
            }

            ToolStripMenuItem tsi = (ToolStripMenuItem)sender;

            Country = (GlobalID)tsi.Tag;

            Settings.Default.GlobalID = Country.ToString();
            Settings.Default.Save();
            Settings.Default.Reload();

            tsi.Checked = true;
        }

        void SystemEvents_PowerModeChanged(object sender, PowerModeChangedEventArgs e)
        {
            if (isAutoed  == true)
            {
                if (e.Mode == PowerModes.Suspend)
                    timerAutoCheck.Enabled = false;
                else if (e.Mode == PowerModes.Resume)
                    timerAutoCheck.Enabled = true;
            }
        }

    

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTabs();

           
        }

        private void LoadSearches()
        {

            //clear searches first
             List<SearchType> searches =   Search.GetSearches();

             if (searches != null)
            {
                SearchType[] searchCopy = new SearchType[searches.Count];
                Search.GetSearches().CopyTo(searchCopy);

                System.Array.Reverse(searchCopy);
               // searchCopy.Reverse();

                foreach (SearchType s in searchCopy)
                {

                    searchAddedOrUpdated(s);

                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (Tabs.TabList != null)
            {
                if (Tabs.TabList.Count > 0)
                {
                    SearchForm sf;
                    //SearchType ss = (SearchType)toolStripButtonSearchSelected.Tag;
                    //if(ss != null)
                    //{
                        sf = new SearchForm();
                    //}
                    //else
                    //    sf = new SearchForm();
                    sf.SearchAdded += new SearchForm.d_SearchAdded(sf_SearchAdded);
                    sf.Show();
                }
                else
                {
                    MessageBox.Show("Please Create a Tab First in Settings", "Please Create a Tab First in Settings", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Please Create a Tab First in Settings", "Please Create a Tab First in Settings", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }


        delegate void d_SearchAdded(SearchType xSearch);
        void sf_SearchAdded(SearchType xSearch)
        {
            if (xSearch != null)
            {
              
                
                Invoke(new d_SearchAdded(searchAddedOrUpdated),new object[]{xSearch});
             
            }

        }

        private void AddToListView(ListView List, SearchType xSearch)
        {

           
                SearchType Search = xSearch;
                if (Search == null)
                    return;

                bool updated = false;
                SearchType st = null;
                int keyIndex = List.Items.IndexOfKey(Search.SearchName);
                ListViewItem li = null;


                //TODO Get Currency here

                double bestPrice = eBayItems.GetBestPrice(Search);
                if (bestPrice == 10000000000)
                    bestPrice = 0;

                if (keyIndex > -1)
                {
                    li = List.Items[keyIndex];

                 

                    st = (SearchType)li.Tag;
                    if (li.Name == Search.SearchName)
                    {
                        

                        li.Text = Search.DisplayName;
                        li.SubItems[1].Text = bestPrice.ToString();
                        li.SubItems[2].Text = eBayItems.GetNewItemCount(Search).ToString();



                        if (int.Parse(li.SubItems[2].Text) > 0)
                            li.ForeColor = Settings.Default.NewItemsColour;
                        else
                            li.ForeColor = Settings.Default.ViewedColour;

                        li.SubItems[3].Text = eBayItems.GetItemCount(Search).ToString();
                        li.Name = Search.SearchName;
                        li.Tag = Search;
                        updated = true;


                        

                    }
                }

                if (st == null)
                {

                }


                if (!updated)
                {
                    li = List.Items.Insert(0, Search.DisplayName);
                    li.Name = Search.SearchName;
                    
                    li.SubItems.Add(bestPrice.ToString());
                    li.SubItems.Add(eBayItems.GetNewItemCount(Search).ToString());


                    if (int.Parse(li.SubItems[2].Text) > 0)
                        li.ForeColor = Settings.Default.NewItemsColour;
                    else
                        li.ForeColor = Settings.Default.ViewedColour;

                    li.SubItems.Add(eBayItems.GetItemCount(Search).ToString());
                    li.Tag = Search;

                    

                }



            

           
        }

        delegate void d_ItemAdded(ListView AuctionList, SearchType xSearch);
        private void searchAddedOrUpdated(SearchType xSearch) //add parameters wit hthe search in it
        {
            SearchType Search = xSearch;
            if (Search == null)
                return;

            string    tabName = Search.SearchTab.Name.Replace(" ", "_");

            
            AuctionList au = null;
            foreach (TabPage tp in tabControlAuctions.TabPages)
            {
                
                if (("tab" + tabName) == tp.Name.Replace(" ", "_"))
                {

                     au = (AuctionList)tp.Controls[0];
                     Invoke(new d_ItemAdded(AddToListView),new object[]{au.listView, xSearch});


                     break;
                }

             

            }

         
        }
       

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //toolStripButtonEditSearch.Enabled = false;
            //toolStripButtonDeleteSearch.Enabled = false;
            EditSearch();
            
        }


        private SearchType EditingSearch;
        private void EditSearch()
        {
           //open search form prefilled with the
            //get selected item

            SearchType st = (SearchType)toolStripButtonEditSearch.Tag;
            EditingSearch = st;
            SearchForm sf = new SearchForm(st);
            sf.RemoveSearch += new SearchForm.d_RemoveSearch(sf_RemoveSearch);
            sf.SearchAdded+=new SearchForm.d_SearchAdded(sf_SearchAdded);
            sf.Show();
            

        }

        void sf_RemoveSearch(SearchType Search)
        {
          
            Invoke(new d_SearchAdded(RemoveOldUpdatedSearch), Search);

        }

        private void RemoveOldUpdatedSearch(SearchType Search)
        {
            //set by displayname the tag with the edited stype
            //get the auctionlist on the right tab and update the TAG
            foreach (TabPage tp in tabControlAuctions.TabPages)
            {


                if (tp.Name.Replace(" ", "_") == "tab" + Search.SearchTab.Name)
                {
                    //RemoveOwnedForm the search

                    AuctionList au = (AuctionList)tp.Controls[0];

                    //find the item in the list
                    foreach (ListViewItem lvi in au.listView.Items)
                    {
                        SearchType st = (SearchType)lvi.Tag;
                        if (st.SearchName == Search.SearchName) //st.DisplayName == UpdateSearch.DisplayName
                            au.listView.Items.Remove(lvi);
                    }
                }

            }
        }


        private void ShowSearchResults()
        {
            //test
            //SearchResults sr = new SearchResults();
            //sr.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            op.TabsUpdated += new Options.d_TabsUpdated(op_TabsUpdated);
            if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               
                timerAutoCheck.Interval = (int)(Settings.Default.IntervalMinutes * (60000));
               
                
            }
        }

        void op_TabsUpdated()
        {
            LoadTabs();

        }

        private void LoadTabs()
        {

            try
            {
                tabControlAuctions.TabPages.Clear();

                List<Tabs.Tab> tabs = Tabs.LoadTabList();



                if (tabs != null)
                {
                    foreach (Tabs.Tab tab in tabs)
                    {
                        //update the gui
                        string tabName = tab.Name.Replace(" ", "_");

                        if (tabControlAuctions.TabPages["tab" + tabName] == null)
                        {


                            tabControlAuctions.TabPages.Insert(tab.Index, "tab" + tabName);

                            tabControlAuctions.TabPages[tab.Index].Text = tab.DisplayName;

                            tabControlAuctions.TabPages[tab.Index].Name = "tab" + tabName;

                            AddSearchForm(tabControlAuctions.TabPages[tab.Index]);


                        }
                    }

                    if (tabControlAuctions.TabPages.Count > 0)
                        CurrentAuctionListTab = tabControlAuctions.TabPages[0].Name;

                }





                LoadSearches();

            }
            catch { }

        }

        private void AddSearchForm(TabPage tabPage)
        {
            AuctionList au = new AuctionList();
            au.listView.SelectedIndexChanged += new EventHandler(listView_SelectedIndexChanged);
            au.listView.MouseClick += new MouseEventHandler(listView_MouseClick);
            au.listView.DoubleClick += new EventHandler(au_DoubleClick);
            au.Name = "au" + tabPage.Name.Replace("tab","") ;
            au.Parent = tabPage;
            au.Dock = DockStyle.Fill;

            tabPage.Controls.Add(au);
        }

        void au_DoubleClick(object sender, EventArgs e)
        {
           // toolStripButtonSearchSelected.Enabled = false;
            ListView lv = (ListView)sender;
            if (lv.SelectedItems.Count > 0)
            {

                SearchResults sr = new SearchResults((SearchType)lv.SelectedItems[0].Tag);
                sr.ItemViewed += new SearchResults.d_OnViewed(itemViewed);
                sr.Show();
            }

        }

        void listView_MouseClick(object sender, MouseEventArgs e)
        {
            ListView lv = (ListView)sender;
            if (lv.SelectedIndices.Count < 1)
                return;

            toolStripButtonViewItems.Enabled = true;
            toolStripButtonSearchSelected.Enabled = true;
            toolStripButtonSearchSelected.Tag = lv.SelectedItems[0].Tag;

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStripItems.Show(Cursor.Position);
            }

          
        }

      
        /// <summary>
        /// auto searching
        /// </summary>
        /// <param name="Reponse"></param>
        /// <param name="SearchObj"></param>
        
        delegate void d_FindReturned(findItemsAdvancedResponse Reponse, SearchType SearchObj);
        private void SearchSingleReturnForm(object Result)
        {
            FindClass fc = new FindClass();
          
            SearchType ss = (SearchType)Result;

            findItemsAdvancedResponse fia = fc.Search(ss, Country);
           
           
            SaveSearches(fia.SearchResults, ss);


          

            try
            {

                Invoke(new d_FindReturned(FindReturned), new object[] { fia, ss });
            }
            catch { }

        }

        private void SaveSearches(List<findItemsAdvancedResponse.eBayItem> eBayItems, SearchType ss)
        {
          
            foreach (findItemsAdvancedResponse.eBayItem ei in eBayItems)
            {
             

                lock (this)
                {
                    eBaySearchApplication.eBayItems.AddItem(ei, ss);
                }

      
                
            }

            lock (this)
            {
                eBaySearchApplication.eBayItems.SaveItems();
            }



            int newCount = eBaySearchApplication.eBayItems.GetListNewItemCount(ss);

            if (newCount > 0)
            {
                string message = ss.DisplayName + " has " + newCount.ToString() + " new items";
                UpdateNews(message, ss);

                if (ss.PopupAlert)
                {
                   
                    notifyIcon1.ShowBalloonTip(3000, message, message, ToolTipIcon.Info);
                    
                }

                if (ss.SoundAlert)
                {

                    if (Settings.Default.SoundFile != "")
                    {
                        string file = Settings.Default.SoundFile;
                        if (File.Exists(file))
                        {


                            SoundPlayer sp = new SoundPlayer(file);
                            sp.Play();

                        }
                    }

                }

                if (ss.EmailAlert)
                {
                    if (Settings.Default.EmailAddress != "" & Settings.Default.SMTPServer != "")
                    {
                        SmtpClient smtp = new SmtpClient(Settings.Default.SMTPServer);
                        MailMessage mm = new MailMessage();
                        mm.Body = message;
                        mm.From = new MailAddress(Settings.Default.EmailAddress);
                        mm.To.Add(Settings.Default.EmailAddress);
                        mm.Sender = new MailAddress(Settings.Default.EmailAddress);
                        mm.Subject = ss.DisplayName + " has new items";
                        smtp.Send(mm);



                    }
                }
            }
            
        }

      

        private void FindReturned(findItemsAdvancedResponse Response, SearchType SearchObj)
        {
           

            StopTrayIconFlashing();

            ThreadStart ts = new ThreadStart(LoadSearches);
            Thread t = new Thread(ts);
            t.Start();

            
        }
        
        private void SearchCurrentItem(SearchType ss)
            {
              //start the searchresults and do the finditemsadvanced from there with the FindClass...

                StartTrayIconFlashing();

             //new thread...
              ParameterizedThreadStart pst = new ParameterizedThreadStart(SearchSingleReturnForm);
              
              Thread searchThread = new Thread(pst);
              searchThread.Start(ss);

            }

        delegate void d_NewsMessage(string Message, SearchType Search);
        private void UpdateNews(string Message, SearchType Search)
        {
            try
            {
                Invoke(new d_NewsMessage(AddToNews), new object[] { Message, Search });
            }
            catch { }

        }

        private void AddToNews(string Message, SearchType Search)
        {
            ListViewItem lvi = listViewNews.Items.Insert(0, DateTime.Now.ToString());
            lvi.Tag = Search;

            if (Message.IndexOf("new items") > 0)
            {
                //do flashing icon...
                lvi.SubItems.Add(Message);
                lvi.SubItems[0].ForeColor = Settings.Default.NewItemsColour;

              //  notifyIcon1.ShowBalloonTip(5000, "eBay Search Alert", Message, ToolTipIcon.Info);

                ThreadStart ts = new ThreadStart(StartFlash);
                Thread t = new Thread(ts);
                t.Start();

            }
            else
                lvi.SubItems.Add(Message);

        }

        void StartFlash()
        {
            for (int i = 0; i < 10; i++)
            {
                notifyIcon1.Icon = Resources.Untitled___7;
                Thread.Sleep(500);
                notifyIcon1.Icon = Resources.ebay;
            }
        }

        private void DeleteSearch(SearchType searchType)
        {
            toolStripButtonEditSearch.Enabled = false;
            toolStripButtonDeleteSearch.Enabled = false;

            Search.Remove(searchType);

            eBayItems.DeleteSearches(searchType);

            Search.SaveSearches();

            //remove the ebayItems from the search file.
          //  eBayItems.ResetNewItems(searchType);

            lastListViewed.Items.RemoveAt(selectedLastIndex);

            LoadSearches();
        }
       



        int selectedLastIndex;
        ListView lastListViewed;
        void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //toolStripButtonEditSearch.Enabled = false;
            //toolStripButtonDeleteSearch.Enabled = false;
            //toolStripButtonViewItems.Enabled = false;

            //toolStripButtonSearchSelected.Enabled = false;

            ListView lv = (ListView)sender;

            if (lv.SelectedIndices.Count > 0)
            {
                selectedLastIndex = lv.SelectedIndices[0];
                lastListViewed = lv;

                toolStripButtonEditSearch.Enabled = true;
                toolStripButtonEditSearch.Tag = lv.SelectedItems[0].Tag;

                toolStripButtonDeleteSearch.Enabled = true;
                toolStripButtonDeleteSearch.Tag = lv.SelectedItems[0].Tag;
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            tim.Enabled = false;
            
        }

        private void toolStripButtonDeleteSearch_Click(object sender, EventArgs e)
        {

            DeleteSearch((SearchType)toolStripButtonDeleteSearch.Tag);
        }


       
        private void toolStripButtonSearchSelected_Click(object sender, EventArgs e)
        {

            SearchType ss = (SearchType)toolStripButtonSearchSelected.Tag;
            SearchCurrentItem(ss);

            eBayItems.ResetNewItems(ss);

            UpdateNews("Seeking Items for " + ss.DisplayName,ss);

          
          
        }

        void itemViewed(SearchType ss, findItemsAdvancedResponse.eBayItem eb)
        {
            //DONT Search here - just update the searchtype in the au list...
            //TODO:::

            TabPage tp =  tabControlAuctions.TabPages[CurrentAuctionListTab];

            AuctionList au = (AuctionList)tp.Controls[0];

            AddToListView(au.listView, ss);

            //SearchCurrentItem( ss);
        }


        private void startSearchResults()
        {

           

        }
  

       
        System.Timers.Timer tim = new System.Timers.Timer();
       
        private void StartTrayIconFlashing()
        {


            try
            {
                tim.Elapsed += new System.Timers.ElapsedEventHandler(tim_Elapsed);

                notifyIcon1.Icon = Resources.ebay;
                tim.Interval = 1000;
                tim.Start();
            }catch
            {
            }

        }

        bool flashOn = false;
        void tim_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (flashOn)
            {
                notifyIcon1.Icon = Resources.ebay;
                flashOn = false;
            }
            else
            {
                notifyIcon1.Icon = Resources.Untitled___7;
                flashOn = true;
            }

        
        }

        private void StopTrayIconFlashing()
        {
           
            tim.Stop();
            notifyIcon1.Icon = Resources.Untitled___7;

        }

        private void timerAutoCheck_Tick(object sender, EventArgs e)
        {
            
            ThreadStart ts = new ThreadStart(StartAutoCheck);
            Thread t = new Thread(ts);
            t.Start();

            //StartAutoCheck();
        }


        /// <summary>
        /// starts the auto check
        /// </summary>
        private void StartAutoCheck()
        {
            if (Search.Searches != null)
            {
                SearchType[] ss = new SearchType[Search.Searches.Count];
                Search.Searches.CopyTo(ss);
                foreach (SearchType st in ss)
                {
                    eBayItems.ResetNewItems(st);
                    Thread.Sleep(500);

                    bool ExccheckAutoTab = false;
                    //see if this tab is doing auto check
                    foreach (Tabs.Tab t in Tabs.TabList)
                    {
                        if (t.Name == st.SearchTab.Name)
                            ExccheckAutoTab = t.ExcludeFromAutoSearch;
                    }


                    if (st.AutoCheck & (!ExccheckAutoTab))
                    {
                        SearchCurrentItem(st);

                        UpdateNews("Seeking Items for " + st.DisplayName,st);

                    }

                }
            }
        }

        bool isAutoed = false;
        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            timerAutoCheck.Enabled = !timerAutoCheck.Enabled;

            if (timerAutoCheck.Enabled)
            {
                toolStripButton2.Image = Resources.circle_red;

                ThreadStart ts = new ThreadStart(StartAutoCheck);
                Thread t = new Thread(ts);
                t.Start();
                isAutoed = true;

                
            }
            else
            {
                toolStripButton2.Image = Resources.circle_green;
                isAutoed = false;
                //timerAutoCheck.Enabled = false;

            }
        }

        string CurrentAuctionListTab;
        private void tabControlAuctions_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tc = (TabControl)sender;
            if (tc.TabPages.Count > 0)
            {
                CurrentAuctionListTab = tc.SelectedTab.Name; ;
            }
        }

        private void toolStripButtonSearchTab_Click(object sender, EventArgs e)
        {
            if (CurrentAuctionListTab != null)
            {
                ThreadStart ts = new ThreadStart(StartSearchTab);
                Thread t = new Thread(ts);
                t.Start();
                
            }
        }

        private void StartSearchTab()
        {
             
            if (Search.Searches != null)
            {
                SearchType[] ss = new SearchType[Search.Searches.Count];
                Search.Searches.CopyTo(ss);
                foreach (SearchType st in ss)
                {
                    Thread.Sleep(500);


                    if (("tab" + st.SearchTab.Name) == CurrentAuctionListTab)
                    {
                        eBayItems.ResetNewItems(st);
                        SearchCurrentItem(st);

                        UpdateNews("Seeking Items for " + st.DisplayName, st);

                    }
                  
                }
            
            }

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewNews.Items.Clear();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                string dir = folderBrowserDialog1.SelectedPath;

                //get file list
                File.Copy(Application.StartupPath + @"\searches.bin", dir + @"\searches.bin",true);
                File.Copy(Application.StartupPath + @"\tabs.bin", dir + @"\tabs.bin", true);
                File.Copy(Application.StartupPath + @"\SearchItems.bin", dir + @"\SearchItems.bin", true);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                string dir = folderBrowserDialog1.SelectedPath;

                //get file list
                
                
                File.Copy(dir + @"\searches.bin", Application.StartupPath + @"\searches.bin", true);
                File.Copy(dir + @"\tabs.bin", Application.StartupPath + @"\tabs.bin", true);
                File.Copy(dir + @"\SearchItems.bin", Application.StartupPath + @"\SearchItems.bin", true);

                Search.LoadSearches();
                eBayItems.LoadItems();
                LoadTabs();
               
                
                
            }
        }

        private void toolStripButtonViewItems_Click(object sender, EventArgs e)
        {

            //toolStripButtonViewItems.Enabled = false;
            TabPage tp = tabControlAuctions.TabPages[CurrentAuctionListTab];

            AuctionList au = (AuctionList)tp.Controls[0];

           ListView lv = au.listView;
            if (lv.SelectedItems.Count > 0)
            {

                SearchResults sr = new SearchResults((SearchType)lv.SelectedItems[0].Tag);
                sr.ItemViewed += new SearchResults.d_OnViewed(itemViewed);
                sr.Show();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //mark all as read..
              TabPage tp = tabControlAuctions.TabPages[CurrentAuctionListTab];

            AuctionList au = (AuctionList)tp.Controls[0];

           ListView lv = au.listView;
           if (lv.SelectedItems.Count > 0)
           {
               SearchType st = (SearchType)lv.SelectedItems[0].Tag;

               eBayItems.SetAllAsViewed(st);
               eBayItems.SaveItems();

               itemViewed(st, null);
           }
            
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
           // set country here


        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(this.Width.ToString() + " " + this.Height.ToString());

            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
            }
            else
                this.Visible = true;
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = true;
                this.WindowState = FormWindowState.Normal;
                
                this.BringToFront();
            }
        }

        private void deleteSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSearch((SearchType)toolStripButtonDeleteSearch.Tag);
        }

        private void listViewNews_DoubleClick(object sender, EventArgs e)
        {
            //load search results.
            ListView lv = (ListView)sender;
            if (lv.SelectedItems.Count > 0)
            {

                SearchResults sr = new SearchResults((SearchType)lv.SelectedItems[0].Tag);
                sr.ItemViewed += new SearchResults.d_OnViewed(itemViewed);
                sr.Show();
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchType ss = (SearchType)toolStripButtonSearchSelected.Tag;
            SearchCurrentItem(ss);

            eBayItems.ResetNewItems(ss);

            UpdateNews("Seeking Items for " + ss.DisplayName, ss);
        }

        private void websiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://james-jenkins.co.uk");
        }

        private void donateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=LD7U2LARNT5QS");
        }
    }
}

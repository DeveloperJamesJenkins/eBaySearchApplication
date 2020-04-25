using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FindingAPI;

namespace eBaySearchApplication
{
    public partial class SearchForm : Form
    {
        public SelectCategory sc = new SelectCategory();

        public delegate void d_SearchAdded(SearchType Search);
        public event d_SearchAdded SearchAdded;

        private bool EditMode = false;
        
        public SearchForm(SearchType Search)
        {
            InitializeComponent();

           
            EditMode = true;
            LoadTabs();
            LoadConditions(Search);
            SetSearchValues(Search);
           
        }

        private void LoadConditions(SearchType Search)
        {
            foreach (int name in Search.Conditions)
            {
                string[] objs = Enum.GetNames(typeof(findItemsAdvanced.ItemFilters.eBayConditionType));

                foreach (string obj in objs)
                {
                    findItemsAdvanced.ItemFilters.eBayConditionType result;
                    Enum.TryParse<findItemsAdvanced.ItemFilters.eBayConditionType>(obj, out result);

                    if (name == (int)result)
                    {
                        if (checkedListBoxConditions.Items.Contains(result))
                            return;
                        int index = checkedListBoxConditions.Items.Add(result);
                        checkedListBoxConditions.SetItemChecked(index, true);
                    }
                    else
                    {
                        if (checkedListBoxConditions.Items.Contains(result))
                            return;
                        checkedListBoxConditions.Items.Add(result);
                    }

                }
            }
        }



        public SearchForm()
        {
            InitializeComponent();
            LoadTabs();
            LoadConditions();
        }

        private void LoadConditions()
        {

            Array names = Enum.GetValues(typeof(findItemsAdvanced.ItemFilters.eBayConditionType));

            

            foreach (findItemsAdvanced.ItemFilters.eBayConditionType name in names)
            {
               
                    int index = checkedListBoxConditions.Items.Add(name);

                    if (name == findItemsAdvanced.ItemFilters.eBayConditionType.New | name == findItemsAdvanced.ItemFilters.eBayConditionType.New_Other | name == findItemsAdvanced.ItemFilters.eBayConditionType.Manufacturer_Refurbished | name == findItemsAdvanced.ItemFilters.eBayConditionType.Seller_Refurbished | name == findItemsAdvanced.ItemFilters.eBayConditionType.Used)
                    checkedListBoxConditions.SetItemChecked(index, true);
              
            }

           
        }


        private SearchType currentSearchType;
        private void SetSearchValues(SearchType Search)
        {

            this.Tag = Search;
            currentSearchType = Search;

            textBoxDisplayName.Text = Search.DisplayName;
         
            //textBoxDisplayName.Enabled = false;

            this.Text = "Editing Search: " + Search.DisplayName;

            if (Search.Category != null)
            {
                textBoxCategory.Tag = Search.Category;
                textBoxCategory.Text = Search.Category.CategoryName + "(" + Search.Category.CategoryID.ToString() + ")";
            }

            textBoxQuery.Text = Search.Query;

            Tabs.Tab tab = Search.SearchTab;
            comboTabs.Text = tab.Name;
            comboTabs.Tag = tab;

            for (int o = 0; o < comboTabs.Items.Count; o++)
            {
                if (comboTabs.Items[o].ToString() == tab.Name.Replace("_"," "))
                    comboTabs.SelectedIndex = o;

            }
            //tab.ExcludeKeywords

            checkBoxUsePrices.Checked = Search.UsePriceRange;
            moneyBoxLower.Text = Search.MinPrice.ToString();
            moneyBoxUpper.Text = Search.MaxPrice.ToString();

            checkBoxDescriptionSearch.Checked = Search.DescriptionSearch;
            checkBoxWithBINs.Checked = Search.IncludeAuctionsWithoutBIN;
            checkBoxPaypal.Checked = Search.OnlyPaypal;


            checkedListBoxNotifications.SetItemChecked(0, Search.PopupAlert);
            checkedListBoxNotifications.SetItemChecked(1, Search.SoundAlert);
            checkedListBoxNotifications.SetItemChecked(2, Search.EmailAlert);

            if (Search.ExcludeKeywords != null)
                listBoxExcludeKeywords.Items.AddRange(Search.ExcludeKeywords.ToArray());


            if (Search.ExcludeSellers != null)
                listBoxSellers.Items.AddRange(Search.ExcludeSellers.ToArray());


            checkBoxAutoSearch.Checked = Search.AutoCheck;

            ShowConditions(Search);
                

        }
       

        private void LoadTabs()
        {
            List<Tabs.Tab> tabs = Tabs.LoadTabList();

            foreach (Tabs.Tab tab in tabs)
            {
                comboTabs.Items.Add(tab);
            }

            comboTabs.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public delegate void d_RemoveSearch(SearchType Search);
        public event d_RemoveSearch RemoveSearch;

        private void onSearchUpdated(SearchType Search)
        {
            if (RemoveSearch != null)
                RemoveSearch(Search);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //fire event for new search added

            if (textBoxDisplayName.Text.Trim() == "" | textBoxQuery.Text.Trim() == "")
            {
                MessageBox.Show("Enter a Display Name and keywords", "Enter a Display Name and keywords", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }


                SearchType st = GetSearch();


                if (IsEdit(st))
                {
                    SearchType editedSearch = ((SearchType)this.Tag);
                    st.SearchName = editedSearch.SearchName;
                   // st.BestPrice = editedSearch.BestPrice;
                    
                    //find the objcet and remove
                    // SearchType removeSearch = (SearchType)Search.Searches.Find((SearchType s) => s.DisplayName.Equals(st.DisplayName));

                    Search.Searches.Remove(currentSearchType);

                    onSearchUpdated(currentSearchType);

                    //Event to tell gui to remove this Search.
                }
                else
                {
                    st.SearchName = textBoxDisplayName.Text.Trim().Replace(" ", "_");
                }


                Search.AddSearch(st);

                Search.SaveSearches();

                onSearchAdded(st);
                

                this.Close();
            //}


            
            
        }

        private void ShowConditions(SearchType Search)
        {
            for (int i = 0; i < checkedListBoxConditions.Items.Count; i++)
            {
                checkedListBoxConditions.SetItemChecked(i, false);
            }

            if( Search.Conditions != null)
            {
                foreach (findItemsAdvanced.ItemFilters.eBayConditionType st in Search.Conditions)
                {

                    //find the items in the checkedbox
                    int i = checkedListBoxConditions.FindString(st.ToString());

                    if (i > -1)
                        checkedListBoxConditions.SetItemChecked(i, true);


                }
            }
         

        }

        private bool IsEdit(SearchType ss)
        {
            //if we have this search already then it is an update edit
            //chec k wiht linq and remove then add back if found....

            List<SearchType> res = Search.GetSearches();
            if (res != null)
            {
               // SearchType st = (SearchType)res.Find((SearchType s) => s.DisplayName.Equals(ss.DisplayName));

                if (currentSearchType != null)
                {
                    //remove old search and then add it again
                    return true;
                }
            }

            return false;
        }

        private bool CheckSearch()
        {
            
            //check the search is workable
            
            // string SeenID = seenItemIds.Find((string a) => a.Equals(Item.ItemId));
            List<SearchType> searches = Search.GetSearches();
            SearchType st;
            if (searches != null)
            {

                //find display name already
                 st = (SearchType)searches.Find((SearchType s) => s.DisplayName.Equals(textBoxDisplayName.Text.Trim()));
                 if (st != null)
                 {
                     MessageBox.Show("You Already Have this DisplayName in Use. Please Change it", "You Already Have this DisplayName in Use. Please Change it", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                     return false;
                 }
            }
            



            return true;

        }


        private void onSearchAdded(SearchType Search)
        {
            if (SearchAdded != null)
                SearchAdded(Search);
        }

        private SearchType GetSearch()
        {
            //save search to disc or send back>???    

            SearchType ss = new SearchType();

           

            if(textBoxCategory.Tag != null)
                ss.Category = ((Categories.Category)textBoxCategory.Tag);

            if (checkBoxUsePrices.Checked)
            {
                ss.UsePriceRange = true ;

                decimal iop;
                if (decimal.TryParse(moneyBoxLower.Text.Trim(), out iop))
                {
                    ss.MinPrice = iop;
                }


                if (decimal.TryParse(moneyBoxUpper.Text.Trim(), out iop))
                {
                    ss.MaxPrice = iop;
                }


            }

            ss.Query = textBoxQuery.Text.Trim();
            ss.SearchTab = new Tabs.Tab();

            //if (!EditMode)
            //{
                //not right - get tag with the current tag of the TAB
                Tabs.Tab  t = (Tabs.Tab)comboTabs.SelectedItem;
                ss.SearchTab.Name = t.Name.Replace(" ", "_"); //check
            //}
            //else
            //{
            //    //ues the original name
            //    ss.SearchTab.Name = currentSearchType.SearchTab.Name;
            //}

            //if in use then dont change...
                ss.SearchTab.DisplayName = t.DisplayName;


            ss.SearchTab.Index = comboTabs.SelectedIndex;


            ss.DisplayName = textBoxDisplayName.Text;

            ss.DescriptionSearch = checkBoxDescriptionSearch.Checked;
            ss.EmailAlert = checkedListBoxNotifications.GetItemChecked(2);
            ss.IncludeAuctionsWithoutBIN = checkBoxWithBINs.Checked;
            ss.OnlyPaypal = checkBoxPaypal.Checked;
            ss.PopupAlert = checkedListBoxNotifications.GetItemChecked(0);
            ss.SoundAlert = checkedListBoxNotifications.GetItemChecked(1);


       


            if (listBoxSellers.Items.Count > 0)
            {
                ss.ExcludeSellers = new List<string>();
                foreach (string sob in listBoxSellers.Items)
                {
                    ss.ExcludeSellers.Add(sob);
                }
            }


            if (listBoxExcludeKeywords.Items.Count > 0)
            {
                ss.ExcludeKeywords = new List<string>();
                foreach (string sob in listBoxExcludeKeywords.Items)
                {
                    ss.ExcludeKeywords.Add(sob);
                }
            }

            ss.AutoCheck = checkBoxAutoSearch.Checked;

            if (checkedListBoxConditions.CheckedItems.Count > 0)
            {
                ss.Conditions = new List<int>();
                foreach (object o in checkedListBoxConditions.CheckedItems)
                {

                    int  co = (int) Enum.Parse(typeof(findItemsAdvanced.ItemFilters.eBayConditionType), o.ToString());


                   // findItemsAdvancedResponse.Condition con = (findItemsAdvancedResponse.Condition)o;
                    ss.Conditions.Add(co);
                }
            }


            if (txtPostCode.Text.Trim() != "")
            {
                ss.Proximity = new findItemsAdvanced.ItemFilters.ProximityType();
                ss.Proximity.BuyerPostalCode = txtPostCode.Text.Trim();
                ss.Proximity.MaxDistance = (int)numMaxDistance.Value;
            }



            return ss;
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (sc.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (sc.SelectedCategory == null)
                {
                    textBoxCategory.Text = "Select Category";
                    Categories.Category c = new Categories.Category();
                    c.CategoryID = 1;
                    textBoxCategory.Tag = c;
                }
                else
                {

                    textBoxCategory.Text = sc.SelectedCategory.CategoryName + "(" + sc.SelectedCategory.CategoryID.ToString() + ")";
                    textBoxCategory.Tag = sc.SelectedCategory;
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxSeller.Text.Trim() != "")
                listBoxSellers.Items.Add(textBoxSeller.Text.Trim());

            textBoxSeller.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBoxSeller.Text.Trim() != "")
                listBoxSellers.Items.Add(textBoxSeller.Text.Trim());

            textBoxSeller.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBoxExcludeKeywords.Text.Trim() != "")
                listBoxExcludeKeywords.Items.Add(textBoxExcludeKeywords.Text.Trim());

            textBoxExcludeKeywords.Text = "";
        }

        private void listBoxSellers_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDeleteSeller.Visible = true;
            buttonDeleteSeller.BringToFront();

            button4.Visible = false;

        }

        private void textBoxSeller_TextChanged(object sender, EventArgs e)
        {
            buttonDeleteSeller.Visible = false;

            button4.Visible = true;
            button4.BringToFront();
        }

        private void buttonDeleteSeller_Click(object sender, EventArgs e)
        {
            if(listBoxSellers.SelectedIndex > -1)
                listBoxSellers.Items.RemoveAt(listBoxSellers.SelectedIndex);

            buttonDeleteSeller.Visible = false;

            button4.Visible = true;
            button4.BringToFront();
        }

        private void listBoxSellers_Click(object sender, EventArgs e)
        {
            buttonDeleteSeller.Visible = true;
            buttonDeleteSeller.BringToFront();

            button4.Visible = false;
        }

        private void listBoxExcludeKeywords_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDeleteKeyword.Visible = true;
            buttonDeleteKeyword.BringToFront();

            button6.Visible = false;
        }

        private void listBoxExcludeKeywords_Click(object sender, EventArgs e)
        {
            buttonDeleteKeyword.Visible = true;
            buttonDeleteKeyword.BringToFront();

            button6.Visible = false;
        }

        private void buttonDeleteKeyword_Click(object sender, EventArgs e)
        {
            if (listBoxExcludeKeywords.SelectedIndex > -1)
                listBoxExcludeKeywords.Items.RemoveAt(listBoxExcludeKeywords.SelectedIndex);

            buttonDeleteKeyword.Visible = false;

            button6.Visible = true;
            button6.BringToFront();
        }

        private void checkBoxWithBINs_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxCategory_TextChanged(object sender, EventArgs e)
        {
            int result;
            if(int.TryParse(textBoxCategory.Text.Trim(), out result))
            {
                Categories.Category c = new Categories.Category();
                c.CategoryID = result;
                textBoxCategory.Tag = c;
            }
        }
    }
}

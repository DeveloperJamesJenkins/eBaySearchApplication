using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using eBaySearchApplication.Properties;
using FindingAPI;
using static FindingAPI.eBayServiceCredentials;

namespace eBaySearchApplication
{
    public partial class SelectCategory : Form
    {

        public Categories.Category SelectedCategory = null;

        public SelectCategory()
        {
            InitializeComponent();

           
        }

        private void SelectCategory_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            LoadCategories(-1);

            
        }

        private void LoadCategories(int index)
        {
            FindingAPI.Categories cats = new FindingAPI.Categories();
            cats.CategoryList += new Categories.d_CategoryList(cats_CategoryList);

            eBayServiceCredentials creds = eBayServiceCredentials.CreateCredentials("Kimberle-7d94-45a7-a79d-344c094ee62b");
            creds.SERVICE_VERSION = "1.11.0";

            //creds.xEBAY_SOA_GLOBAL_ID = GlobalId;// eBayServiceCredentials.GlobalID.GB;

            //findItemsAdvanced fia = new findItemsAdvanced();
            //fia.Affiliate = new Affiliate() { NetworkID = Affiliate.NetWorkID.eBayPartnerNetwork, TrackingId = "5338256679", CustomID = "ESA" };

          //  fia.Credentials = creds;


            cats.GetCategoryList(index, (GlobalID)Enum.Parse(typeof(GlobalID), Settings.Default.GlobalID), creds);


           

        }

        private delegate void d_ShowCatList(object[] Params);
        void cats_CategoryList(List<FindingAPI.Categories.Category> Categories)
        {

            Invoke(new d_ShowCatList(ShowCatList), new object[]{Categories.ToArray()});

          
        }


        private void ShowCatList(object[] Params)
        {

           

            Categories.Category[] Categories = (Categories.Category[] ) Params;

            if (treeView1.Nodes.Count == 0)
            {
                TreeNode top = treeView1.Nodes.Add("Select Category");
                FindingAPI.Categories.Category cat = new Categories.Category();
                cat.CategoryID = -1;
                cat.CategoryName = "Top Level";
            }

            if (treeView1.SelectedNode == null)
                treeView1.SelectedNode = treeView1.Nodes[0];

            if (Categories != null)
            {
                treeView1.SelectedNode.Nodes.Clear();

                foreach (Categories.Category cat in Categories)
                {

                    TreeNode newNode = treeView1.SelectedNode.Nodes.Add(cat.CategoryID.ToString(), cat.CategoryName);
                    newNode.Tag = cat;
                }

            }


            treeView1.SelectedNode.Expand();
        }



        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Categories.Category cat = (Categories.Category)e.Node.Tag;


            if (cat != null)
            {
                SelectedCategory = cat;
                label1.Text = cat.CategoryName + "(" + cat.CategoryID.ToString() + ")";
                LoadCategories(cat.CategoryID);
            }


            e.Node.Expand();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

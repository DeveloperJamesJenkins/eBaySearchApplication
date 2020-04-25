using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eBaySearchApplication
{
    public partial class AuctionList : UserControl
    {
        public AuctionList()
        {
            InitializeComponent();

            LayoutList();
        }

        

        public ListView listView
        {
            get
            {
                return this.listView1;
            }
        }

        private void LayoutList()
        {

            chBestPrice.Width = 75;
            chNewResults.Width = 75;
            chTotalResults.Width = 75;

            chSearches.Width = (listView1.Width - 230);

            
        }

        private void listView1_Resize(object sender, EventArgs e)
        {
            LayoutList();
        }
    }
}

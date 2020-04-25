using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eBaySearchApplication
{
    public partial class TabForm : Form
    {
        public TabForm()
        {
            InitializeComponent();
        }


        public TabForm(Tabs.Tab Tab)
        {
            InitializeComponent();
        }


        public string DisplayName
        {
            get
            {
                return textBox1.Text.Trim();
            }
            set
            {
                textBox1.Text = value;
            }
        }


        public bool UseExcludeSellerList
        {
            get
            {
                return checkBoxUseSellers.Checked;
            }
            set
            {
                checkBoxUseSellers.Checked = value;
            }
        }


        public bool UseExcludeKeywordList
        {
            get
            {
                return checkBoxExcludeKeywords.Checked;
            }
            set
            {
                checkBoxExcludeKeywords.Checked = value;
            }
        }

        public bool ExcludeFromAutoSearch
        {
            get
            {
                return checkBoxExcludeAutoSearch.Checked;
            }
            set
            {
                checkBoxExcludeAutoSearch.Checked = value;
            }
        }
    }
}

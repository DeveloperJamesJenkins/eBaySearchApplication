using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using eBaySearchApplication.Properties;
using System.IO;
using Microsoft.Win32;

namespace eBaySearchApplication
{
    public partial class Options : Form
    {
        public delegate void d_TabsUpdated();
        public event d_TabsUpdated TabsUpdated;


        public Options()
        {
            InitializeComponent();

            LoadTabs();
            LoadSounds();
            LoadEmail();
            LoadInterval();

            LoadGeneralSettings();

            LoadViewedColours();

            LoadExclusions();

            textBoxSMTP.Text = Settings.Default.SMTPServer;

        }

        private void LoadExclusions()
        {
            textBoxExcludeSeller.Text = Settings.Default.ExcludeSellersFile;
            textBoxExcludeKeywords.Text = Settings.Default.ExcludeKeywordsFile;
        }

        private void LoadViewedColours()
        {
            buttonNewColour.BackColor = Settings.Default.NewItemsColour;
            buttonViewedColour.BackColor = Settings.Default.ViewedColour;
        }

     

      

        private void LoadEmail()
        {
            textBoxEmail.Text = Settings.Default.EmailAddress;
           
        }

        private void LoadSounds()
        {
           
            ShowSoundLocation();
            
        }

        private void LoadTabs()
        {
           // Tabs tabs = new Tabs();
            List<Tabs.Tab> tabList = Tabs.LoadTabList();

            listBox1.Items.Clear();
            if (tabList != null)
            {
                foreach (Tabs.Tab tab in tabList)
                {
                    listBox1.Items.Add(tab);

                }
            }


        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Name)
            {
                case "NodeGeneral":

                    panelGeneral.Location = new Point(166, 13);
                    panelGeneral.BringToFront();

                    break;

                case "NodeNotifications":

                     panelNotifications.Location = new Point(166, 13);
                     panelNotifications.BringToFront();


                    break;

                case "NodeTabs":

                     panelTabs.Location = new Point(166, 13);
                     panelTabs.BringToFront();

                    break;

                case "NodeIntervals":

                    panelIntervals.Location = new Point(166, 13);
                    panelIntervals.BringToFront();

                    break;


                case "NodeResults":

                    panelResults.Location = new Point(166, 13);
                    panelResults.BringToFront();

                    break;


                case "NodeExclusions":

                    panelExclusions.Location = new Point(166, 13);
                    panelExclusions.BringToFront();

                    break;


            }
        }

        private void Options_Load(object sender, EventArgs e)
        {
            SetGUI();
        }

        private void SetGUI()
        {
            this.Size = new Size(452, 349);

            //tab groups at 166, 13
        }

        private void button1_Click(object sender, EventArgs e)
        {

            TabForm tf = new TabForm();

            if (tf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (tf.DisplayName == "")
                {
                    MessageBox.Show("Please Enter a Display Name", "Please Enter a Display Name", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                Tabs.Tab t = new Tabs.Tab();
                t.DisplayName = tf.DisplayName;
                t.ExcludeFromAutoSearch = tf.ExcludeFromAutoSearch;
                t.ExcludeKeywords = tf.UseExcludeKeywordList;
                t.ExcludeSellers = tf.UseExcludeSellerList;
                t.Index = listBox1.Items.Count;
                t.Name = tf.DisplayName.Replace(" ", "_");

                Tabs.TabList.Add(t);

                listBox1.Items.Add(t);
            }


        

            Tabs.SaveTabs();

            onTabsUpdated();
        }

        private void onTabsUpdated()
        {
            if (this.TabsUpdated != null)
                TabsUpdated();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            SaveGeneralSettings();
            
            this.Close();
        }

        private void SaveGeneralSettings()
        {
            Settings.Default.RunAtStartup = checkedListBox1.GetItemChecked(0);
            Settings.Default.DownloadThumbs = checkedListBox1.GetItemChecked(1);
            //Settings.Default.IconFlashOnNew = checkedListBox1.GetItemChecked(2);
            //Settings.Default.PulseOnSearch = checkedListBox1.GetItemChecked(3);


            Settings.Default.Save();
            Settings.Default.Reload();


            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (Settings.Default.RunAtStartup)
            {
            
                rkApp.SetValue("eBaySearchApplication", Application.ExecutablePath.ToString());


            }
            else
            {
                rkApp.DeleteValue("eBaySearchApplication", false);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                Tabs.TabList.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);


                for (int i = 0; i < Tabs.TabList.Count;i++ )
                {
                    Tabs.TabList[i].Index = i;
                }



                Tabs.SaveTabs();
                
                onTabsUpdated();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            MoveUp();

        }

        private void MoveUp()
        {
            //mov up
            int curent = listBox1.SelectedIndex;
            if (curent > 0)
            {
                Tabs.Tab curentab = Tabs.TabList[curent];
                Tabs.Tab lasttab = Tabs.TabList[curent - 1];

                Tabs.TabList.RemoveAt(curent);
                Tabs.TabList.RemoveAt(curent-1);

                curentab.Index = curentab.Index - 1;
                lasttab.Index = lasttab.Index + 1;


                Tabs.TabList.Insert(curent - 1, curentab);
                Tabs.TabList.Insert(curent, lasttab);

                listBox1.Items.RemoveAt(curent);
                listBox1.Items.RemoveAt(curent - 1);

                listBox1.Items.Insert(curent - 1, curentab);
                listBox1.Items.Insert(curent, lasttab);

            }

            //for (int it = 0; it < Tabs.TabList.Count; it++)
            //{
            //    Tabs.TabList[it].Index = it;
            //}
         

            Tabs.SaveTabs();

            onTabsUpdated();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MoveDown();
        }

        private void MoveDown()
        {
            if (listBox1.SelectedIndex < 0)
                return;

            int curent = listBox1.SelectedIndex;
            if (curent < (listBox1.Items.Count-1))
            {
                Tabs.Tab curentab = Tabs.TabList[curent];
                Tabs.Tab lasttab = Tabs.TabList[curent + 1];

                Tabs.TabList.RemoveAt(curent);
                Tabs.TabList.RemoveAt(curent);

                curentab.Index = curentab.Index + 1;
                lasttab.Index = lasttab.Index - 1;

                Tabs.TabList.Insert(curent,lasttab);
                Tabs.TabList.Insert(curent + 1, curentab);

               
                listBox1.Items.RemoveAt(curent);
                listBox1.Items.RemoveAt(curent);
                
                listBox1.Items.Insert (lasttab.Index,  lasttab);
                listBox1.Items.Insert(curentab.Index, curentab);
                

            }

            for (int it = 0; it < Tabs.TabList.Count; it++)
            {
                Tabs.TabList[it].Index = it;
            }


            Tabs.SaveTabs();

            onTabsUpdated();
        }

        private void buttonSelectSound_Click(object sender, EventArgs e)
        {
            LoadNewSound();
        }

        private void LoadNewSound()
        {
            openFileDialog1.Filter = "Wav files (*.wav)|*.wav";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (openFileDialog1.FileName != "")
                {


                    Settings.Default.SoundFile = openFileDialog1.FileName;
                    Settings.Default.Save();
                    Settings.Default.Reload();

                    ShowSoundLocation();
                    
                }

            }
        }

        private void ShowSoundLocation()
        {
            if (Settings.Default.SoundFile != "")
            {
                FileInfo fi = new FileInfo(Settings.Default.SoundFile);

                textBoxSoundFile.Text = fi.Name;
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.EmailAddress = textBoxEmail.Text.Trim();
            Settings.Default.Save();
            Settings.Default.Reload();
        }

      

        private void comboBoxIntervals_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetInterval();
        }

        private void SetInterval()
        {
             int minutes = int.Parse(comboBoxIntervals.Text.Split(new char[]{' '})[0]);

             Settings.Default.IntervalMinutes = minutes;
             Settings.Default.Save();
             Settings.Default.Reload();

        }


        private void LoadInterval()
        {
            comboBoxIntervals.Text = Settings.Default.IntervalMinutes + " Minutes";
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }


      private void LoadGeneralSettings()
        {
            //get and display checked items...
            if (Settings.Default.RunAtStartup)
                checkedListBox1.SetItemChecked(0, true);

            if (Settings.Default.DownloadThumbs)
                checkedListBox1.SetItemChecked(1, true);

            if (Settings.Default.IconFlashOnNew)
                checkedListBox1.SetItemChecked(2, true);

            if (Settings.Default.PulseOnSearch)
                checkedListBox1.SetItemChecked(3, true);
        }

      private void buttonNewColour_Click(object sender, EventArgs e)
      {
          DialogResult dr =  colorDialog1.ShowDialog();

          if (dr == System.Windows.Forms.DialogResult.OK)
          {
              Settings.Default.NewItemsColour = colorDialog1.Color;
              Settings.Default.Save();
              Settings.Default.Reload();

              buttonNewColour.BackColor = Settings.Default.NewItemsColour;
          }
      }

      private void buttonViewedColour_Click(object sender, EventArgs e)
      {
          DialogResult dr = colorDialog1.ShowDialog();

          if (dr == System.Windows.Forms.DialogResult.OK)
          {
              Settings.Default.ViewedColour = colorDialog1.Color;

              Settings.Default.Save();
              Settings.Default.Reload();

              buttonViewedColour.BackColor = Settings.Default.ViewedColour;
          }
      }

      private void label6_Click(object sender, EventArgs e)
      {

      }

      private void button3_Click(object sender, EventArgs e)
      {
          if (listBox1.SelectedIndices.Count > 0)
          {
              Tabs.Tab oldtab = (Tabs.Tab)listBox1.SelectedItem;
              TabForm tf = new TabForm();
              tf.DisplayName = oldtab.DisplayName;
              tf.ExcludeFromAutoSearch = oldtab.ExcludeFromAutoSearch;
              tf.UseExcludeSellerList = oldtab.ExcludeSellers;
              tf.UseExcludeKeywordList = oldtab.ExcludeKeywords;


              if (tf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
              {
                  Tabs.Tab newtab = new Tabs.Tab();
                  newtab.Index = oldtab.Index;
                  
                  newtab.Name = oldtab.Name;
                  newtab.DisplayName = tf.DisplayName;
                  newtab.ExcludeFromAutoSearch = tf.ExcludeFromAutoSearch;
                  newtab.ExcludeSellers = tf.UseExcludeSellerList;
                  newtab.ExcludeKeywords = tf.UseExcludeKeywordList;

               

                  Tabs.TabList.RemoveAt(listBox1.SelectedIndex);

                  Tabs.TabList.Insert(listBox1.SelectedIndex, newtab);

                  
                  //update the searches with the new details...


                  Tabs.SaveTabs();


                  LoadTabs();


                  onTabsUpdated();
              }

          }
      }

      private void button8_Click(object sender, EventArgs e)
      {
          openFileDialog1.FileName = "";
          if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
          {
              Settings.Default.ExcludeSellersFile = openFileDialog1.FileName;
              Settings.Default.Save();
              Settings.Default.Reload();

              textBoxExcludeSeller.Text = openFileDialog1.FileName; 
          }
      }

      private void button9_Click(object sender, EventArgs e)
      {
          openFileDialog1.FileName = "";
          if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
          {
              Settings.Default.ExcludeKeywordsFile = openFileDialog1.FileName;
              Settings.Default.Save();
              Settings.Default.Reload();

              textBoxExcludeKeywords.Text = openFileDialog1.FileName;
          }
      }

      private void textBoxSMTP_TextChanged(object sender, EventArgs e)
      {
          Settings.Default.SMTPServer = textBoxSMTP.Text.Trim();
          Settings.Default.Save();
          Settings.Default.Reload();
      }

    }
}

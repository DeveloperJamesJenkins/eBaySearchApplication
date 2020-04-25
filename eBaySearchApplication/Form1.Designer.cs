namespace eBaySearchApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSearchTab = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSearchSelected = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonViewItems = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeleteSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControlAuctions = new System.Windows.Forms.TabControl();
            this.tabAuctions = new System.Windows.Forms.TabPage();
            this.listViewNews = new System.Windows.Forms.ListView();
            this.columnHeaderTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripMessages = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timerAutoCheck = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.contextMenuStripItems = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCountry = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControlAuctions.SuspendLayout();
            this.contextMenuStripMessages.SuspendLayout();
            this.contextMenuStripItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tsmCountry,
            this.donateToolStripMenuItem,
            this.websiteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupToolStripMenuItem,
            this.toolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.fileToolStripMenuItem.Text = "&Files";
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.backupToolStripMenuItem.Text = "&Backup Files";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.toolStripMenuItem1.Text = "&Recover Files";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            this.donateToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.donateToolStripMenuItem.Text = "Donate";
            this.donateToolStripMenuItem.Click += new System.EventHandler(this.donateToolStripMenuItem_Click);
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.websiteToolStripMenuItem.Text = "Website";
            this.websiteToolStripMenuItem.Click += new System.EventHandler(this.websiteToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator3,
            this.toolStripButton2,
            this.toolStripButtonSearchTab,
            this.toolStripButtonSearchSelected,
            this.toolStripSeparator1,
            this.toolStripButtonViewItems,
            this.toolStripButtonEditSearch,
            this.toolStripButtonDeleteSearch,
            this.toolStripSeparator2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(790, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "Tool Bar";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::eBaySearchApplication.Properties.Resources.office3_24;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "Add Search";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::eBaySearchApplication.Properties.Resources.circle_green;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton2.Text = "Start/Stop Auto Search";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // toolStripButtonSearchTab
            // 
            this.toolStripButtonSearchTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSearchTab.Image = global::eBaySearchApplication.Properties.Resources.poli1372221;
            this.toolStripButtonSearchTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSearchTab.Name = "toolStripButtonSearchTab";
            this.toolStripButtonSearchTab.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonSearchTab.Tag = "0";
            this.toolStripButtonSearchTab.Text = "Search Current Tab";
            this.toolStripButtonSearchTab.Click += new System.EventHandler(this.toolStripButtonSearchTab_Click);
            // 
            // toolStripButtonSearchSelected
            // 
            this.toolStripButtonSearchSelected.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSearchSelected.Enabled = false;
            this.toolStripButtonSearchSelected.Image = global::eBaySearchApplication.Properties.Resources.search_48;
            this.toolStripButtonSearchSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSearchSelected.Name = "toolStripButtonSearchSelected";
            this.toolStripButtonSearchSelected.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonSearchSelected.Text = "Search Current Item Only";
            this.toolStripButtonSearchSelected.Click += new System.EventHandler(this.toolStripButtonSearchSelected_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButtonViewItems
            // 
            this.toolStripButtonViewItems.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonViewItems.Enabled = false;
            this.toolStripButtonViewItems.Image = global::eBaySearchApplication.Properties.Resources.js_view_all_jobs1;
            this.toolStripButtonViewItems.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripButtonViewItems.Name = "toolStripButtonViewItems";
            this.toolStripButtonViewItems.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonViewItems.Text = "View Selected Items";
            this.toolStripButtonViewItems.Click += new System.EventHandler(this.toolStripButtonViewItems_Click);
            // 
            // toolStripButtonEditSearch
            // 
            this.toolStripButtonEditSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditSearch.Enabled = false;
            this.toolStripButtonEditSearch.Image = global::eBaySearchApplication.Properties.Resources.app_48;
            this.toolStripButtonEditSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditSearch.Name = "toolStripButtonEditSearch";
            this.toolStripButtonEditSearch.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonEditSearch.Text = "Edit Search";
            this.toolStripButtonEditSearch.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButtonDeleteSearch
            // 
            this.toolStripButtonDeleteSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDeleteSearch.Enabled = false;
            this.toolStripButtonDeleteSearch.Image = global::eBaySearchApplication.Properties.Resources.cancel_48;
            this.toolStripButtonDeleteSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteSearch.Name = "toolStripButtonDeleteSearch";
            this.toolStripButtonDeleteSearch.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonDeleteSearch.Text = "Delete Search";
            this.toolStripButtonDeleteSearch.Click += new System.EventHandler(this.toolStripButtonDeleteSearch_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton3.Text = "Settings";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 63);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControlAuctions);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listViewNews);
            this.splitContainer1.Size = new System.Drawing.Size(790, 382);
            this.splitContainer1.SplitterDistance = 252;
            this.splitContainer1.TabIndex = 2;
            // 
            // tabControlAuctions
            // 
            this.tabControlAuctions.Controls.Add(this.tabAuctions);
            this.tabControlAuctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAuctions.Location = new System.Drawing.Point(0, 0);
            this.tabControlAuctions.Name = "tabControlAuctions";
            this.tabControlAuctions.SelectedIndex = 0;
            this.tabControlAuctions.Size = new System.Drawing.Size(790, 252);
            this.tabControlAuctions.TabIndex = 0;
            this.tabControlAuctions.SelectedIndexChanged += new System.EventHandler(this.tabControlAuctions_SelectedIndexChanged);
            // 
            // tabAuctions
            // 
            this.tabAuctions.Location = new System.Drawing.Point(4, 22);
            this.tabAuctions.Name = "tabAuctions";
            this.tabAuctions.Padding = new System.Windows.Forms.Padding(3);
            this.tabAuctions.Size = new System.Drawing.Size(782, 226);
            this.tabAuctions.TabIndex = 0;
            this.tabAuctions.Text = "Auctions";
            this.tabAuctions.UseVisualStyleBackColor = true;
            // 
            // listViewNews
            // 
            this.listViewNews.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTime,
            this.columnHeaderMessage});
            this.listViewNews.ContextMenuStrip = this.contextMenuStripMessages;
            this.listViewNews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewNews.FullRowSelect = true;
            this.listViewNews.Location = new System.Drawing.Point(0, 0);
            this.listViewNews.Name = "listViewNews";
            this.listViewNews.Size = new System.Drawing.Size(790, 126);
            this.listViewNews.TabIndex = 0;
            this.listViewNews.UseCompatibleStateImageBehavior = false;
            this.listViewNews.View = System.Windows.Forms.View.Details;
            this.listViewNews.SelectedIndexChanged += new System.EventHandler(this.listViewNews_DoubleClick);
            this.listViewNews.DoubleClick += new System.EventHandler(this.listViewNews_DoubleClick);
            // 
            // columnHeaderTime
            // 
            this.columnHeaderTime.Text = "Time";
            this.columnHeaderTime.Width = 174;
            // 
            // columnHeaderMessage
            // 
            this.columnHeaderMessage.Text = "Message";
            this.columnHeaderMessage.Width = 454;
            // 
            // contextMenuStripMessages
            // 
            this.contextMenuStripMessages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.contextMenuStripMessages.Name = "contextMenuStripMessages";
            this.contextMenuStripMessages.Size = new System.Drawing.Size(102, 26);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "eBay Search Application";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // timerAutoCheck
            // 
            this.timerAutoCheck.Interval = 60000;
            this.timerAutoCheck.Tick += new System.EventHandler(this.timerAutoCheck_Tick);
            // 
            // contextMenuStripItems
            // 
            this.contextMenuStripItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.toolStripMenuItem2,
            this.deleteSearchToolStripMenuItem});
            this.contextMenuStripItems.Name = "contextMenuStripItems";
            this.contextMenuStripItems.Size = new System.Drawing.Size(164, 70);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(163, 22);
            this.toolStripMenuItem2.Text = "Mark All As Read";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // deleteSearchToolStripMenuItem
            // 
            this.deleteSearchToolStripMenuItem.Name = "deleteSearchToolStripMenuItem";
            this.deleteSearchToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.deleteSearchToolStripMenuItem.Text = "Delete Search";
            this.deleteSearchToolStripMenuItem.Click += new System.EventHandler(this.deleteSearchToolStripMenuItem_Click);
            // 
            // tsmCountry
            // 
            this.tsmCountry.Name = "tsmCountry";
            this.tsmCountry.Size = new System.Drawing.Size(62, 20);
            this.tsmCountry.Text = "Country";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 445);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eBay Search Software";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControlAuctions.ResumeLayout(false);
            this.contextMenuStripMessages.ResumeLayout(false);
            this.contextMenuStripItems.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControlAuctions;
        private System.Windows.Forms.TabPage tabAuctions;
        private AuctionList auAuctions;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditSearch;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButtonSearchSelected;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteSearch;
        private System.Windows.Forms.ListView listViewNews;
        private System.Windows.Forms.ColumnHeader columnHeaderTime;
        private System.Windows.Forms.ColumnHeader columnHeaderMessage;
        private System.Windows.Forms.ToolStripButton toolStripButtonSearchTab;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timerAutoCheck;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMessages;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton toolStripButtonViewItems;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripItems;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deleteSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmCountry;
    }
}


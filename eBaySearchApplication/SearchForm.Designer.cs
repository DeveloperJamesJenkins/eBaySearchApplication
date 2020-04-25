namespace eBaySearchApplication
{
    partial class SearchForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxPaypal = new System.Windows.Forms.CheckBox();
            this.checkBoxWithBINs = new System.Windows.Forms.CheckBox();
            this.checkBoxDescriptionSearch = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDisplayName = new System.Windows.Forms.TextBox();
            this.textBoxQuery = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.checkedListBoxConditions = new System.Windows.Forms.CheckedListBox();
            this.checkBoxAutoSearch = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboTabs = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkedListBoxNotifications = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.moneyBoxUpper = new System.Windows.Forms.TextBox();
            this.moneyBoxLower = new System.Windows.Forms.TextBox();
            this.checkBoxUsePrices = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numMaxDistance = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteKeyword = new System.Windows.Forms.Button();
            this.listBoxExcludeKeywords = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonDeleteSeller = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.listBoxSellers = new System.Windows.Forms.ListBox();
            this.textBoxExcludeKeywords = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSeller = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxDistance)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxPaypal);
            this.panel1.Controls.Add(this.checkBoxWithBINs);
            this.panel1.Controls.Add(this.checkBoxDescriptionSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBoxCategory);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxDisplayName);
            this.panel1.Controls.Add(this.textBoxQuery);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 126);
            this.panel1.TabIndex = 0;
            // 
            // checkBoxPaypal
            // 
            this.checkBoxPaypal.AutoSize = true;
            this.checkBoxPaypal.Location = new System.Drawing.Point(382, 99);
            this.checkBoxPaypal.Name = "checkBoxPaypal";
            this.checkBoxPaypal.Size = new System.Drawing.Size(218, 17);
            this.checkBoxPaypal.TabIndex = 5;
            this.checkBoxPaypal.Text = "Only Show Auctions That Accept Paypal";
            this.checkBoxPaypal.UseVisualStyleBackColor = true;
            // 
            // checkBoxWithBINs
            // 
            this.checkBoxWithBINs.AutoSize = true;
            this.checkBoxWithBINs.Location = new System.Drawing.Point(382, 76);
            this.checkBoxWithBINs.Name = "checkBoxWithBINs";
            this.checkBoxWithBINs.Size = new System.Drawing.Size(192, 17);
            this.checkBoxWithBINs.TabIndex = 4;
            this.checkBoxWithBINs.Text = "Include Auction without Buy-It-Now";
            this.checkBoxWithBINs.UseVisualStyleBackColor = true;
            this.checkBoxWithBINs.CheckedChanged += new System.EventHandler(this.checkBoxWithBINs_CheckedChanged);
            // 
            // checkBoxDescriptionSearch
            // 
            this.checkBoxDescriptionSearch.AutoSize = true;
            this.checkBoxDescriptionSearch.Location = new System.Drawing.Point(382, 53);
            this.checkBoxDescriptionSearch.Name = "checkBoxDescriptionSearch";
            this.checkBoxDescriptionSearch.Size = new System.Drawing.Size(148, 17);
            this.checkBoxDescriptionSearch.TabIndex = 3;
            this.checkBoxDescriptionSearch.Text = "Search Title && Description";
            this.checkBoxDescriptionSearch.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Category";
            // 
            // button1
            // 
            this.button1.Image = global::eBaySearchApplication.Properties.Resources.end;
            this.button1.Location = new System.Drawing.Point(529, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 23);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(382, 27);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(141, 20);
            this.textBoxCategory.TabIndex = 2;
            this.textBoxCategory.TextChanged += new System.EventHandler(this.textBoxCategory_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Display Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Keywords";
            // 
            // textBoxDisplayName
            // 
            this.textBoxDisplayName.Location = new System.Drawing.Point(16, 27);
            this.textBoxDisplayName.Name = "textBoxDisplayName";
            this.textBoxDisplayName.Size = new System.Drawing.Size(339, 20);
            this.textBoxDisplayName.TabIndex = 0;
            // 
            // textBoxQuery
            // 
            this.textBoxQuery.Location = new System.Drawing.Point(16, 96);
            this.textBoxQuery.Name = "textBoxQuery";
            this.textBoxQuery.Size = new System.Drawing.Size(339, 20);
            this.textBoxQuery.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(491, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "&Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(572, 362);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "&OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(6, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(633, 150);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(654, 344);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.checkBoxAutoSearch);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(646, 318);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.checkedListBoxConditions);
            this.groupBox7.Location = new System.Drawing.Point(174, 165);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(188, 124);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Condition States";
            // 
            // checkedListBoxConditions
            // 
            this.checkedListBoxConditions.FormattingEnabled = true;
            this.checkedListBoxConditions.Location = new System.Drawing.Point(7, 20);
            this.checkedListBoxConditions.Name = "checkedListBoxConditions";
            this.checkedListBoxConditions.Size = new System.Drawing.Size(175, 94);
            this.checkedListBoxConditions.TabIndex = 0;
            // 
            // checkBoxAutoSearch
            // 
            this.checkBoxAutoSearch.AutoSize = true;
            this.checkBoxAutoSearch.Checked = true;
            this.checkBoxAutoSearch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoSearch.Location = new System.Drawing.Point(12, 295);
            this.checkBoxAutoSearch.Name = "checkBoxAutoSearch";
            this.checkBoxAutoSearch.Size = new System.Drawing.Size(220, 17);
            this.checkBoxAutoSearch.TabIndex = 12;
            this.checkBoxAutoSearch.Text = "Include the search in automatic searches";
            this.checkBoxAutoSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboTabs);
            this.groupBox4.Location = new System.Drawing.Point(369, 248);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(271, 55);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tab";
            // 
            // comboTabs
            // 
            this.comboTabs.FormattingEnabled = true;
            this.comboTabs.Location = new System.Drawing.Point(15, 19);
            this.comboTabs.Name = "comboTabs";
            this.comboTabs.Size = new System.Drawing.Size(246, 21);
            this.comboTabs.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkedListBoxNotifications);
            this.groupBox3.Location = new System.Drawing.Point(368, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 78);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Notifications";
            // 
            // checkedListBoxNotifications
            // 
            this.checkedListBoxNotifications.FormattingEnabled = true;
            this.checkedListBoxNotifications.Items.AddRange(new object[] {
            "Popup in system tray",
            "Play a sound effect",
            "Send me an email"});
            this.checkedListBoxNotifications.Location = new System.Drawing.Point(26, 20);
            this.checkedListBoxNotifications.Name = "checkedListBoxNotifications";
            this.checkedListBoxNotifications.Size = new System.Drawing.Size(229, 49);
            this.checkedListBoxNotifications.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.moneyBoxUpper);
            this.groupBox1.Controls.Add(this.moneyBoxLower);
            this.groupBox1.Controls.Add(this.checkBoxUsePrices);
            this.groupBox1.Location = new System.Drawing.Point(6, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 124);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Price Range";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Upper Limit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lower Limit";
            // 
            // moneyBoxUpper
            // 
            this.moneyBoxUpper.Location = new System.Drawing.Point(22, 58);
            this.moneyBoxUpper.Name = "moneyBoxUpper";
            this.moneyBoxUpper.Size = new System.Drawing.Size(105, 20);
            this.moneyBoxUpper.TabIndex = 0;
            // 
            // moneyBoxLower
            // 
            this.moneyBoxLower.Location = new System.Drawing.Point(22, 98);
            this.moneyBoxLower.Name = "moneyBoxLower";
            this.moneyBoxLower.Size = new System.Drawing.Size(105, 20);
            this.moneyBoxLower.TabIndex = 1;
            // 
            // checkBoxUsePrices
            // 
            this.checkBoxUsePrices.AutoSize = true;
            this.checkBoxUsePrices.Checked = true;
            this.checkBoxUsePrices.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUsePrices.Location = new System.Drawing.Point(22, 20);
            this.checkBoxUsePrices.Name = "checkBoxUsePrices";
            this.checkBoxUsePrices.Size = new System.Drawing.Size(107, 17);
            this.checkBoxUsePrices.TabIndex = 0;
            this.checkBoxUsePrices.Text = "Use Price Range";
            this.checkBoxUsePrices.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(646, 318);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.numMaxDistance);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.txtPostCode);
            this.groupBox8.Location = new System.Drawing.Point(7, 247);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(351, 65);
            this.groupBox8.TabIndex = 23;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Location";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(173, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Max Distance in Miles";
            // 
            // numMaxDistance
            // 
            this.numMaxDistance.Location = new System.Drawing.Point(176, 38);
            this.numMaxDistance.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numMaxDistance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxDistance.Name = "numMaxDistance";
            this.numMaxDistance.Size = new System.Drawing.Size(70, 20);
            this.numMaxDistance.TabIndex = 21;
            this.numMaxDistance.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(73, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "PostCode/Zip";
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(73, 38);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(86, 20);
            this.txtPostCode.TabIndex = 19;
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(365, 7);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(274, 305);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonDeleteKeyword);
            this.groupBox5.Controls.Add(this.listBoxExcludeKeywords);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.buttonDeleteSeller);
            this.groupBox5.Controls.Add(this.button6);
            this.groupBox5.Controls.Add(this.listBoxSellers);
            this.groupBox5.Controls.Add(this.textBoxExcludeKeywords);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.textBoxSeller);
            this.groupBox5.Location = new System.Drawing.Point(7, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(351, 233);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Exclusions";
            // 
            // buttonDeleteKeyword
            // 
            this.buttonDeleteKeyword.Image = global::eBaySearchApplication.Properties.Resources.cancel_16;
            this.buttonDeleteKeyword.Location = new System.Drawing.Point(311, 202);
            this.buttonDeleteKeyword.Name = "buttonDeleteKeyword";
            this.buttonDeleteKeyword.Size = new System.Drawing.Size(26, 23);
            this.buttonDeleteKeyword.TabIndex = 23;
            this.buttonDeleteKeyword.UseVisualStyleBackColor = true;
            this.buttonDeleteKeyword.Visible = false;
            this.buttonDeleteKeyword.Click += new System.EventHandler(this.buttonDeleteKeyword_Click);
            // 
            // listBoxExcludeKeywords
            // 
            this.listBoxExcludeKeywords.FormattingEnabled = true;
            this.listBoxExcludeKeywords.Location = new System.Drawing.Point(176, 51);
            this.listBoxExcludeKeywords.Name = "listBoxExcludeKeywords";
            this.listBoxExcludeKeywords.Size = new System.Drawing.Size(153, 147);
            this.listBoxExcludeKeywords.TabIndex = 19;
            this.listBoxExcludeKeywords.Click += new System.EventHandler(this.listBoxExcludeKeywords_Click);
            this.listBoxExcludeKeywords.SelectedIndexChanged += new System.EventHandler(this.listBoxExcludeKeywords_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Exclude Keywords";
            // 
            // buttonDeleteSeller
            // 
            this.buttonDeleteSeller.Image = global::eBaySearchApplication.Properties.Resources.cancel_16;
            this.buttonDeleteSeller.Location = new System.Drawing.Point(141, 202);
            this.buttonDeleteSeller.Name = "buttonDeleteSeller";
            this.buttonDeleteSeller.Size = new System.Drawing.Size(26, 23);
            this.buttonDeleteSeller.TabIndex = 21;
            this.buttonDeleteSeller.UseVisualStyleBackColor = true;
            this.buttonDeleteSeller.Visible = false;
            this.buttonDeleteSeller.Click += new System.EventHandler(this.buttonDeleteSeller_Click);
            // 
            // button6
            // 
            this.button6.Image = global::eBaySearchApplication.Properties.Resources.add_16;
            this.button6.Location = new System.Drawing.Point(311, 202);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(26, 23);
            this.button6.TabIndex = 22;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // listBoxSellers
            // 
            this.listBoxSellers.FormattingEnabled = true;
            this.listBoxSellers.Location = new System.Drawing.Point(6, 51);
            this.listBoxSellers.Name = "listBoxSellers";
            this.listBoxSellers.Size = new System.Drawing.Size(153, 147);
            this.listBoxSellers.TabIndex = 13;
            this.listBoxSellers.Click += new System.EventHandler(this.listBoxSellers_Click);
            this.listBoxSellers.SelectedIndexChanged += new System.EventHandler(this.listBoxSellers_SelectedIndexChanged);
            // 
            // textBoxExcludeKeywords
            // 
            this.textBoxExcludeKeywords.Location = new System.Drawing.Point(176, 205);
            this.textBoxExcludeKeywords.Name = "textBoxExcludeKeywords";
            this.textBoxExcludeKeywords.Size = new System.Drawing.Size(129, 20);
            this.textBoxExcludeKeywords.TabIndex = 21;
            // 
            // button4
            // 
            this.button4.Image = global::eBaySearchApplication.Properties.Resources.add_16;
            this.button4.Location = new System.Drawing.Point(141, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 23);
            this.button4.TabIndex = 18;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Exclude Sellers From Search";
            // 
            // textBoxSeller
            // 
            this.textBoxSeller.Location = new System.Drawing.Point(6, 205);
            this.textBoxSeller.Name = "textBoxSeller";
            this.textBoxSeller.Size = new System.Drawing.Size(129, 20);
            this.textBoxSeller.TabIndex = 17;
            this.textBoxSeller.TextChanged += new System.EventHandler(this.textBoxSeller_TextChanged);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 392);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxDistance)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDisplayName;
        private System.Windows.Forms.TextBox textBoxQuery;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.CheckBox checkBoxPaypal;
        private System.Windows.Forms.CheckBox checkBoxWithBINs;
        private System.Windows.Forms.CheckBox checkBoxDescriptionSearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboTabs;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox checkedListBoxNotifications;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox moneyBoxUpper;
        private System.Windows.Forms.TextBox moneyBoxLower;
        private System.Windows.Forms.CheckBox checkBoxUsePrices;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxSeller;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxSellers;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox listBoxExcludeKeywords;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBoxExcludeKeywords;
        private System.Windows.Forms.CheckBox checkBoxAutoSearch;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckedListBox checkedListBoxConditions;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numMaxDistance;
        private System.Windows.Forms.Button buttonDeleteSeller;
        private System.Windows.Forms.Button buttonDeleteKeyword;
    }
}
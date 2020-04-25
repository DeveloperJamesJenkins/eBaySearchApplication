namespace eBaySearchApplication
{
    partial class Options
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("General");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Intervals");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Notifications");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Tabs");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Exclusions");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Results");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBoxTabs = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelTabs = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panelNotifications = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSMTP = new System.Windows.Forms.TextBox();
            this.textBoxSoundFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonSelectSound = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelIntervals = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxIntervals = new System.Windows.Forms.ComboBox();
            this.panelResults = new System.Windows.Forms.Panel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.buttonViewedColour = new System.Windows.Forms.Button();
            this.buttonNewColour = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panelExclusions = new System.Windows.Forms.Panel();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.textBoxExcludeKeywords = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.textBoxExcludeSeller = new System.Windows.Forms.TextBox();
            this.groupBoxTabs.SuspendLayout();
            this.panelTabs.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelNotifications.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panelGeneral.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panelIntervals.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panelResults.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.panelExclusions.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 13);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "NodeGeneral";
            treeNode1.Text = "General";
            treeNode2.Name = "NodeIntervals";
            treeNode2.Text = "Intervals";
            treeNode3.Name = "NodeNotifications";
            treeNode3.Text = "Notifications";
            treeNode4.Name = "NodeTabs";
            treeNode4.Text = "Tabs";
            treeNode5.Name = "NodeExclusions";
            treeNode5.Text = "Exclusions";
            treeNode6.Name = "NodeResults";
            treeNode6.Text = "Results";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(147, 265);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // groupBoxTabs
            // 
            this.groupBoxTabs.Controls.Add(this.listBox1);
            this.groupBoxTabs.Controls.Add(this.button5);
            this.groupBoxTabs.Controls.Add(this.button4);
            this.groupBoxTabs.Controls.Add(this.button3);
            this.groupBoxTabs.Controls.Add(this.button2);
            this.groupBoxTabs.Controls.Add(this.button1);
            this.groupBoxTabs.Location = new System.Drawing.Point(10, 3);
            this.groupBoxTabs.Name = "groupBoxTabs";
            this.groupBoxTabs.Size = new System.Drawing.Size(241, 183);
            this.groupBoxTabs.TabIndex = 1;
            this.groupBoxTabs.TabStop = false;
            this.groupBoxTabs.Text = "Tabs";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(138, 160);
            this.listBox1.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(160, 153);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Move Down";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(160, 124);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Move Up";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(160, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Modify";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(160, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelTabs
            // 
            this.panelTabs.Controls.Add(this.groupBox1);
            this.panelTabs.Controls.Add(this.groupBoxTabs);
            this.panelTabs.Location = new System.Drawing.Point(12, 332);
            this.panelTabs.Name = "panelTabs";
            this.panelTabs.Size = new System.Drawing.Size(263, 265);
            this.panelTabs.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(10, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 70);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Description";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(7, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 44);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Diferent searches  can be organised in these tabs. Add and name tabs and set the " +
                "order to be shown.";
            // 
            // button6
            // 
            this.button6.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button6.Location = new System.Drawing.Point(351, 284);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "&OK";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button7.Location = new System.Drawing.Point(270, 284);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 3;
            this.button7.Text = "&Cancel";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panelNotifications
            // 
            this.panelNotifications.Controls.Add(this.groupBox2);
            this.panelNotifications.Controls.Add(this.groupBox3);
            this.panelNotifications.Location = new System.Drawing.Point(734, 10);
            this.panelNotifications.Name = "panelNotifications";
            this.panelNotifications.Size = new System.Drawing.Size(263, 265);
            this.panelNotifications.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(10, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 70);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Description";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(7, 20);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 44);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Set the ways in which you want to be alerted to new items. You can have a popup a" +
                "nd an email. ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBoxSMTP);
            this.groupBox3.Controls.Add(this.textBoxSoundFile);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBoxEmail);
            this.groupBox3.Controls.Add(this.buttonSelectSound);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(10, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(241, 183);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Notifications";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "SMTP Server";
            // 
            // textBoxSMTP
            // 
            this.textBoxSMTP.Location = new System.Drawing.Point(20, 145);
            this.textBoxSMTP.Name = "textBoxSMTP";
            this.textBoxSMTP.Size = new System.Drawing.Size(121, 20);
            this.textBoxSMTP.TabIndex = 8;
            this.textBoxSMTP.TextChanged += new System.EventHandler(this.textBoxSMTP_TextChanged);
            // 
            // textBoxSoundFile
            // 
            this.textBoxSoundFile.Enabled = false;
            this.textBoxSoundFile.Location = new System.Drawing.Point(17, 48);
            this.textBoxSoundFile.Name = "textBoxSoundFile";
            this.textBoxSoundFile.Size = new System.Drawing.Size(121, 20);
            this.textBoxSoundFile.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(17, 97);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(121, 20);
            this.textBoxEmail.TabIndex = 4;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // buttonSelectSound
            // 
            this.buttonSelectSound.Image = global::eBaySearchApplication.Properties.Resources.end;
            this.buttonSelectSound.Location = new System.Drawing.Point(145, 48);
            this.buttonSelectSound.Name = "buttonSelectSound";
            this.buttonSelectSound.Size = new System.Drawing.Size(31, 23);
            this.buttonSelectSound.TabIndex = 2;
            this.buttonSelectSound.UseVisualStyleBackColor = true;
            this.buttonSelectSound.Click += new System.EventHandler(this.buttonSelectSound_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sound File";
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.groupBox4);
            this.panelGeneral.Controls.Add(this.groupBox5);
            this.panelGeneral.Location = new System.Drawing.Point(166, 13);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(263, 265);
            this.panelGeneral.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Location = new System.Drawing.Point(10, 192);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(241, 70);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Description";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(7, 20);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(228, 44);
            this.textBox4.TabIndex = 0;
            this.textBox4.Text = "Gerneral options for you to set";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkedListBox1);
            this.groupBox5.Location = new System.Drawing.Point(10, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(241, 183);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "General";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Run Software At Startup",
            "Download And Display Thumbnails"});
            this.checkedListBox1.Location = new System.Drawing.Point(7, 19);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(228, 154);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panelIntervals
            // 
            this.panelIntervals.Controls.Add(this.groupBox6);
            this.panelIntervals.Controls.Add(this.groupBox7);
            this.panelIntervals.Location = new System.Drawing.Point(291, 332);
            this.panelIntervals.Name = "panelIntervals";
            this.panelIntervals.Size = new System.Drawing.Size(263, 265);
            this.panelIntervals.TabIndex = 7;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox3);
            this.groupBox6.Location = new System.Drawing.Point(10, 192);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(241, 70);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Description";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(7, 20);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(228, 44);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "Set the interval times for checking the saved searches.";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.comboBoxIntervals);
            this.groupBox7.Location = new System.Drawing.Point(10, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(241, 183);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Intervals";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Time Between Searches";
            // 
            // comboBoxIntervals
            // 
            this.comboBoxIntervals.FormattingEnabled = true;
            this.comboBoxIntervals.Items.AddRange(new object[] {
            "1 Minute",
            "2 Minutes",
            "3 Minutes",
            "5 Minutes",
            "10 Minutes",
            "15 Minutes",
            "30 Minutes",
            "60 Minutes"});
            this.comboBoxIntervals.Location = new System.Drawing.Point(34, 53);
            this.comboBoxIntervals.Name = "comboBoxIntervals";
            this.comboBoxIntervals.Size = new System.Drawing.Size(123, 21);
            this.comboBoxIntervals.TabIndex = 0;
            this.comboBoxIntervals.Text = "1 Minute";
            this.comboBoxIntervals.SelectedIndexChanged += new System.EventHandler(this.comboBoxIntervals_SelectedIndexChanged);
            // 
            // panelResults
            // 
            this.panelResults.Controls.Add(this.groupBox8);
            this.panelResults.Controls.Add(this.groupBox9);
            this.panelResults.Location = new System.Drawing.Point(579, 295);
            this.panelResults.Name = "panelResults";
            this.panelResults.Size = new System.Drawing.Size(263, 265);
            this.panelResults.TabIndex = 8;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.textBox5);
            this.groupBox8.Location = new System.Drawing.Point(10, 192);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(241, 70);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Description";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(7, 20);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(228, 44);
            this.textBox5.TabIndex = 0;
            this.textBox5.Text = "Set Colours to see quickly what you have viewed or not.";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.buttonViewedColour);
            this.groupBox9.Controls.Add(this.buttonNewColour);
            this.groupBox9.Controls.Add(this.label5);
            this.groupBox9.Controls.Add(this.label4);
            this.groupBox9.Location = new System.Drawing.Point(10, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(241, 183);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Colours";
            // 
            // buttonViewedColour
            // 
            this.buttonViewedColour.Location = new System.Drawing.Point(136, 75);
            this.buttonViewedColour.Name = "buttonViewedColour";
            this.buttonViewedColour.Size = new System.Drawing.Size(75, 23);
            this.buttonViewedColour.TabIndex = 3;
            this.buttonViewedColour.UseVisualStyleBackColor = true;
            this.buttonViewedColour.Click += new System.EventHandler(this.buttonViewedColour_Click);
            // 
            // buttonNewColour
            // 
            this.buttonNewColour.Location = new System.Drawing.Point(136, 32);
            this.buttonNewColour.Name = "buttonNewColour";
            this.buttonNewColour.Size = new System.Drawing.Size(75, 23);
            this.buttonNewColour.TabIndex = 2;
            this.buttonNewColour.UseVisualStyleBackColor = true;
            this.buttonNewColour.Click += new System.EventHandler(this.buttonNewColour_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Viewed Auctions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "New Auctions";
            // 
            // panelExclusions
            // 
            this.panelExclusions.Controls.Add(this.groupBox10);
            this.panelExclusions.Controls.Add(this.groupBox11);
            this.panelExclusions.Location = new System.Drawing.Point(453, 16);
            this.panelExclusions.Name = "panelExclusions";
            this.panelExclusions.Size = new System.Drawing.Size(263, 265);
            this.panelExclusions.TabIndex = 9;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.textBox6);
            this.groupBox10.Location = new System.Drawing.Point(10, 192);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(241, 70);
            this.groupBox10.TabIndex = 2;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Description";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.ForeColor = System.Drawing.Color.Black;
            this.textBox6.Location = new System.Drawing.Point(7, 20);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(228, 44);
            this.textBox6.TabIndex = 0;
            this.textBox6.Text = "Set Exclusion Lists to be set against each Tab. So you can exclude keywords and s" +
                "ellers. Lists should be comma delimited";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label7);
            this.groupBox11.Controls.Add(this.label6);
            this.groupBox11.Controls.Add(this.button9);
            this.groupBox11.Controls.Add(this.textBoxExcludeKeywords);
            this.groupBox11.Controls.Add(this.button8);
            this.groupBox11.Controls.Add(this.textBoxExcludeSeller);
            this.groupBox11.Location = new System.Drawing.Point(10, 3);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(241, 183);
            this.groupBox11.TabIndex = 1;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Exclusions";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Loction of Exclude Keywords File";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Location Exclude Sellers File";
            // 
            // button9
            // 
            this.button9.Image = global::eBaySearchApplication.Properties.Resources.add_16;
            this.button9.Location = new System.Drawing.Point(195, 125);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(26, 23);
            this.button9.TabIndex = 23;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBoxExcludeKeywords
            // 
            this.textBoxExcludeKeywords.Location = new System.Drawing.Point(22, 128);
            this.textBoxExcludeKeywords.Name = "textBoxExcludeKeywords";
            this.textBoxExcludeKeywords.Size = new System.Drawing.Size(167, 20);
            this.textBoxExcludeKeywords.TabIndex = 22;
            // 
            // button8
            // 
            this.button8.Image = global::eBaySearchApplication.Properties.Resources.add_16;
            this.button8.Location = new System.Drawing.Point(195, 56);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(26, 23);
            this.button8.TabIndex = 20;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBoxExcludeSeller
            // 
            this.textBoxExcludeSeller.Location = new System.Drawing.Point(22, 59);
            this.textBoxExcludeSeller.Name = "textBoxExcludeSeller";
            this.textBoxExcludeSeller.Size = new System.Drawing.Size(167, 20);
            this.textBoxExcludeSeller.TabIndex = 19;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 315);
            this.Controls.Add(this.panelExclusions);
            this.Controls.Add(this.panelResults);
            this.Controls.Add(this.panelIntervals);
            this.Controls.Add(this.panelGeneral);
            this.Controls.Add(this.panelNotifications);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.panelTabs);
            this.Controls.Add(this.treeView1);
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.groupBoxTabs.ResumeLayout(false);
            this.panelTabs.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelNotifications.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panelGeneral.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.panelIntervals.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.panelResults.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.panelExclusions.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBoxTabs;
        private System.Windows.Forms.Panel panelTabs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panelNotifications;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSelectSound;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxSoundFile;
        private System.Windows.Forms.Panel panelIntervals;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxIntervals;
        private System.Windows.Forms.Panel panelResults;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonViewedColour;
        private System.Windows.Forms.Button buttonNewColour;
        private System.Windows.Forms.Panel panelExclusions;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBoxExcludeSeller;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBoxExcludeKeywords;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSMTP;
    }
}
namespace eBaySearchApplication
{
    partial class TabForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxUseSellers = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxExcludeKeywords = new System.Windows.Forms.CheckBox();
            this.checkBoxExcludeAutoSearch = new System.Windows.Forms.CheckBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tab Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tab Display Name";
            // 
            // checkBoxUseSellers
            // 
            this.checkBoxUseSellers.AutoSize = true;
            this.checkBoxUseSellers.Location = new System.Drawing.Point(65, 19);
            this.checkBoxUseSellers.Name = "checkBoxUseSellers";
            this.checkBoxUseSellers.Size = new System.Drawing.Size(127, 17);
            this.checkBoxUseSellers.TabIndex = 2;
            this.checkBoxUseSellers.Text = "Use Seller Exclusions";
            this.checkBoxUseSellers.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxExcludeAutoSearch);
            this.groupBox2.Controls.Add(this.checkBoxExcludeKeywords);
            this.groupBox2.Controls.Add(this.checkBoxUseSellers);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 108);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exclusions";
            // 
            // checkBoxExcludeKeywords
            // 
            this.checkBoxExcludeKeywords.AutoSize = true;
            this.checkBoxExcludeKeywords.Location = new System.Drawing.Point(65, 47);
            this.checkBoxExcludeKeywords.Name = "checkBoxExcludeKeywords";
            this.checkBoxExcludeKeywords.Size = new System.Drawing.Size(147, 17);
            this.checkBoxExcludeKeywords.TabIndex = 3;
            this.checkBoxExcludeKeywords.Text = "Use Keywords Exclusions";
            this.checkBoxExcludeKeywords.UseVisualStyleBackColor = true;
            // 
            // checkBoxExcludeAutoSearch
            // 
            this.checkBoxExcludeAutoSearch.AutoSize = true;
            this.checkBoxExcludeAutoSearch.Location = new System.Drawing.Point(65, 75);
            this.checkBoxExcludeAutoSearch.Name = "checkBoxExcludeAutoSearch";
            this.checkBoxExcludeAutoSearch.Size = new System.Drawing.Size(152, 17);
            this.checkBoxExcludeAutoSearch.TabIndex = 4;
            this.checkBoxExcludeAutoSearch.Text = "Exclude From Auto Search";
            this.checkBoxExcludeAutoSearch.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button6.Location = new System.Drawing.Point(197, 233);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "&OK";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button7.Location = new System.Drawing.Point(116, 233);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 5;
            this.button7.Text = "&Cancel";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // TabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 268);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TabForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TabForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxUseSellers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxExcludeKeywords;
        private System.Windows.Forms.CheckBox checkBoxExcludeAutoSearch;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}
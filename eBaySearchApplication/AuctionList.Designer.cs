namespace eBaySearchApplication
{
    partial class AuctionList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.chSearches = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBestPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNewResults = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTotalResults = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSearches,
            this.chBestPrice,
            this.chNewResults,
            this.chTotalResults});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(514, 216);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Resize += new System.EventHandler(this.listView1_Resize);
            // 
            // chSearches
            // 
            this.chSearches.Text = "Searches";
            this.chSearches.Width = 247;
            // 
            // chBestPrice
            // 
            this.chBestPrice.Text = "Best Price";
            this.chBestPrice.Width = 85;
            // 
            // chNewResults
            // 
            this.chNewResults.Text = "New Results";
            this.chNewResults.Width = 93;
            // 
            // chTotalResults
            // 
            this.chTotalResults.Text = "Total Results";
            this.chTotalResults.Width = 83;
            // 
            // AuctionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Name = "AuctionList";
            this.Size = new System.Drawing.Size(514, 216);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader chSearches;
        private System.Windows.Forms.ColumnHeader chBestPrice;
        private System.Windows.Forms.ColumnHeader chNewResults;
        private System.Windows.Forms.ColumnHeader chTotalResults;
    }
}

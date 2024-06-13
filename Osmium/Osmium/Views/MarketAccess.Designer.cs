namespace Osmium.Views
{
    partial class MarketAccess
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
            this.btn_Refesh = new System.Windows.Forms.Button();
            this.textBox_Test = new System.Windows.Forms.TextBox();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.btn_MarketStatus = new System.Windows.Forms.Button();
            this.btn_GetQuote = new System.Windows.Forms.Button();
            this.btn_NewsFeed = new System.Windows.Forms.Button();
            this.btn_Economy = new System.Windows.Forms.Button();
            this.btn_Fundamentals = new System.Windows.Forms.Button();
            this.btn_TimeSeries = new System.Windows.Forms.Button();
            this.panel_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Refesh
            // 
            this.btn_Refesh.Location = new System.Drawing.Point(399, 12);
            this.btn_Refesh.Name = "btn_Refesh";
            this.btn_Refesh.Size = new System.Drawing.Size(188, 69);
            this.btn_Refesh.TabIndex = 0;
            this.btn_Refesh.Text = "Refresh";
            this.btn_Refesh.UseVisualStyleBackColor = true;
            this.btn_Refesh.Click += new System.EventHandler(this.btn_Refesh_Click);
            // 
            // textBox_Test
            // 
            this.textBox_Test.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox_Test.ForeColor = System.Drawing.Color.White;
            this.textBox_Test.Location = new System.Drawing.Point(399, 98);
            this.textBox_Test.Multiline = true;
            this.textBox_Test.Name = "textBox_Test";
            this.textBox_Test.Size = new System.Drawing.Size(1169, 603);
            this.textBox_Test.TabIndex = 1;
            this.textBox_Test.TextChanged += new System.EventHandler(this.textBox_Test_TextChanged);
            // 
            // panel_Menu
            // 
            this.panel_Menu.Controls.Add(this.btn_TimeSeries);
            this.panel_Menu.Controls.Add(this.btn_Fundamentals);
            this.panel_Menu.Controls.Add(this.btn_Economy);
            this.panel_Menu.Controls.Add(this.btn_NewsFeed);
            this.panel_Menu.Controls.Add(this.btn_GetQuote);
            this.panel_Menu.Controls.Add(this.btn_MarketStatus);
            this.panel_Menu.Controls.Add(this.panel_logo);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(376, 1117);
            this.panel_Menu.TabIndex = 2;
            // 
            // panel_logo
            // 
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(376, 161);
            this.panel_logo.TabIndex = 0;
            // 
            // btn_MarketStatus
            // 
            this.btn_MarketStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_MarketStatus.Location = new System.Drawing.Point(0, 161);
            this.btn_MarketStatus.Name = "btn_MarketStatus";
            this.btn_MarketStatus.Size = new System.Drawing.Size(376, 87);
            this.btn_MarketStatus.TabIndex = 1;
            this.btn_MarketStatus.Text = "Market Status";
            this.btn_MarketStatus.UseVisualStyleBackColor = true;
            // 
            // btn_GetQuote
            // 
            this.btn_GetQuote.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_GetQuote.Location = new System.Drawing.Point(0, 248);
            this.btn_GetQuote.Name = "btn_GetQuote";
            this.btn_GetQuote.Size = new System.Drawing.Size(376, 87);
            this.btn_GetQuote.TabIndex = 2;
            this.btn_GetQuote.Text = "Get Quote";
            this.btn_GetQuote.UseVisualStyleBackColor = true;
            // 
            // btn_NewsFeed
            // 
            this.btn_NewsFeed.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_NewsFeed.Location = new System.Drawing.Point(0, 335);
            this.btn_NewsFeed.Name = "btn_NewsFeed";
            this.btn_NewsFeed.Size = new System.Drawing.Size(376, 87);
            this.btn_NewsFeed.TabIndex = 3;
            this.btn_NewsFeed.Text = "News Feed";
            this.btn_NewsFeed.UseVisualStyleBackColor = true;
            // 
            // btn_Economy
            // 
            this.btn_Economy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Economy.Location = new System.Drawing.Point(0, 422);
            this.btn_Economy.Name = "btn_Economy";
            this.btn_Economy.Size = new System.Drawing.Size(376, 87);
            this.btn_Economy.TabIndex = 4;
            this.btn_Economy.Text = "Economy";
            this.btn_Economy.UseVisualStyleBackColor = true;
            // 
            // btn_Fundamentals
            // 
            this.btn_Fundamentals.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Fundamentals.Location = new System.Drawing.Point(0, 509);
            this.btn_Fundamentals.Name = "btn_Fundamentals";
            this.btn_Fundamentals.Size = new System.Drawing.Size(376, 87);
            this.btn_Fundamentals.TabIndex = 5;
            this.btn_Fundamentals.Text = "Fundamentals";
            this.btn_Fundamentals.UseVisualStyleBackColor = true;
            // 
            // btn_TimeSeries
            // 
            this.btn_TimeSeries.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_TimeSeries.Location = new System.Drawing.Point(0, 596);
            this.btn_TimeSeries.Name = "btn_TimeSeries";
            this.btn_TimeSeries.Size = new System.Drawing.Size(376, 87);
            this.btn_TimeSeries.TabIndex = 6;
            this.btn_TimeSeries.Text = "Time Series";
            this.btn_TimeSeries.UseVisualStyleBackColor = true;
            // 
            // MarketAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(2002, 1117);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.textBox_Test);
            this.Controls.Add(this.btn_Refesh);
            this.Name = "MarketAccess";
            this.Text = "Market Access";
            this.Load += new System.EventHandler(this.MarketAccess_Load);
            this.panel_Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Refesh;
        private TextBox textBox_Test;
        private Panel panel_Menu;
        private Button btn_TimeSeries;
        private Button btn_Fundamentals;
        private Button btn_Economy;
        private Button btn_NewsFeed;
        private Button btn_GetQuote;
        private Button btn_MarketStatus;
        private Panel panel_logo;
    }
}
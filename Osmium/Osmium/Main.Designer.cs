namespace Osmium
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.btn_MarketAccess = new System.Windows.Forms.Button();
            this.btn_Development = new System.Windows.Forms.Button();
            this.btn_KeyManager = new System.Windows.Forms.Button();
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.label_Logo = new System.Windows.Forms.Label();
            this.btn_Trading = new System.Windows.Forms.Button();
            this.panel_Menu.SuspendLayout();
            this.panel_Logo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel_Menu.Controls.Add(this.btn_Development);
            this.panel_Menu.Controls.Add(this.btn_KeyManager);
            this.panel_Menu.Controls.Add(this.btn_Trading);
            this.panel_Menu.Controls.Add(this.btn_MarketAccess);
            this.panel_Menu.Controls.Add(this.panel_Logo);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(465, 1126);
            this.panel_Menu.TabIndex = 0;
            // 
            // btn_MarketAccess
            // 
            this.btn_MarketAccess.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_MarketAccess.Location = new System.Drawing.Point(0, 158);
            this.btn_MarketAccess.Name = "btn_MarketAccess";
            this.btn_MarketAccess.Size = new System.Drawing.Size(465, 81);
            this.btn_MarketAccess.TabIndex = 3;
            this.btn_MarketAccess.Text = "Market Access";
            this.btn_MarketAccess.UseVisualStyleBackColor = true;
            this.btn_MarketAccess.Click += new System.EventHandler(this.btn_MarketAccess_Click);
            // 
            // btn_Development
            // 
            this.btn_Development.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Development.Location = new System.Drawing.Point(0, 401);
            this.btn_Development.Name = "btn_Development";
            this.btn_Development.Size = new System.Drawing.Size(465, 81);
            this.btn_Development.TabIndex = 2;
            this.btn_Development.Text = "Development";
            this.btn_Development.UseVisualStyleBackColor = true;
            this.btn_Development.Click += new System.EventHandler(this.btn_Development_Click);
            // 
            // btn_KeyManager
            // 
            this.btn_KeyManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_KeyManager.Location = new System.Drawing.Point(0, 320);
            this.btn_KeyManager.Name = "btn_KeyManager";
            this.btn_KeyManager.Size = new System.Drawing.Size(465, 81);
            this.btn_KeyManager.TabIndex = 1;
            this.btn_KeyManager.Text = "Key Manager";
            this.btn_KeyManager.UseVisualStyleBackColor = true;
            // 
            // panel_Logo
            // 
            this.panel_Logo.Controls.Add(this.label_Logo);
            this.panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.Size = new System.Drawing.Size(465, 158);
            this.panel_Logo.TabIndex = 0;
            // 
            // label_Logo
            // 
            this.label_Logo.AutoSize = true;
            this.label_Logo.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Logo.ForeColor = System.Drawing.Color.White;
            this.label_Logo.Location = new System.Drawing.Point(123, 48);
            this.label_Logo.Name = "label_Logo";
            this.label_Logo.Size = new System.Drawing.Size(200, 62);
            this.label_Logo.TabIndex = 0;
            this.label_Logo.Text = "Osmium";
            // 
            // btn_Trading
            // 
            this.btn_Trading.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Trading.Location = new System.Drawing.Point(0, 239);
            this.btn_Trading.Name = "btn_Trading";
            this.btn_Trading.Size = new System.Drawing.Size(465, 81);
            this.btn_Trading.TabIndex = 4;
            this.btn_Trading.Text = "Trading";
            this.btn_Trading.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(2284, 1126);
            this.Controls.Add(this.panel_Menu);
            this.Name = "Main";
            this.Text = "Osmium";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel_Menu.ResumeLayout(false);
            this.panel_Logo.ResumeLayout(false);
            this.panel_Logo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_Menu;
        private Button btn_Development;
        private Button btn_KeyManager;
        private Panel panel_Logo;
        private Label label_Logo;
        private Button btn_MarketAccess;
        private Button btn_Trading;
    }
}
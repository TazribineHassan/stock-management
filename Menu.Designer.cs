namespace stock_management
{
    partial class Menu
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.other_btn = new FontAwesome.Sharp.IconButton();
            this.suivi_btn = new FontAwesome.Sharp.IconButton();
            this.vente_btn = new FontAwesome.Sharp.IconButton();
            this.stock_btn = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.other_btn);
            this.mainPanel.Controls.Add(this.suivi_btn);
            this.mainPanel.Controls.Add(this.vente_btn);
            this.mainPanel.Controls.Add(this.stock_btn);
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(934, 511);
            this.mainPanel.TabIndex = 0;
            // 
            // other_btn
            // 
            this.other_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.other_btn.BackColor = System.Drawing.Color.Silver;
            this.other_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.other_btn.FlatAppearance.BorderSize = 0;
            this.other_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.other_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.other_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.other_btn.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.other_btn.IconColor = System.Drawing.SystemColors.Control;
            this.other_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.other_btn.IconSize = 60;
            this.other_btn.Location = new System.Drawing.Point(476, 262);
            this.other_btn.Name = "other_btn";
            this.other_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.other_btn.Size = new System.Drawing.Size(200, 90);
            this.other_btn.TabIndex = 9;
            this.other_btn.Text = "Autres";
            this.other_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.other_btn.UseVisualStyleBackColor = false;
            // 
            // suivi_btn
            // 
            this.suivi_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.suivi_btn.BackColor = System.Drawing.Color.Firebrick;
            this.suivi_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.suivi_btn.FlatAppearance.BorderSize = 0;
            this.suivi_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.suivi_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.suivi_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.suivi_btn.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.suivi_btn.IconColor = System.Drawing.SystemColors.Control;
            this.suivi_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.suivi_btn.IconSize = 60;
            this.suivi_btn.Location = new System.Drawing.Point(236, 262);
            this.suivi_btn.Name = "suivi_btn";
            this.suivi_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.suivi_btn.Size = new System.Drawing.Size(200, 90);
            this.suivi_btn.TabIndex = 8;
            this.suivi_btn.Text = "Suivi Journalier";
            this.suivi_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.suivi_btn.UseVisualStyleBackColor = false;
            this.suivi_btn.Click += new System.EventHandler(this.suivi_btn_Click);
            // 
            // vente_btn
            // 
            this.vente_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vente_btn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.vente_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vente_btn.FlatAppearance.BorderSize = 0;
            this.vente_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.vente_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vente_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.vente_btn.IconChar = FontAwesome.Sharp.IconChar.MoneyBillWave;
            this.vente_btn.IconColor = System.Drawing.SystemColors.Control;
            this.vente_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.vente_btn.IconSize = 60;
            this.vente_btn.Location = new System.Drawing.Point(476, 139);
            this.vente_btn.Name = "vente_btn";
            this.vente_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.vente_btn.Size = new System.Drawing.Size(200, 90);
            this.vente_btn.TabIndex = 7;
            this.vente_btn.Text = "Ventes";
            this.vente_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.vente_btn.UseVisualStyleBackColor = false;
            this.vente_btn.Click += new System.EventHandler(this.vente_btn_Click);
            // 
            // stock_btn
            // 
            this.stock_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stock_btn.BackColor = System.Drawing.Color.DarkSalmon;
            this.stock_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stock_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stock_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stock_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.stock_btn.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.stock_btn.IconColor = System.Drawing.SystemColors.Control;
            this.stock_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.stock_btn.IconSize = 60;
            this.stock_btn.Location = new System.Drawing.Point(236, 139);
            this.stock_btn.Name = "stock_btn";
            this.stock_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stock_btn.Size = new System.Drawing.Size(200, 90);
            this.stock_btn.TabIndex = 6;
            this.stock_btn.Text = "Stock";
            this.stock_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.stock_btn.UseVisualStyleBackColor = false;
            this.stock_btn.Click += new System.EventHandler(this.stock_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::stock_management.Properties.Resources.istockphoto_1146532466_612x612;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(934, 511);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.mainPanel);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion De Stock";
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel mainPanel;
        private FontAwesome.Sharp.IconButton other_btn;
        private FontAwesome.Sharp.IconButton suivi_btn;
        private FontAwesome.Sharp.IconButton vente_btn;
        private FontAwesome.Sharp.IconButton stock_btn;
        private PictureBox pictureBox1;
    }
}
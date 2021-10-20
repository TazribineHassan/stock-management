namespace stock_management.Pages
{
    partial class Stock
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.second = new System.Windows.Forms.Label();
            this.goBack = new FontAwesome.Sharp.IconButton();
            this.time = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.day = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stockpanel = new System.Windows.Forms.Panel();
            this.reload_btn = new FontAwesome.Sharp.IconButton();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.search = new FontAwesome.Sharp.IconButton();
            this.delete = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cancel_btn = new FontAwesome.Sharp.IconButton();
            this.add_btn = new FontAwesome.Sharp.IconButton();
            this.qntBox = new System.Windows.Forms.NumericUpDown();
            this.priceBox = new System.Windows.Forms.NumericUpDown();
            this.nomBox2 = new System.Windows.Forms.TextBox();
            this.refBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.stockpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qntBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.second);
            this.panel1.Controls.Add(this.goBack);
            this.panel1.Controls.Add(this.time);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.day);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 100);
            this.panel1.TabIndex = 0;
            // 
            // second
            // 
            this.second.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.second.AutoSize = true;
            this.second.BackColor = System.Drawing.Color.Transparent;
            this.second.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.second.ForeColor = System.Drawing.Color.Black;
            this.second.Location = new System.Drawing.Point(1058, 42);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(0, 19);
            this.second.TabIndex = 8;
            // 
            // goBack
            // 
            this.goBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goBack.FlatAppearance.BorderSize = 0;
            this.goBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBack.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.goBack.IconColor = System.Drawing.Color.MidnightBlue;
            this.goBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goBack.IconSize = 55;
            this.goBack.Location = new System.Drawing.Point(15, 25);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(79, 55);
            this.goBack.TabIndex = 2;
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // time
            // 
            this.time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.time.ForeColor = System.Drawing.Color.Black;
            this.time.Location = new System.Drawing.Point(1003, 38);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 24);
            this.time.TabIndex = 7;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox1.BackColor = System.Drawing.Color.DarkSalmon;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 55;
            this.iconPictureBox1.Location = new System.Drawing.Point(449, 22);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(70, 55);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            // 
            // day
            // 
            this.day.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day.AutoSize = true;
            this.day.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.day.ForeColor = System.Drawing.Color.Black;
            this.day.Location = new System.Drawing.Point(802, 41);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(0, 22);
            this.day.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(525, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock";
            // 
            // stockpanel
            // 
            this.stockpanel.Controls.Add(this.reload_btn);
            this.stockpanel.Controls.Add(this.searchInput);
            this.stockpanel.Controls.Add(this.search);
            this.stockpanel.Controls.Add(this.delete);
            this.stockpanel.Controls.Add(this.label10);
            this.stockpanel.Controls.Add(this.dataGridView1);
            this.stockpanel.Controls.Add(this.cancel_btn);
            this.stockpanel.Controls.Add(this.add_btn);
            this.stockpanel.Controls.Add(this.qntBox);
            this.stockpanel.Controls.Add(this.priceBox);
            this.stockpanel.Controls.Add(this.nomBox2);
            this.stockpanel.Controls.Add(this.refBox);
            this.stockpanel.Controls.Add(this.label9);
            this.stockpanel.Controls.Add(this.label8);
            this.stockpanel.Controls.Add(this.label7);
            this.stockpanel.Controls.Add(this.label6);
            this.stockpanel.Controls.Add(this.label5);
            this.stockpanel.Controls.Add(this.label4);
            this.stockpanel.Controls.Add(this.label3);
            this.stockpanel.Controls.Add(this.label2);
            this.stockpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockpanel.ForeColor = System.Drawing.Color.Black;
            this.stockpanel.Location = new System.Drawing.Point(0, 100);
            this.stockpanel.Name = "stockpanel";
            this.stockpanel.Size = new System.Drawing.Size(1084, 461);
            this.stockpanel.TabIndex = 1;
            // 
            // reload_btn
            // 
            this.reload_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reload_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.reload_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reload_btn.FlatAppearance.BorderSize = 0;
            this.reload_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reload_btn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.reload_btn.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.reload_btn.IconColor = System.Drawing.Color.White;
            this.reload_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.reload_btn.IconSize = 35;
            this.reload_btn.Location = new System.Drawing.Point(876, 85);
            this.reload_btn.Name = "reload_btn";
            this.reload_btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.reload_btn.Size = new System.Drawing.Size(40, 32);
            this.reload_btn.TabIndex = 22;
            this.reload_btn.UseVisualStyleBackColor = false;
            this.reload_btn.Click += new System.EventHandler(this.reload_btn_Click);
            // 
            // searchInput
            // 
            this.searchInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchInput.Location = new System.Drawing.Point(516, 86);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(148, 29);
            this.searchInput.TabIndex = 21;
            // 
            // search
            // 
            this.search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.search.BackColor = System.Drawing.Color.MidnightBlue;
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search.ForeColor = System.Drawing.Color.MidnightBlue;
            this.search.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.search.IconColor = System.Drawing.Color.White;
            this.search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.search.IconSize = 35;
            this.search.Location = new System.Drawing.Point(679, 86);
            this.search.Name = "search";
            this.search.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.search.Size = new System.Drawing.Size(40, 32);
            this.search.TabIndex = 20;
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // delete
            // 
            this.delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delete.BackColor = System.Drawing.Color.Firebrick;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete.ForeColor = System.Drawing.Color.MidnightBlue;
            this.delete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.delete.IconColor = System.Drawing.Color.White;
            this.delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.delete.IconSize = 30;
            this.delete.Location = new System.Drawing.Point(922, 85);
            this.delete.Name = "delete";
            this.delete.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.delete.Size = new System.Drawing.Size(44, 32);
            this.delete.TabIndex = 19;
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(142, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(261, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "Ajouter / Modifier un article";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(516, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(450, 220);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.updateArticle);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancel_btn.BackColor = System.Drawing.Color.Silver;
            this.cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_btn.FlatAppearance.BorderSize = 0;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel_btn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cancel_btn.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.cancel_btn.IconColor = System.Drawing.Color.Orange;
            this.cancel_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cancel_btn.IconSize = 35;
            this.cancel_btn.Location = new System.Drawing.Point(355, 328);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.cancel_btn.Size = new System.Drawing.Size(70, 32);
            this.cancel_btn.TabIndex = 16;
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add_btn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_btn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.add_btn.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.add_btn.IconColor = System.Drawing.Color.White;
            this.add_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.add_btn.IconSize = 35;
            this.add_btn.Location = new System.Drawing.Point(119, 328);
            this.add_btn.Name = "add_btn";
            this.add_btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.add_btn.Size = new System.Drawing.Size(70, 32);
            this.add_btn.TabIndex = 15;
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // qntBox
            // 
            this.qntBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.qntBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.qntBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.qntBox.Location = new System.Drawing.Point(275, 271);
            this.qntBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.qntBox.Name = "qntBox";
            this.qntBox.Size = new System.Drawing.Size(150, 25);
            this.qntBox.TabIndex = 14;
            // 
            // priceBox
            // 
            this.priceBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.priceBox.Location = new System.Drawing.Point(275, 226);
            this.priceBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(150, 23);
            this.priceBox.TabIndex = 13;
            // 
            // nomBox2
            // 
            this.nomBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nomBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nomBox2.Location = new System.Drawing.Point(275, 183);
            this.nomBox2.Name = "nomBox2";
            this.nomBox2.Size = new System.Drawing.Size(150, 25);
            this.nomBox2.TabIndex = 12;
            // 
            // refBox
            // 
            this.refBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.refBox.Location = new System.Drawing.Point(275, 139);
            this.refBox.Name = "refBox";
            this.refBox.Size = new System.Drawing.Size(150, 25);
            this.refBox.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(232, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 21);
            this.label9.TabIndex = 10;
            this.label9.Text = ":";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(232, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = ":";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(232, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = ":";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(232, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(119, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantité";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(119, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Prix ​​unitaire";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(119, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nom";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(119, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Référence";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.stockpanel);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "Stock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.stockpanel.ResumeLayout(false);
            this.stockpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qntBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton goBack;
        private Panel stockpanel;
        private TextBox nomBox2;
        private TextBox refBox;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private NumericUpDown qntBox;
        private NumericUpDown priceBox;
        private FontAwesome.Sharp.IconButton add_btn;
        private FontAwesome.Sharp.IconButton cancel_btn;
        private DataGridView dataGridView1;
        private Label label10;
        private TextBox searchInput;
        private FontAwesome.Sharp.IconButton search;
        private FontAwesome.Sharp.IconButton delete;
        private FontAwesome.Sharp.IconButton reload_btn;
        private Label second;
        private Label time;
        private Label day;
        private System.Windows.Forms.Timer timer;
    }
}
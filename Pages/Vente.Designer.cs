namespace stock_management.Pages
{
    partial class vente
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARTICLE_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ref = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArticleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.prixLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ArticlesComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.reload_btn = new FontAwesome.Sharp.IconButton();
            this.delete = new FontAwesome.Sharp.IconButton();
            this.cancel_btn = new FontAwesome.Sharp.IconButton();
            this.add_btn = new FontAwesome.Sharp.IconButton();
            this.totalLabel = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.disponibleLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
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
            this.second.Location = new System.Drawing.Point(1057, 42);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(0, 19);
            this.second.TabIndex = 59;
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
            this.goBack.Size = new System.Drawing.Size(72, 55);
            this.goBack.TabIndex = 3;
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // time
            // 
            this.time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.time.Location = new System.Drawing.Point(1002, 38);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 24);
            this.time.TabIndex = 58;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MoneyBillWave;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 55;
            this.iconPictureBox1.Location = new System.Drawing.Point(448, 24);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(70, 55);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // day
            // 
            this.day.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day.AutoSize = true;
            this.day.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.day.Location = new System.Drawing.Point(801, 41);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(0, 22);
            this.day.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(524, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ventes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ARTICLE_ID,
            this.DATE,
            this.Ref,
            this.ArticleName,
            this.Price,
            this.Quantity,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(386, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(642, 295);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.updateSell);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // ARTICLE_ID
            // 
            this.ARTICLE_ID.HeaderText = "ARTICLE_ID";
            this.ARTICLE_ID.Name = "ARTICLE_ID";
            this.ARTICLE_ID.ReadOnly = true;
            this.ARTICLE_ID.Visible = false;
            // 
            // DATE
            // 
            this.DATE.HeaderText = "Date";
            this.DATE.Name = "DATE";
            this.DATE.ReadOnly = true;
            // 
            // Ref
            // 
            this.Ref.HeaderText = "Article ref";
            this.Ref.Name = "Ref";
            this.Ref.ReadOnly = true;
            // 
            // ArticleName
            // 
            this.ArticleName.HeaderText = "Article";
            this.ArticleName.Name = "ArticleName";
            this.ArticleName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Prix";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantite";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.disponibleLabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.prixLabel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ArticlesComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(59, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 163);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Article";
            // 
            // prixLabel
            // 
            this.prixLabel.AutoSize = true;
            this.prixLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prixLabel.Location = new System.Drawing.Point(127, 128);
            this.prixLabel.Name = "prixLabel";
            this.prixLabel.Size = new System.Drawing.Size(19, 21);
            this.prixLabel.TabIndex = 7;
            this.prixLabel.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(11, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Prix";
            // 
            // ArticlesComboBox
            // 
            this.ArticlesComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ArticlesComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ArticlesComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ArticlesComboBox.FormattingEnabled = true;
            this.ArticlesComboBox.Location = new System.Drawing.Point(127, 24);
            this.ArticlesComboBox.Name = "ArticlesComboBox";
            this.ArticlesComboBox.Size = new System.Drawing.Size(148, 29);
            this.ArticlesComboBox.TabIndex = 2;
            this.ArticlesComboBox.SelectedValueChanged += new System.EventHandler(this.comboBoxChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Article";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(59, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(266, 23);
            this.label10.TabIndex = 55;
            this.label10.Text = "Ajouter / Modifier une vente";
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
            this.reload_btn.Location = new System.Drawing.Point(938, 172);
            this.reload_btn.Name = "reload_btn";
            this.reload_btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.reload_btn.Size = new System.Drawing.Size(40, 32);
            this.reload_btn.TabIndex = 54;
            this.reload_btn.UseVisualStyleBackColor = false;
            this.reload_btn.Click += new System.EventHandler(this.refreshButtonClicked);
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
            this.delete.Location = new System.Drawing.Point(984, 172);
            this.delete.Name = "delete";
            this.delete.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.delete.Size = new System.Drawing.Size(44, 32);
            this.delete.TabIndex = 51;
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.deleteButtonClicked);
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
            this.cancel_btn.Location = new System.Drawing.Point(261, 510);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.cancel_btn.Size = new System.Drawing.Size(70, 32);
            this.cancel_btn.TabIndex = 50;
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.resetButtonClicked);
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
            this.add_btn.Location = new System.Drawing.Point(70, 510);
            this.add_btn.Name = "add_btn";
            this.add_btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.add_btn.Size = new System.Drawing.Size(70, 32);
            this.add_btn.TabIndex = 49;
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.addButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.totalLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalLabel.Location = new System.Drawing.Point(186, 454);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(19, 21);
            this.totalLabel.TabIndex = 48;
            this.totalLabel.Text = "0";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuantityTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuantityTextBox.Location = new System.Drawing.Point(186, 395);
            this.QuantityTextBox.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(148, 27);
            this.QuantityTextBox.TabIndex = 47;
            this.QuantityTextBox.ValueChanged += new System.EventHandler(this.QuantityTextBoxChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(70, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 21);
            this.label4.TabIndex = 46;
            this.label4.Text = "Total";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(70, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 45;
            this.label3.Text = "Quantite";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // disponibleLabel
            // 
            this.disponibleLabel.AutoSize = true;
            this.disponibleLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.disponibleLabel.Location = new System.Drawing.Point(127, 78);
            this.disponibleLabel.Name = "disponibleLabel";
            this.disponibleLabel.Size = new System.Drawing.Size(19, 21);
            this.disponibleLabel.TabIndex = 9;
            this.disponibleLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(11, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Disponible";
            // 
            // vente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 606);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.reload_btn);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "vente";
            this.Text = "Vente";
            this.Load += new System.EventHandler(this.Vente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton goBack;
        private GroupBox groupBox1;
        private Label prixLabel;
        private Label label7;
        private ComboBox ArticlesComboBox;
        private Label label2;
        private Label label10;
        private FontAwesome.Sharp.IconButton reload_btn;
        private FontAwesome.Sharp.IconButton delete;
        private FontAwesome.Sharp.IconButton cancel_btn;
        private FontAwesome.Sharp.IconButton add_btn;
        private Label totalLabel;
        private NumericUpDown QuantityTextBox;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ARTICLE_ID;
        private DataGridViewTextBoxColumn DATE;
        private DataGridViewTextBoxColumn Ref;
        private DataGridViewTextBoxColumn ArticleName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Total;
        private Label second;
        private Label time;
        private Label day;
        private System.Windows.Forms.Timer timer;
        private Label disponibleLabel;
        private Label label6;
    }
}
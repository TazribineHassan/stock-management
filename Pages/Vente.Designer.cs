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
            this.panel1 = new System.Windows.Forms.Panel();
            this.goBack = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
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
            this.disponibleLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ArticlesComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.reload_btn = new FontAwesome.Sharp.IconButton();
            this.delete = new FontAwesome.Sharp.IconButton();
            this.cancel_btn = new FontAwesome.Sharp.IconButton();
            this.add_btn = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.prixLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.disponibleLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARTICLE_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ref = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArticleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.goBack);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 100);
            this.panel1.TabIndex = 0;
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
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.prixLabel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.disponibleLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ArticlesComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(59, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 149);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Article";
            // 
            // prixLabel
            // 
            this.prixLabel.AutoSize = true;
            this.prixLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prixLabel.Location = new System.Drawing.Point(127, 111);
            this.prixLabel.Name = "prixLabel";
            this.prixLabel.Size = new System.Drawing.Size(19, 21);
            this.prixLabel.TabIndex = 7;
            this.prixLabel.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(11, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Prix";
            // 
            // disponibleLabel
            // 
            this.disponibleLabel.AutoSize = true;
            this.disponibleLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.disponibleLabel.Location = new System.Drawing.Point(127, 76);
            this.disponibleLabel.Name = "disponibleLabel";
            this.disponibleLabel.Size = new System.Drawing.Size(19, 21);
            this.disponibleLabel.TabIndex = 5;
            this.disponibleLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(11, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Disponible";
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
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(46, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantite";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(46, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuantityTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuantityTextBox.Location = new System.Drawing.Point(162, 358);
            this.QuantityTextBox.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(148, 27);
            this.QuantityTextBox.TabIndex = 9;
            this.QuantityTextBox.ValueChanged += new System.EventHandler(this.QuantityTextBoxChanged);
            // 
            // totalLabel
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(59, 149);
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
            this.reload_btn.Location = new System.Drawing.Point(938, 149);
            this.reload_btn.Name = "reload_btn";
            this.reload_btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.reload_btn.Size = new System.Drawing.Size(40, 32);
            this.reload_btn.TabIndex = 54;
            this.reload_btn.UseVisualStyleBackColor = false;
            this.reload_btn.Click += new System.EventHandler(this.reload_btn_Click);
            // 
            // searchInput
            // 
            this.searchInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchInput.Location = new System.Drawing.Point(386, 149);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(148, 29);
            this.searchInput.TabIndex = 53;
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
            this.search.Location = new System.Drawing.Point(540, 148);
            this.search.Name = "search";
            this.search.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.search.Size = new System.Drawing.Size(40, 32);
            this.search.TabIndex = 52;
            this.search.UseVisualStyleBackColor = false;
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
            this.delete.Location = new System.Drawing.Point(984, 149);
            this.delete.Name = "delete";
            this.delete.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.delete.Size = new System.Drawing.Size(44, 32);
            this.delete.TabIndex = 51;
            this.delete.UseVisualStyleBackColor = false;
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
            this.cancel_btn.Location = new System.Drawing.Point(261, 493);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.cancel_btn.Size = new System.Drawing.Size(70, 32);
            this.cancel_btn.TabIndex = 50;
            this.cancel_btn.UseVisualStyleBackColor = false;
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
            this.add_btn.Location = new System.Drawing.Point(70, 493);
            this.add_btn.Name = "add_btn";
            this.add_btn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.add_btn.Size = new System.Drawing.Size(70, 32);
            this.add_btn.TabIndex = 49;
            this.add_btn.UseVisualStyleBackColor = false;
            // 
            // totalLabel
            // 
            this.totalLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.totalLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalLabel.Location = new System.Drawing.Point(183, 437);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(19, 21);
            this.totalLabel.TabIndex = 48;
            this.totalLabel.Text = "0";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuantityTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuantityTextBox.Location = new System.Drawing.Point(186, 380);
            this.QuantityTextBox.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(148, 27);
            this.QuantityTextBox.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(70, 437);
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
            this.label3.Location = new System.Drawing.Point(70, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 45;
            this.label3.Text = "Quantite";
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
            this.dataGridView1.Location = new System.Drawing.Point(386, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(642, 254);
            this.dataGridView1.TabIndex = 44;
            // 
            // Vente
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
            // vente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private Label disponibleLabel;
        private Label label5;
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
    }
}
namespace stock_management.Pages
{
    partial class Suivi
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
            this.time = new System.Windows.Forms.Label();
            this.day = new System.Windows.Forms.Label();
            this.goBack = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.suiviPanel = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.enddate = new System.Windows.Forms.DateTimePicker();
            this.startdate = new System.Windows.Forms.DateTimePicker();
            this.done = new FontAwesome.Sharp.IconButton();
            this.dataGridViewSuivi = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARTICLE_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ref = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArticleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.suiviPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuivi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.second);
            this.panel1.Controls.Add(this.time);
            this.panel1.Controls.Add(this.day);
            this.panel1.Controls.Add(this.goBack);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 100);
            this.panel1.TabIndex = 0;
            // 
            // second
            // 
            this.second.AutoSize = true;
            this.second.BackColor = System.Drawing.Color.Transparent;
            this.second.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.second.Location = new System.Drawing.Point(1047, 43);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(0, 19);
            this.second.TabIndex = 5;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.time.Location = new System.Drawing.Point(992, 39);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 24);
            this.time.TabIndex = 4;
            // 
            // day
            // 
            this.day.AutoSize = true;
            this.day.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.day.Location = new System.Drawing.Point(791, 42);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(0, 22);
            this.day.TabIndex = 3;
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
            this.goBack.Location = new System.Drawing.Point(12, 25);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(75, 53);
            this.goBack.TabIndex = 2;
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox1.BackColor = System.Drawing.Color.Firebrick;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 51;
            this.iconPictureBox1.Location = new System.Drawing.Point(431, 27);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(59, 51);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(496, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suivi Journalier";
            // 
            // suiviPanel
            // 
            this.suiviPanel.Controls.Add(this.iconButton1);
            this.suiviPanel.Controls.Add(this.label5);
            this.suiviPanel.Controls.Add(this.label4);
            this.suiviPanel.Controls.Add(this.label3);
            this.suiviPanel.Controls.Add(this.label2);
            this.suiviPanel.Controls.Add(this.enddate);
            this.suiviPanel.Controls.Add(this.startdate);
            this.suiviPanel.Controls.Add(this.done);
            this.suiviPanel.Controls.Add(this.dataGridViewSuivi);
            this.suiviPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suiviPanel.Location = new System.Drawing.Point(0, 100);
            this.suiviPanel.Name = "suiviPanel";
            this.suiviPanel.Size = new System.Drawing.Size(1084, 461);
            this.suiviPanel.TabIndex = 1;
            this.suiviPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.suiviPanel_Paint);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton1.BackColor = System.Drawing.Color.MidnightBlue;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.Location = new System.Drawing.Point(817, 76);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(1, 5, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(40, 40);
            this.iconButton1.TabIndex = 19;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(506, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = ":";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(300, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = ":";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(438, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Jusqu\'à";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(215, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "A partir de";
            // 
            // enddate
            // 
            this.enddate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enddate.CustomFormat = "dd-MM-yyyy";
            this.enddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.enddate.Location = new System.Drawing.Point(527, 83);
            this.enddate.MinDate = new System.DateTime(2000, 2, 1, 0, 0, 0, 0);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(100, 23);
            this.enddate.TabIndex = 14;
            // 
            // startdate
            // 
            this.startdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startdate.CustomFormat = "dd-MM-yyyy";
            this.startdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startdate.Location = new System.Drawing.Point(319, 83);
            this.startdate.MinDate = new System.DateTime(2000, 2, 1, 0, 0, 0, 0);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(100, 23);
            this.startdate.TabIndex = 13;
            // 
            // done
            // 
            this.done.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.done.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.done.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.done.FlatAppearance.BorderSize = 0;
            this.done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.done.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.done.IconColor = System.Drawing.Color.White;
            this.done.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.done.IconSize = 35;
            this.done.Location = new System.Drawing.Point(647, 76);
            this.done.Name = "done";
            this.done.Padding = new System.Windows.Forms.Padding(1, 5, 0, 0);
            this.done.Size = new System.Drawing.Size(40, 40);
            this.done.TabIndex = 12;
            this.done.UseVisualStyleBackColor = false;
            this.done.Click += new System.EventHandler(this.done_Click_1);
            // 
            // dataGridViewSuivi
            // 
            this.dataGridViewSuivi.AllowUserToAddRows = false;
            this.dataGridViewSuivi.AllowUserToDeleteRows = false;
            this.dataGridViewSuivi.AllowUserToOrderColumns = true;
            this.dataGridViewSuivi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewSuivi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSuivi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ARTICLE_ID,
            this.DATE,
            this.Ref,
            this.ArticleName,
            this.Price,
            this.Quantity,
            this.Total});
            this.dataGridViewSuivi.Location = new System.Drawing.Point(213, 133);
            this.dataGridViewSuivi.Name = "dataGridViewSuivi";
            this.dataGridViewSuivi.ReadOnly = true;
            this.dataGridViewSuivi.RowTemplate.Height = 25;
            this.dataGridViewSuivi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSuivi.Size = new System.Drawing.Size(644, 254);
            this.dataGridViewSuivi.TabIndex = 11;
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
            this.Ref.HeaderText = "Référence";
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
            this.Quantity.HeaderText = "Quantité";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Suivi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.suiviPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Suivi";
            this.Text = "Suivi";
            this.Load += new System.EventHandler(this.Suivi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.suiviPanel.ResumeLayout(false);
            this.suiviPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuivi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton goBack;
        private LiveCharts.WinForms.CartesianChart cartesianChart;
        private Panel suiviPanel;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker enddate;
        private DateTimePicker startdate;
        private FontAwesome.Sharp.IconButton done;
        private DataGridView dataGridViewSuivi;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ARTICLE_ID;
        private DataGridViewTextBoxColumn DATE;
        private DataGridViewTextBoxColumn Ref;
        private DataGridViewTextBoxColumn ArticleName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Total;
        private Label time;
        private Label day;
        private System.Windows.Forms.Timer timer;
        private Label second;
    }
}
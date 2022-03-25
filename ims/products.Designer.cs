namespace ims
{
    partial class products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.modelNoErrorLabel = new System.Windows.Forms.Label();
            this.modelNoTxt = new System.Windows.Forms.Label();
            this.proModelNoTxtBox = new System.Windows.Forms.TextBox();
            this.pNameErrorLabel = new System.Windows.Forms.Label();
            this.pnameLabel = new System.Windows.Forms.Label();
            this.pNameTxtBox = new System.Windows.Forms.TextBox();
            this.pCatErrorLabel = new System.Windows.Forms.Label();
            this.pCategoryLabel = new System.Windows.Forms.Label();
            this.pDateErrorLabel = new System.Windows.Forms.Label();
            this.pDateLabel = new System.Windows.Forms.Label();
            this.purDatePicker = new System.Windows.Forms.DateTimePicker();
            this.pCatCBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prdtIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prdtCatIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prdtCatGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prdtNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prdtModelNoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prdtDateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.leftTopPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.rightTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            // 
            // searchBox
            // 
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged_1);
            // 
            // gvPanel
            // 
            this.gvPanel.Controls.Add(this.dataGridView1);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.pCatCBox);
            this.leftPanel.Controls.Add(this.purDatePicker);
            this.leftPanel.Controls.Add(this.pDateLabel);
            this.leftPanel.Controls.Add(this.pCategoryLabel);
            this.leftPanel.Controls.Add(this.pNameTxtBox);
            this.leftPanel.Controls.Add(this.pnameLabel);
            this.leftPanel.Controls.Add(this.proModelNoTxtBox);
            this.leftPanel.Controls.Add(this.modelNoTxt);
            this.leftPanel.Controls.Add(this.pDateErrorLabel);
            this.leftPanel.Controls.Add(this.pCatErrorLabel);
            this.leftPanel.Controls.Add(this.pNameErrorLabel);
            this.leftPanel.Controls.Add(this.modelNoErrorLabel);
            this.leftPanel.Controls.SetChildIndex(this.modelNoErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.pNameErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.pCatErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.pDateErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.modelNoTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.proModelNoTxtBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.pnameLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.pNameTxtBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.pCategoryLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.pDateLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.leftTopPanel, 0);
            this.leftPanel.Controls.SetChildIndex(this.purDatePicker, 0);
            this.leftPanel.Controls.SetChildIndex(this.pCatCBox, 0);
            // 
            // topRightLabel
            // 
            this.topRightLabel.Text = "Products";
            // 
            // modelNoErrorLabel
            // 
            this.modelNoErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modelNoErrorLabel.AutoSize = true;
            this.modelNoErrorLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelNoErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.modelNoErrorLabel.Location = new System.Drawing.Point(151, 293);
            this.modelNoErrorLabel.Name = "modelNoErrorLabel";
            this.modelNoErrorLabel.Size = new System.Drawing.Size(26, 32);
            this.modelNoErrorLabel.TabIndex = 75;
            this.modelNoErrorLabel.Text = "*";
            this.modelNoErrorLabel.Visible = false;
            this.modelNoErrorLabel.Click += new System.EventHandler(this.NameErrorLabel_Click);
            // 
            // modelNoTxt
            // 
            this.modelNoTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modelNoTxt.AutoSize = true;
            this.modelNoTxt.Location = new System.Drawing.Point(12, 299);
            this.modelNoTxt.Name = "modelNoTxt";
            this.modelNoTxt.Size = new System.Drawing.Size(131, 20);
            this.modelNoTxt.TabIndex = 73;
            this.modelNoTxt.Text = "Product Model No";
            this.modelNoTxt.Click += new System.EventHandler(this.label1_Click);
            // 
            // proModelNoTxtBox
            // 
            this.proModelNoTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proModelNoTxtBox.Location = new System.Drawing.Point(14, 324);
            this.proModelNoTxtBox.MaxLength = 50;
            this.proModelNoTxtBox.Name = "proModelNoTxtBox";
            this.proModelNoTxtBox.Size = new System.Drawing.Size(300, 27);
            this.proModelNoTxtBox.TabIndex = 6;
            this.proModelNoTxtBox.TextChanged += new System.EventHandler(this.nameTxtBox_TextChanged);
            // 
            // pNameErrorLabel
            // 
            this.pNameErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pNameErrorLabel.AutoSize = true;
            this.pNameErrorLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pNameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.pNameErrorLabel.Location = new System.Drawing.Point(150, 235);
            this.pNameErrorLabel.Name = "pNameErrorLabel";
            this.pNameErrorLabel.Size = new System.Drawing.Size(26, 32);
            this.pNameErrorLabel.TabIndex = 78;
            this.pNameErrorLabel.Text = "*";
            this.pNameErrorLabel.Visible = false;
            // 
            // pnameLabel
            // 
            this.pnameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnameLabel.AutoSize = true;
            this.pnameLabel.Location = new System.Drawing.Point(11, 239);
            this.pnameLabel.Name = "pnameLabel";
            this.pnameLabel.Size = new System.Drawing.Size(104, 20);
            this.pnameLabel.TabIndex = 76;
            this.pnameLabel.Text = "Product Name";
            // 
            // pNameTxtBox
            // 
            this.pNameTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pNameTxtBox.Location = new System.Drawing.Point(13, 264);
            this.pNameTxtBox.MaxLength = 50;
            this.pNameTxtBox.Name = "pNameTxtBox";
            this.pNameTxtBox.Size = new System.Drawing.Size(300, 27);
            this.pNameTxtBox.TabIndex = 4;
            // 
            // pCatErrorLabel
            // 
            this.pCatErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pCatErrorLabel.AutoSize = true;
            this.pCatErrorLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pCatErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.pCatErrorLabel.Location = new System.Drawing.Point(150, 181);
            this.pCatErrorLabel.Name = "pCatErrorLabel";
            this.pCatErrorLabel.Size = new System.Drawing.Size(26, 32);
            this.pCatErrorLabel.TabIndex = 81;
            this.pCatErrorLabel.Text = "*";
            this.pCatErrorLabel.Visible = false;
            this.pCatErrorLabel.Click += new System.EventHandler(this.pCatErrorLabel_Click);
            // 
            // pCategoryLabel
            // 
            this.pCategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pCategoryLabel.AutoSize = true;
            this.pCategoryLabel.Location = new System.Drawing.Point(11, 183);
            this.pCategoryLabel.Name = "pCategoryLabel";
            this.pCategoryLabel.Size = new System.Drawing.Size(124, 20);
            this.pCategoryLabel.TabIndex = 79;
            this.pCategoryLabel.Text = "Product Category";
            this.pCategoryLabel.Click += new System.EventHandler(this.pCategoryLabel_Click);
            // 
            // pDateErrorLabel
            // 
            this.pDateErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pDateErrorLabel.AutoSize = true;
            this.pDateErrorLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pDateErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.pDateErrorLabel.Location = new System.Drawing.Point(150, 353);
            this.pDateErrorLabel.Name = "pDateErrorLabel";
            this.pDateErrorLabel.Size = new System.Drawing.Size(26, 32);
            this.pDateErrorLabel.TabIndex = 84;
            this.pDateErrorLabel.Text = "*";
            this.pDateErrorLabel.Visible = false;
            // 
            // pDateLabel
            // 
            this.pDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pDateLabel.AutoSize = true;
            this.pDateLabel.Location = new System.Drawing.Point(11, 354);
            this.pDateLabel.Name = "pDateLabel";
            this.pDateLabel.Size = new System.Drawing.Size(110, 20);
            this.pDateLabel.TabIndex = 82;
            this.pDateLabel.Text = "Purcahing Date";
            // 
            // purDatePicker
            // 
            this.purDatePicker.CustomFormat = " dd - MMM - yyyy";
            this.purDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.purDatePicker.Location = new System.Drawing.Point(13, 379);
            this.purDatePicker.Name = "purDatePicker";
            this.purDatePicker.Size = new System.Drawing.Size(300, 27);
            this.purDatePicker.TabIndex = 8;
            // 
            // pCatCBox
            // 
            this.pCatCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pCatCBox.FormattingEnabled = true;
            this.pCatCBox.Location = new System.Drawing.Point(13, 208);
            this.pCatCBox.Name = "pCatCBox";
            this.pCatCBox.Size = new System.Drawing.Size(300, 28);
            this.pCatCBox.TabIndex = 2;
            this.pCatCBox.SelectedIndexChanged += new System.EventHandler(this.pCatCBox_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prdtIDGV,
            this.prdtCatIDGV,
            this.prdtCatGV,
            this.prdtNameGV,
            this.prdtModelNoGV,
            this.prdtDateGV});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(942, 498);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // prdtIDGV
            // 
            this.prdtIDGV.HeaderText = "prdtID";
            this.prdtIDGV.MinimumWidth = 6;
            this.prdtIDGV.Name = "prdtIDGV";
            this.prdtIDGV.ReadOnly = true;
            this.prdtIDGV.Visible = false;
            // 
            // prdtCatIDGV
            // 
            this.prdtCatIDGV.HeaderText = "Product Category ID";
            this.prdtCatIDGV.MinimumWidth = 6;
            this.prdtCatIDGV.Name = "prdtCatIDGV";
            this.prdtCatIDGV.ReadOnly = true;
            this.prdtCatIDGV.Visible = false;
            // 
            // prdtCatGV
            // 
            this.prdtCatGV.HeaderText = "Product Category";
            this.prdtCatGV.MinimumWidth = 6;
            this.prdtCatGV.Name = "prdtCatGV";
            this.prdtCatGV.ReadOnly = true;
            // 
            // prdtNameGV
            // 
            this.prdtNameGV.HeaderText = "Product Name";
            this.prdtNameGV.MinimumWidth = 6;
            this.prdtNameGV.Name = "prdtNameGV";
            this.prdtNameGV.ReadOnly = true;
            // 
            // prdtModelNoGV
            // 
            this.prdtModelNoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prdtModelNoGV.HeaderText = "Product Model No";
            this.prdtModelNoGV.MinimumWidth = 6;
            this.prdtModelNoGV.Name = "prdtModelNoGV";
            this.prdtModelNoGV.ReadOnly = true;
            // 
            // prdtDateGV
            // 
            this.prdtDateGV.HeaderText = "Purchasing Date";
            this.prdtDateGV.MinimumWidth = 6;
            this.prdtDateGV.Name = "prdtDateGV";
            this.prdtDateGV.ReadOnly = true;
            // 
            // products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Name = "products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.products_Load);
            this.gvPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.leftTopPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.rightTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label pDateLabel;
        private System.Windows.Forms.Label pCategoryLabel;
        private System.Windows.Forms.TextBox pNameTxtBox;
        private System.Windows.Forms.Label pnameLabel;
        private System.Windows.Forms.TextBox proModelNoTxtBox;
        private System.Windows.Forms.Label modelNoTxt;
        private System.Windows.Forms.Label pDateErrorLabel;
        private System.Windows.Forms.Label pCatErrorLabel;
        private System.Windows.Forms.Label pNameErrorLabel;
        private System.Windows.Forms.Label modelNoErrorLabel;
        private System.Windows.Forms.DateTimePicker purDatePicker;
        private System.Windows.Forms.ComboBox pCatCBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdtIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdtCatIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdtCatGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdtNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdtModelNoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdtDateGV;
    }
}
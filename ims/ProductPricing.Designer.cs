namespace ims
{
    partial class ProductPricing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pCatCBox = new System.Windows.Forms.ComboBox();
            this.pCategoryLabel = new System.Windows.Forms.Label();
            this.pCatErrorLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.selectGV = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.prodIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyingPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profMarginGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchBox.Size = new System.Drawing.Size(385, 37);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1372, 90);
            // 
            // gvPanel
            // 
            this.gvPanel.Controls.Add(this.dataGridView1);
            this.gvPanel.Size = new System.Drawing.Size(1372, 605);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.pCatCBox);
            this.leftPanel.Controls.Add(this.pCategoryLabel);
            this.leftPanel.Controls.Add(this.pCatErrorLabel);
            this.leftPanel.Size = new System.Drawing.Size(320, 780);
            this.leftPanel.Controls.SetChildIndex(this.leftTopPanel, 0);
            this.leftPanel.Controls.SetChildIndex(this.pCatErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.pCategoryLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.pCatCBox, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(1372, 780);
            // 
            // rightTopPanel
            // 
            this.rightTopPanel.Size = new System.Drawing.Size(1372, 85);
            // 
            // topRightLabel
            // 
            this.topRightLabel.Size = new System.Drawing.Size(1372, 80);
            this.topRightLabel.Text = "Product Pricing";
            // 
            // pCatCBox
            // 
            this.pCatCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pCatCBox.FormattingEnabled = true;
            this.pCatCBox.Location = new System.Drawing.Point(12, 189);
            this.pCatCBox.Name = "pCatCBox";
            this.pCatCBox.Size = new System.Drawing.Size(300, 28);
            this.pCatCBox.TabIndex = 82;
            this.pCatCBox.SelectedIndexChanged += new System.EventHandler(this.pCatCBox_SelectedIndexChanged);
            // 
            // pCategoryLabel
            // 
            this.pCategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pCategoryLabel.AutoSize = true;
            this.pCategoryLabel.Location = new System.Drawing.Point(10, 164);
            this.pCategoryLabel.Name = "pCategoryLabel";
            this.pCategoryLabel.Size = new System.Drawing.Size(124, 20);
            this.pCategoryLabel.TabIndex = 83;
            this.pCategoryLabel.Text = "Product Category";
            // 
            // pCatErrorLabel
            // 
            this.pCatErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pCatErrorLabel.AutoSize = true;
            this.pCatErrorLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pCatErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.pCatErrorLabel.Location = new System.Drawing.Point(149, 162);
            this.pCatErrorLabel.Name = "pCatErrorLabel";
            this.pCatErrorLabel.Size = new System.Drawing.Size(26, 32);
            this.pCatErrorLabel.TabIndex = 84;
            this.pCatErrorLabel.Text = "*";
            this.pCatErrorLabel.Visible = false;
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
            this.selectGV,
            this.prodIDGV,
            this.prodNameGV,
            this.buyingPriceGV,
            this.profMarginGV,
            this.discountGV,
            this.finalPriceGV});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1372, 605);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // selectGV
            // 
            this.selectGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.selectGV.FalseValue = "0";
            this.selectGV.HeaderText = "";
            this.selectGV.MinimumWidth = 6;
            this.selectGV.Name = "selectGV";
            this.selectGV.TrueValue = "1";
            this.selectGV.Width = 6;
            // 
            // prodIDGV
            // 
            this.prodIDGV.HeaderText = "Product ID";
            this.prodIDGV.MinimumWidth = 6;
            this.prodIDGV.Name = "prodIDGV";
            this.prodIDGV.Visible = false;
            // 
            // prodNameGV
            // 
            this.prodNameGV.HeaderText = "Product Name";
            this.prodNameGV.MinimumWidth = 6;
            this.prodNameGV.Name = "prodNameGV";
            // 
            // buyingPriceGV
            // 
            this.buyingPriceGV.HeaderText = "Buying Price";
            this.buyingPriceGV.MinimumWidth = 6;
            this.buyingPriceGV.Name = "buyingPriceGV";
            // 
            // profMarginGV
            // 
            this.profMarginGV.HeaderText = "Profit Margin %";
            this.profMarginGV.MinimumWidth = 6;
            this.profMarginGV.Name = "profMarginGV";
            // 
            // discountGV
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.discountGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.discountGV.HeaderText = "Discount %";
            this.discountGV.MinimumWidth = 6;
            this.discountGV.Name = "discountGV";
            // 
            // finalPriceGV
            // 
            this.finalPriceGV.HeaderText = "Final Selling Price";
            this.finalPriceGV.MinimumWidth = 6;
            this.finalPriceGV.Name = "finalPriceGV";
            // 
            // ProductPricing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1692, 780);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "ProductPricing";
            this.Text = "ProductPricing";
            this.Load += new System.EventHandler(this.ProductPricing_Load);
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

        private System.Windows.Forms.ComboBox pCatCBox;
        private System.Windows.Forms.Label pCategoryLabel;
        private System.Windows.Forms.Label pCatErrorLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyingPriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn profMarginGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalPriceGV;
    }
}
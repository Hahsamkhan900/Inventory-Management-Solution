namespace ims
{
    partial class Stocks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prdtIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prdtNameGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelNoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prdtSellPriveGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avStockGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.searchBox.Size = new System.Drawing.Size(331, 37);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1193, 90);
            // 
            // gvPanel
            // 
            this.gvPanel.Controls.Add(this.dataGridView1);
            this.gvPanel.Size = new System.Drawing.Size(1193, 639);
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(320, 814);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(1193, 814);
            // 
            // rightTopPanel
            // 
            this.rightTopPanel.Size = new System.Drawing.Size(1193, 85);
            // 
            // topRightLabel
            // 
            this.topRightLabel.Size = new System.Drawing.Size(1193, 80);
            this.topRightLabel.Text = "Stock Details";
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
            this.prdtNameGv,
            this.catNameGV,
            this.modelNoGV,
            this.productPriceGV,
            this.prdtSellPriveGV,
            this.avStockGV,
            this.finalGV,
            this.StatusGV});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1193, 639);
            this.dataGridView1.TabIndex = 4;
            // 
            // prdtIDGV
            // 
            this.prdtIDGV.HeaderText = "ProductID";
            this.prdtIDGV.MinimumWidth = 6;
            this.prdtIDGV.Name = "prdtIDGV";
            this.prdtIDGV.ReadOnly = true;
            this.prdtIDGV.Visible = false;
            // 
            // prdtNameGv
            // 
            this.prdtNameGv.HeaderText = "Product Name";
            this.prdtNameGv.MinimumWidth = 6;
            this.prdtNameGv.Name = "prdtNameGv";
            this.prdtNameGv.ReadOnly = true;
            // 
            // catNameGV
            // 
            this.catNameGV.HeaderText = "Category ";
            this.catNameGV.MinimumWidth = 6;
            this.catNameGV.Name = "catNameGV";
            this.catNameGV.ReadOnly = true;
            // 
            // modelNoGV
            // 
            this.modelNoGV.HeaderText = "Model No";
            this.modelNoGV.MinimumWidth = 6;
            this.modelNoGV.Name = "modelNoGV";
            this.modelNoGV.ReadOnly = true;
            // 
            // productPriceGV
            // 
            this.productPriceGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.productPriceGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.productPriceGV.HeaderText = "Product Price";
            this.productPriceGV.MinimumWidth = 6;
            this.productPriceGV.Name = "productPriceGV";
            this.productPriceGV.ReadOnly = true;
            // 
            // prdtSellPriveGV
            // 
            this.prdtSellPriveGV.HeaderText = "Selling Price";
            this.prdtSellPriveGV.MinimumWidth = 6;
            this.prdtSellPriveGV.Name = "prdtSellPriveGV";
            this.prdtSellPriveGV.ReadOnly = true;
            // 
            // avStockGV
            // 
            this.avStockGV.HeaderText = "Available Stock";
            this.avStockGV.MinimumWidth = 6;
            this.avStockGV.Name = "avStockGV";
            this.avStockGV.ReadOnly = true;
            // 
            // finalGV
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.finalGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.finalGV.HeaderText = "Total Stock Amount";
            this.finalGV.MinimumWidth = 6;
            this.finalGV.Name = "finalGV";
            this.finalGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "Status";
            this.StatusGV.MinimumWidth = 6;
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
            // 
            // Stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 814);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "Stocks";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            this.gvPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.leftTopPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.rightTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdtIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdtNameGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn catNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelNoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdtSellPriveGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn avStockGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
    }
}
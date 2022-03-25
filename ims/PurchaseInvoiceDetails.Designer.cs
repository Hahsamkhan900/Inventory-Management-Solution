namespace ims
{
    partial class PurchaseInvoiceDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.purInvSelectDD = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mPIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proQtyGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perUnitPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.GrossTotalLabel = new System.Windows.Forms.Label();
            this.totalAmountLabel = new System.Windows.Forms.Label();
            this.gvPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.leftTopPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.rightTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1183, 90);
            // 
            // gvPanel
            // 
            this.gvPanel.Controls.Add(this.tableLayoutPanel2);
            this.gvPanel.Controls.Add(this.dataGridView1);
            this.gvPanel.Size = new System.Drawing.Size(1183, 611);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.purInvSelectDD);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.datePicker);
            this.leftPanel.Controls.Add(this.label1);
            this.leftPanel.Size = new System.Drawing.Size(320, 786);
            this.leftPanel.Controls.SetChildIndex(this.leftTopPanel, 0);
            this.leftPanel.Controls.SetChildIndex(this.label1, 0);
            this.leftPanel.Controls.SetChildIndex(this.datePicker, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.purInvSelectDD, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(1183, 786);
            // 
            // rightTopPanel
            // 
            this.rightTopPanel.Size = new System.Drawing.Size(1183, 85);
            // 
            // topRightLabel
            // 
            this.topRightLabel.Size = new System.Drawing.Size(1183, 80);
            this.topRightLabel.Text = "View Purchase Invoices";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Date";
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "MMM- yyyy";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(20, 221);
            this.datePicker.Name = "datePicker";
            this.datePicker.ShowUpDown = true;
            this.datePicker.Size = new System.Drawing.Size(270, 27);
            this.datePicker.TabIndex = 2;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Purchase Invoice";
            // 
            // purInvSelectDD
            // 
            this.purInvSelectDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.purInvSelectDD.FormattingEnabled = true;
            this.purInvSelectDD.Location = new System.Drawing.Point(20, 277);
            this.purInvSelectDD.Name = "purInvSelectDD";
            this.purInvSelectDD.Size = new System.Drawing.Size(270, 28);
            this.purInvSelectDD.TabIndex = 4;
            this.purInvSelectDD.SelectedIndexChanged += new System.EventHandler(this.purInvSelectDD_SelectedIndexChanged);
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
            this.mPIDGV,
            this.prodIDGV,
            this.prodNameGV,
            this.proQtyGV,
            this.perUnitPriceGV,
            this.totalGV,
            this.deleteGV});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1183, 564);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // mPIDGV
            // 
            this.mPIDGV.HeaderText = "mainPid";
            this.mPIDGV.MinimumWidth = 6;
            this.mPIDGV.Name = "mPIDGV";
            this.mPIDGV.ReadOnly = true;
            this.mPIDGV.Visible = false;
            // 
            // prodIDGV
            // 
            this.prodIDGV.HeaderText = "Product ID";
            this.prodIDGV.MinimumWidth = 6;
            this.prodIDGV.Name = "prodIDGV";
            this.prodIDGV.ReadOnly = true;
            this.prodIDGV.Visible = false;
            // 
            // prodNameGV
            // 
            this.prodNameGV.HeaderText = "Product Name";
            this.prodNameGV.MinimumWidth = 6;
            this.prodNameGV.Name = "prodNameGV";
            this.prodNameGV.ReadOnly = true;
            // 
            // proQtyGV
            // 
            this.proQtyGV.HeaderText = "Quantity";
            this.proQtyGV.MinimumWidth = 6;
            this.proQtyGV.Name = "proQtyGV";
            this.proQtyGV.ReadOnly = true;
            // 
            // perUnitPriceGV
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.perUnitPriceGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.perUnitPriceGV.HeaderText = "Per Unit Price";
            this.perUnitPriceGV.MinimumWidth = 6;
            this.perUnitPriceGV.Name = "perUnitPriceGV";
            this.perUnitPriceGV.ReadOnly = true;
            // 
            // totalGV
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.totalGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.totalGV.HeaderText = "Total Amount";
            this.totalGV.MinimumWidth = 6;
            this.totalGV.Name = "totalGV";
            this.totalGV.ReadOnly = true;
            // 
            // deleteGV
            // 
            this.deleteGV.HeaderText = "Action";
            this.deleteGV.MinimumWidth = 6;
            this.deleteGV.Name = "deleteGV";
            this.deleteGV.ReadOnly = true;
            this.deleteGV.Text = "Delete";
            this.deleteGV.UseColumnTextForButtonValue = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.40913F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.59087F));
            this.tableLayoutPanel2.Controls.Add(this.GrossTotalLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.totalAmountLabel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 564);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1183, 47);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // GrossTotalLabel
            // 
            this.GrossTotalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrossTotalLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrossTotalLabel.Location = new System.Drawing.Point(623, 0);
            this.GrossTotalLabel.Name = "GrossTotalLabel";
            this.GrossTotalLabel.Size = new System.Drawing.Size(557, 47);
            this.GrossTotalLabel.TabIndex = 142;
            this.GrossTotalLabel.Text = "0.00";
            this.GrossTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalAmountLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountLabel.Location = new System.Drawing.Point(3, 0);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.Size = new System.Drawing.Size(614, 47);
            this.totalAmountLabel.TabIndex = 0;
            this.totalAmountLabel.Text = "Grand Total Amount";
            this.totalAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PurchaseInvoiceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 786);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "PurchaseInvoiceDetails";
            this.Text = "PurchaseInvoiceDetails";
            this.Load += new System.EventHandler(this.PurchaseInvoiceDetails_Load);
            this.gvPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.leftTopPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.rightTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox purInvSelectDD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label GrossTotalLabel;
        private System.Windows.Forms.Label totalAmountLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn mPIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn proQtyGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn perUnitPriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalGV;
        private System.Windows.Forms.DataGridViewButtonColumn deleteGV;
    }
}
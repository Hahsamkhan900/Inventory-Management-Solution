namespace ims
{
    partial class ViewSalesInvoices
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.totalRichTextBox = new System.Windows.Forms.RichTextBox();
            this.saleIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.givenAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountReturnGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDiscountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userrIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.leftTopPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.rightTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.totalRichTextBox);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.loadButton);
            this.leftPanel.Controls.Add(this.label1);
            this.leftPanel.Controls.Add(this.dateTimePicker1);
            this.leftPanel.Size = new System.Drawing.Size(320, 755);
            this.leftPanel.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.leftPanel.Controls.SetChildIndex(this.label1, 0);
            this.leftPanel.Controls.SetChildIndex(this.loadButton, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.totalRichTextBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.leftTopPanel, 0);
            // 
            // leftTopPanel
            // 
            this.leftTopPanel.Controls.Add(this.backBtn);
            this.leftTopPanel.Controls.SetChildIndex(this.topLeftLabel, 0);
            this.leftTopPanel.Controls.SetChildIndex(this.backBtn, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.BackgroundImage = null;
            this.rightPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(939, 755);
            this.rightPanel.Controls.SetChildIndex(this.rightTopPanel, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // rightTopPanel
            // 
            this.rightTopPanel.Size = new System.Drawing.Size(939, 111);
            // 
            // topLeftLabel
            // 
            this.topLeftLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.topLeftLabel.Location = new System.Drawing.Point(66, 0);
            this.topLeftLabel.Size = new System.Drawing.Size(254, 111);
            this.topLeftLabel.Text = "Sale Invoice";
            // 
            // topRightLabel
            // 
            this.topRightLabel.Size = new System.Drawing.Size(939, 111);
            this.topRightLabel.Text = "Daily Sales Invoices Details";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd - MMM - yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 187);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(293, 27);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Date : ";
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.loadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.ForeColor = System.Drawing.Color.White;
            this.loadButton.Location = new System.Drawing.Point(14, 234);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(293, 71);
            this.loadButton.TabIndex = 5;
            this.loadButton.Text = "&LOAD";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
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
            this.saleIDGV,
            this.userGV,
            this.totalAmountGV,
            this.givenAmountGV,
            this.amountReturnGV,
            this.totalDiscountGV,
            this.userrIDGV});
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(939, 644);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Image = global::ims.Properties.Resources.back_button;
            this.backBtn.Location = new System.Drawing.Point(0, 0);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(60, 111);
            this.backBtn.TabIndex = 2;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total Sale of the Day";
            // 
            // totalRichTextBox
            // 
            this.totalRichTextBox.Enabled = false;
            this.totalRichTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRichTextBox.Location = new System.Drawing.Point(18, 417);
            this.totalRichTextBox.Name = "totalRichTextBox";
            this.totalRichTextBox.Size = new System.Drawing.Size(289, 43);
            this.totalRichTextBox.TabIndex = 8;
            this.totalRichTextBox.Text = "";
            // 
            // saleIDGV
            // 
            this.saleIDGV.HeaderText = "Sale ID";
            this.saleIDGV.MinimumWidth = 6;
            this.saleIDGV.Name = "saleIDGV";
            this.saleIDGV.ReadOnly = true;
            // 
            // userGV
            // 
            this.userGV.HeaderText = "User Name";
            this.userGV.MinimumWidth = 6;
            this.userGV.Name = "userGV";
            this.userGV.ReadOnly = true;
            // 
            // totalAmountGV
            // 
            this.totalAmountGV.HeaderText = "Total Amount";
            this.totalAmountGV.MinimumWidth = 6;
            this.totalAmountGV.Name = "totalAmountGV";
            this.totalAmountGV.ReadOnly = true;
            // 
            // givenAmountGV
            // 
            this.givenAmountGV.HeaderText = "Given Amount";
            this.givenAmountGV.MinimumWidth = 6;
            this.givenAmountGV.Name = "givenAmountGV";
            this.givenAmountGV.ReadOnly = true;
            // 
            // amountReturnGV
            // 
            this.amountReturnGV.HeaderText = "Amount Return";
            this.amountReturnGV.MinimumWidth = 6;
            this.amountReturnGV.Name = "amountReturnGV";
            this.amountReturnGV.ReadOnly = true;
            // 
            // totalDiscountGV
            // 
            this.totalDiscountGV.HeaderText = "Total Discount";
            this.totalDiscountGV.MinimumWidth = 6;
            this.totalDiscountGV.Name = "totalDiscountGV";
            this.totalDiscountGV.ReadOnly = true;
            // 
            // userrIDGV
            // 
            this.userrIDGV.HeaderText = "User ID";
            this.userrIDGV.MinimumWidth = 6;
            this.userrIDGV.Name = "userrIDGV";
            this.userrIDGV.ReadOnly = true;
            this.userrIDGV.Visible = false;
            // 
            // ViewSalesInvoices
            // 
            this.AcceptButton = this.loadButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1259, 755);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "ViewSalesInvoices";
            this.Text = "View Sales Invoices";
            this.Load += new System.EventHandler(this.ViewSalesInvoices_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.leftTopPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.rightTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox totalRichTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn userGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn givenAmountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountReturnGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDiscountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn userrIDGV;
    }
}
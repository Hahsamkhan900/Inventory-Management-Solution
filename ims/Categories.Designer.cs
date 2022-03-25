namespace ims
{
    partial class Categories
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
            this.catStatDD = new System.Windows.Forms.ComboBox();
            this.Status = new System.Windows.Forms.Label();
            this.catTxtBox = new System.Windows.Forms.TextBox();
            this.modelNoTxt = new System.Windows.Forms.Label();
            this.catStatErrorLabel = new System.Windows.Forms.Label();
            this.catErrorLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.catIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged_1);
            // 
            // gvPanel
            // 
            this.gvPanel.Controls.Add(this.dataGridView1);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.catStatDD);
            this.leftPanel.Controls.Add(this.Status);
            this.leftPanel.Controls.Add(this.catTxtBox);
            this.leftPanel.Controls.Add(this.modelNoTxt);
            this.leftPanel.Controls.Add(this.catStatErrorLabel);
            this.leftPanel.Controls.Add(this.catErrorLabel);
            this.leftPanel.Controls.SetChildIndex(this.leftTopPanel, 0);
            this.leftPanel.Controls.SetChildIndex(this.catErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.catStatErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.modelNoTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.catTxtBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.Status, 0);
            this.leftPanel.Controls.SetChildIndex(this.catStatDD, 0);
            // 
            // topRightLabel
            // 
            this.topRightLabel.Text = "Categories";
            // 
            // catStatDD
            // 
            this.catStatDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.catStatDD.FormattingEnabled = true;
            this.catStatDD.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.catStatDD.Location = new System.Drawing.Point(14, 293);
            this.catStatDD.Name = "catStatDD";
            this.catStatDD.Size = new System.Drawing.Size(300, 28);
            this.catStatDD.TabIndex = 83;
            // 
            // Status
            // 
            this.Status.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(12, 268);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(49, 20);
            this.Status.TabIndex = 86;
            this.Status.Text = "Status";
            // 
            // catTxtBox
            // 
            this.catTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.catTxtBox.Location = new System.Drawing.Point(14, 226);
            this.catTxtBox.MaxLength = 50;
            this.catTxtBox.Name = "catTxtBox";
            this.catTxtBox.Size = new System.Drawing.Size(300, 27);
            this.catTxtBox.TabIndex = 82;
            // 
            // modelNoTxt
            // 
            this.modelNoTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modelNoTxt.AutoSize = true;
            this.modelNoTxt.Location = new System.Drawing.Point(12, 201);
            this.modelNoTxt.Name = "modelNoTxt";
            this.modelNoTxt.Size = new System.Drawing.Size(69, 20);
            this.modelNoTxt.TabIndex = 84;
            this.modelNoTxt.Text = "Category";
            // 
            // catStatErrorLabel
            // 
            this.catStatErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.catStatErrorLabel.AutoSize = true;
            this.catStatErrorLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catStatErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.catStatErrorLabel.Location = new System.Drawing.Point(87, 266);
            this.catStatErrorLabel.Name = "catStatErrorLabel";
            this.catStatErrorLabel.Size = new System.Drawing.Size(26, 32);
            this.catStatErrorLabel.TabIndex = 87;
            this.catStatErrorLabel.Text = "*";
            this.catStatErrorLabel.Visible = false;
            // 
            // catErrorLabel
            // 
            this.catErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.catErrorLabel.AutoSize = true;
            this.catErrorLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.catErrorLabel.Location = new System.Drawing.Point(87, 195);
            this.catErrorLabel.Name = "catErrorLabel";
            this.catErrorLabel.Size = new System.Drawing.Size(26, 32);
            this.catErrorLabel.TabIndex = 85;
            this.catErrorLabel.Text = "*";
            this.catErrorLabel.Visible = false;
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
            this.catIDGV,
            this.catNameGV,
            this.StatusGV});
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
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // catIDGV
            // 
            this.catIDGV.HeaderText = "catID";
            this.catIDGV.MinimumWidth = 6;
            this.catIDGV.Name = "catIDGV";
            this.catIDGV.ReadOnly = true;
            this.catIDGV.Visible = false;
            // 
            // catNameGV
            // 
            this.catNameGV.HeaderText = "Category Name";
            this.catNameGV.MinimumWidth = 6;
            this.catNameGV.Name = "catNameGV";
            this.catNameGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "Status";
            this.StatusGV.MinimumWidth = 6;
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "Categories";
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.Categories_Load);
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

        private System.Windows.Forms.ComboBox catStatDD;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.TextBox catTxtBox;
        private System.Windows.Forms.Label modelNoTxt;
        private System.Windows.Forms.Label catStatErrorLabel;
        private System.Windows.Forms.Label catErrorLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn catIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn catNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
    }
}
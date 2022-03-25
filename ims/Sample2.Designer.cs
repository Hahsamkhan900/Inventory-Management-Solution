namespace ims
{
    partial class Sample2
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
            this.backBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.saveBTN = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            this.searchGrp = new System.Windows.Forms.GroupBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gvPanel = new System.Windows.Forms.Panel();
            this.leftPanel.SuspendLayout();
            this.leftTopPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.rightTopPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.searchGrp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftTopPanel
            // 
            this.leftTopPanel.Controls.Add(this.backBtn);
            this.leftTopPanel.Controls.SetChildIndex(this.backBtn, 0);
            this.leftTopPanel.Controls.SetChildIndex(this.topLeftLabel, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.BackgroundImage = null;
            this.rightPanel.Controls.Add(this.gvPanel);
            this.rightPanel.Controls.Add(this.panel1);
            this.rightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rightPanel_Paint);
            this.rightPanel.Controls.SetChildIndex(this.rightTopPanel, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel1, 0);
            this.rightPanel.Controls.SetChildIndex(this.gvPanel, 0);
            // 
            // rightTopPanel
            // 
            this.rightTopPanel.Size = new System.Drawing.Size(942, 85);
            this.rightTopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rightTopPanel_Paint);
            // 
            // topLeftLabel
            // 
            this.topLeftLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLeftLabel.Location = new System.Drawing.Point(60, 0);
            this.topLeftLabel.Size = new System.Drawing.Size(260, 111);
            this.topLeftLabel.Text = "Sigma Accessories";
            // 
            // topRightLabel
            // 
            this.topRightLabel.Size = new System.Drawing.Size(942, 80);
            this.topRightLabel.Text = "Users";
            this.topRightLabel.Click += new System.EventHandler(this.topRightLabel_Click);
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
            this.backBtn.TabIndex = 1;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Controls.Add(this.deleteBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.saveBTN, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.addBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.editBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.viewBtn, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchGrp, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(942, 90);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe Print", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(271, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(128, 84);
            this.deleteBtn.TabIndex = 10;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // saveBTN
            // 
            this.saveBTN.BackColor = System.Drawing.Color.Transparent;
            this.saveBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveBTN.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.saveBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.saveBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.saveBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBTN.Font = new System.Drawing.Font("Segoe Print", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBTN.Location = new System.Drawing.Point(405, 3);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(128, 84);
            this.saveBTN.TabIndex = 9;
            this.saveBTN.Text = "SAVE";
            this.saveBTN.UseVisualStyleBackColor = false;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Transparent;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Segoe Print", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(3, 3);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(128, 84);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Transparent;
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.editBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.editBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Segoe Print", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.Location = new System.Drawing.Point(137, 3);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(128, 84);
            this.editBtn.TabIndex = 7;
            this.editBtn.Text = "EDIT";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // viewBtn
            // 
            this.viewBtn.BackColor = System.Drawing.Color.Transparent;
            this.viewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.viewBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.viewBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.viewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewBtn.Font = new System.Drawing.Font("Segoe Print", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.Location = new System.Drawing.Point(539, 3);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(128, 84);
            this.viewBtn.TabIndex = 6;
            this.viewBtn.Text = "VIEW";
            this.viewBtn.UseVisualStyleBackColor = false;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // searchGrp
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.searchGrp, 2);
            this.searchGrp.Controls.Add(this.searchBox);
            this.searchGrp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchGrp.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchGrp.ForeColor = System.Drawing.Color.White;
            this.searchGrp.Location = new System.Drawing.Point(673, 3);
            this.searchGrp.Name = "searchGrp";
            this.searchGrp.Size = new System.Drawing.Size(266, 84);
            this.searchGrp.TabIndex = 5;
            this.searchGrp.TabStop = false;
            this.searchGrp.Text = "Search";
            this.searchGrp.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // searchBox
            // 
            this.searchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBox.Location = new System.Drawing.Point(3, 33);
            this.searchBox.MaxLength = 50;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(260, 37);
            this.searchBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 90);
            this.panel1.TabIndex = 1;
            // 
            // gvPanel
            // 
            this.gvPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvPanel.Location = new System.Drawing.Point(0, 175);
            this.gvPanel.Name = "gvPanel";
            this.gvPanel.Size = new System.Drawing.Size(942, 498);
            this.gvPanel.TabIndex = 2;
            // 
            // Sample2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Sample2";
            this.Load += new System.EventHandler(this.Sample2_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftTopPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.rightTopPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.searchGrp.ResumeLayout(false);
            this.searchGrp.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button backBtn;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.TextBox searchBox;
        public System.Windows.Forms.GroupBox searchGrp;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel gvPanel;
        public System.Windows.Forms.Button deleteBtn;
        public System.Windows.Forms.Button saveBTN;
        public System.Windows.Forms.Button addBtn;
        public System.Windows.Forms.Button editBtn;
        public System.Windows.Forms.Button viewBtn;
    }
}
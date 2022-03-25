namespace ims
{
    partial class Users
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDD = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phoneTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pwdTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameErrorLabel = new System.Windows.Forms.Label();
            this.EmailErrorLabel = new System.Windows.Forms.Label();
            this.PassErrorLabel = new System.Windows.Forms.Label();
            this.UsernameErrorLabel = new System.Windows.Forms.Label();
            this.PhoneErrorLabel = new System.Windows.Forms.Label();
            this.statusErrorLabel = new System.Windows.Forms.Label();
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
            // 
            // gvPanel
            // 
            this.gvPanel.Controls.Add(this.dataGridView1);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.statusDD);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.emailTxtBox);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.phoneTxtBox);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.pwdTxtBox);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.usernameTxtBox);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.nameTxtBox);
            this.leftPanel.Controls.Add(this.label1);
            this.leftPanel.Controls.Add(this.NameErrorLabel);
            this.leftPanel.Controls.Add(this.EmailErrorLabel);
            this.leftPanel.Controls.Add(this.PassErrorLabel);
            this.leftPanel.Controls.Add(this.UsernameErrorLabel);
            this.leftPanel.Controls.Add(this.PhoneErrorLabel);
            this.leftPanel.Controls.Add(this.statusErrorLabel);
            this.leftPanel.Controls.SetChildIndex(this.leftTopPanel, 0);
            this.leftPanel.Controls.SetChildIndex(this.statusErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.PhoneErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.UsernameErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.PassErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.EmailErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.NameErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.label1, 0);
            this.leftPanel.Controls.SetChildIndex(this.nameTxtBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.usernameTxtBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.pwdTxtBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.phoneTxtBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.emailTxtBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.statusDD, 0);
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
            this.userIDGV,
            this.NameGV,
            this.UserNameGV,
            this.passwordGV,
            this.EmailGV,
            this.PhoneGV,
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
            // userIDGV
            // 
            this.userIDGV.HeaderText = "UserID";
            this.userIDGV.MinimumWidth = 6;
            this.userIDGV.Name = "userIDGV";
            this.userIDGV.ReadOnly = true;
            this.userIDGV.Visible = false;
            // 
            // NameGV
            // 
            this.NameGV.HeaderText = "Name";
            this.NameGV.MinimumWidth = 6;
            this.NameGV.Name = "NameGV";
            this.NameGV.ReadOnly = true;
            // 
            // UserNameGV
            // 
            this.UserNameGV.HeaderText = "Username";
            this.UserNameGV.MinimumWidth = 6;
            this.UserNameGV.Name = "UserNameGV";
            this.UserNameGV.ReadOnly = true;
            // 
            // passwordGV
            // 
            this.passwordGV.HeaderText = "Password";
            this.passwordGV.MinimumWidth = 6;
            this.passwordGV.Name = "passwordGV";
            this.passwordGV.ReadOnly = true;
            this.passwordGV.Visible = false;
            // 
            // EmailGV
            // 
            this.EmailGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmailGV.HeaderText = "Email";
            this.EmailGV.MinimumWidth = 6;
            this.EmailGV.Name = "EmailGV";
            this.EmailGV.ReadOnly = true;
            // 
            // PhoneGV
            // 
            this.PhoneGV.HeaderText = "Phone Number";
            this.PhoneGV.MinimumWidth = 6;
            this.PhoneGV.Name = "PhoneGV";
            this.PhoneGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "Status";
            this.StatusGV.MinimumWidth = 6;
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
            // 
            // statusDD
            // 
            this.statusDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusDD.FormattingEnabled = true;
            this.statusDD.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.statusDD.Location = new System.Drawing.Point(13, 541);
            this.statusDD.Name = "statusDD";
            this.statusDD.Size = new System.Drawing.Size(322, 28);
            this.statusDD.TabIndex = 98;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 510);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 97;
            this.label6.Text = "Status";
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTxtBox.Location = new System.Drawing.Point(13, 474);
            this.emailTxtBox.MaxLength = 50;
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(326, 27);
            this.emailTxtBox.TabIndex = 91;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 90;
            this.label5.Text = "Email";
            // 
            // phoneTxtBox
            // 
            this.phoneTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneTxtBox.Location = new System.Drawing.Point(13, 413);
            this.phoneTxtBox.MaxLength = 15;
            this.phoneTxtBox.Name = "phoneTxtBox";
            this.phoneTxtBox.Size = new System.Drawing.Size(326, 27);
            this.phoneTxtBox.TabIndex = 89;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 20);
            this.label4.TabIndex = 88;
            this.label4.Text = "Phone No (03XX-XXXXXXX)";
            // 
            // pwdTxtBox
            // 
            this.pwdTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pwdTxtBox.Location = new System.Drawing.Point(13, 352);
            this.pwdTxtBox.MaxLength = 30;
            this.pwdTxtBox.Name = "pwdTxtBox";
            this.pwdTxtBox.Size = new System.Drawing.Size(326, 27);
            this.pwdTxtBox.TabIndex = 87;
            this.pwdTxtBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 86;
            this.label3.Text = "Password";
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTxtBox.Location = new System.Drawing.Point(13, 292);
            this.usernameTxtBox.MaxLength = 30;
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(326, 27);
            this.usernameTxtBox.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 84;
            this.label2.Text = "Username";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTxtBox.Location = new System.Drawing.Point(13, 230);
            this.nameTxtBox.MaxLength = 40;
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(326, 27);
            this.nameTxtBox.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 82;
            this.label1.Text = "Name";
            // 
            // NameErrorLabel
            // 
            this.NameErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameErrorLabel.AutoSize = true;
            this.NameErrorLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.NameErrorLabel.Location = new System.Drawing.Point(82, 201);
            this.NameErrorLabel.Name = "NameErrorLabel";
            this.NameErrorLabel.Size = new System.Drawing.Size(26, 32);
            this.NameErrorLabel.TabIndex = 92;
            this.NameErrorLabel.Text = "*";
            this.NameErrorLabel.Visible = false;
            // 
            // EmailErrorLabel
            // 
            this.EmailErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailErrorLabel.AutoSize = true;
            this.EmailErrorLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.EmailErrorLabel.Location = new System.Drawing.Point(82, 444);
            this.EmailErrorLabel.Name = "EmailErrorLabel";
            this.EmailErrorLabel.Size = new System.Drawing.Size(26, 32);
            this.EmailErrorLabel.TabIndex = 96;
            this.EmailErrorLabel.Text = "*";
            this.EmailErrorLabel.Visible = false;
            // 
            // PassErrorLabel
            // 
            this.PassErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PassErrorLabel.AutoSize = true;
            this.PassErrorLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.PassErrorLabel.Location = new System.Drawing.Point(82, 324);
            this.PassErrorLabel.Name = "PassErrorLabel";
            this.PassErrorLabel.Size = new System.Drawing.Size(26, 32);
            this.PassErrorLabel.TabIndex = 94;
            this.PassErrorLabel.Text = "*";
            this.PassErrorLabel.Visible = false;
            // 
            // UsernameErrorLabel
            // 
            this.UsernameErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameErrorLabel.AutoSize = true;
            this.UsernameErrorLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.UsernameErrorLabel.Location = new System.Drawing.Point(82, 262);
            this.UsernameErrorLabel.Name = "UsernameErrorLabel";
            this.UsernameErrorLabel.Size = new System.Drawing.Size(26, 32);
            this.UsernameErrorLabel.TabIndex = 93;
            this.UsernameErrorLabel.Text = "*";
            this.UsernameErrorLabel.Visible = false;
            // 
            // PhoneErrorLabel
            // 
            this.PhoneErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneErrorLabel.AutoSize = true;
            this.PhoneErrorLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.PhoneErrorLabel.Location = new System.Drawing.Point(209, 382);
            this.PhoneErrorLabel.Name = "PhoneErrorLabel";
            this.PhoneErrorLabel.Size = new System.Drawing.Size(26, 32);
            this.PhoneErrorLabel.TabIndex = 95;
            this.PhoneErrorLabel.Text = "*";
            this.PhoneErrorLabel.Visible = false;
            // 
            // statusErrorLabel
            // 
            this.statusErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusErrorLabel.AutoSize = true;
            this.statusErrorLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.statusErrorLabel.Location = new System.Drawing.Point(82, 510);
            this.statusErrorLabel.Name = "statusErrorLabel";
            this.statusErrorLabel.Size = new System.Drawing.Size(26, 32);
            this.statusErrorLabel.TabIndex = 99;
            this.statusErrorLabel.Text = "*";
            this.statusErrorLabel.Visible = false;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "Users";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
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

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
        private System.Windows.Forms.ComboBox statusDD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phoneTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pwdTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NameErrorLabel;
        private System.Windows.Forms.Label EmailErrorLabel;
        private System.Windows.Forms.Label PassErrorLabel;
        private System.Windows.Forms.Label UsernameErrorLabel;
        private System.Windows.Forms.Label PhoneErrorLabel;
        private System.Windows.Forms.Label statusErrorLabel;
    }
}
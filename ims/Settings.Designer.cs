namespace ims
{
    partial class Settings
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
            this.serverLabel = new System.Windows.Forms.Label();
            this.serverTxtBox = new System.Windows.Forms.TextBox();
            this.databaseTxt = new System.Windows.Forms.TextBox();
            this.dbLbl = new System.Windows.Forms.Label();
            this.userTxtBox = new System.Windows.Forms.TextBox();
            this.userIdLbl = new System.Windows.Forms.Label();
            this.pwdTxtBox = new System.Windows.Forms.TextBox();
            this.pwdLblTxt = new System.Windows.Forms.Label();
            this.isChkBox = new System.Windows.Forms.CheckBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.leftTopPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.rightTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.saveBtn);
            this.leftPanel.Controls.Add(this.isChkBox);
            this.leftPanel.Controls.Add(this.pwdTxtBox);
            this.leftPanel.Controls.Add(this.pwdLblTxt);
            this.leftPanel.Controls.Add(this.userTxtBox);
            this.leftPanel.Controls.Add(this.userIdLbl);
            this.leftPanel.Controls.Add(this.databaseTxt);
            this.leftPanel.Controls.Add(this.dbLbl);
            this.leftPanel.Controls.Add(this.serverTxtBox);
            this.leftPanel.Controls.Add(this.serverLabel);
            this.leftPanel.Controls.SetChildIndex(this.leftTopPanel, 0);
            this.leftPanel.Controls.SetChildIndex(this.serverLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.serverTxtBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.dbLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.databaseTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.userIdLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.userTxtBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.pwdLblTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.pwdTxtBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.isChkBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.saveBtn, 0);
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverLabel.Location = new System.Drawing.Point(18, 202);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(57, 23);
            this.serverLabel.TabIndex = 1;
            this.serverLabel.Text = "Server";
            // 
            // serverTxtBox
            // 
            this.serverTxtBox.Location = new System.Drawing.Point(18, 237);
            this.serverTxtBox.MaxLength = 30;
            this.serverTxtBox.Name = "serverTxtBox";
            this.serverTxtBox.Size = new System.Drawing.Size(280, 27);
            this.serverTxtBox.TabIndex = 2;
            // 
            // databaseTxt
            // 
            this.databaseTxt.Location = new System.Drawing.Point(18, 311);
            this.databaseTxt.MaxLength = 30;
            this.databaseTxt.Name = "databaseTxt";
            this.databaseTxt.Size = new System.Drawing.Size(280, 27);
            this.databaseTxt.TabIndex = 4;
            // 
            // dbLbl
            // 
            this.dbLbl.AutoSize = true;
            this.dbLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbLbl.Location = new System.Drawing.Point(18, 276);
            this.dbLbl.Name = "dbLbl";
            this.dbLbl.Size = new System.Drawing.Size(81, 23);
            this.dbLbl.TabIndex = 3;
            this.dbLbl.Text = "Database";
            // 
            // userTxtBox
            // 
            this.userTxtBox.Location = new System.Drawing.Point(18, 385);
            this.userTxtBox.MaxLength = 30;
            this.userTxtBox.Name = "userTxtBox";
            this.userTxtBox.Size = new System.Drawing.Size(280, 27);
            this.userTxtBox.TabIndex = 6;
            // 
            // userIdLbl
            // 
            this.userIdLbl.AutoSize = true;
            this.userIdLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdLbl.Location = new System.Drawing.Point(18, 350);
            this.userIdLbl.Name = "userIdLbl";
            this.userIdLbl.Size = new System.Drawing.Size(66, 23);
            this.userIdLbl.TabIndex = 5;
            this.userIdLbl.Text = "User ID";
            // 
            // pwdTxtBox
            // 
            this.pwdTxtBox.Location = new System.Drawing.Point(18, 459);
            this.pwdTxtBox.MaxLength = 30;
            this.pwdTxtBox.Name = "pwdTxtBox";
            this.pwdTxtBox.Size = new System.Drawing.Size(280, 27);
            this.pwdTxtBox.TabIndex = 8;
            this.pwdTxtBox.UseSystemPasswordChar = true;
            // 
            // pwdLblTxt
            // 
            this.pwdLblTxt.AutoSize = true;
            this.pwdLblTxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdLblTxt.Location = new System.Drawing.Point(18, 424);
            this.pwdLblTxt.Name = "pwdLblTxt";
            this.pwdLblTxt.Size = new System.Drawing.Size(80, 23);
            this.pwdLblTxt.TabIndex = 7;
            this.pwdLblTxt.Text = "Password";
            // 
            // isChkBox
            // 
            this.isChkBox.AutoSize = true;
            this.isChkBox.Location = new System.Drawing.Point(22, 504);
            this.isChkBox.Name = "isChkBox";
            this.isChkBox.Size = new System.Drawing.Size(156, 24);
            this.isChkBox.TabIndex = 9;
            this.isChkBox.Text = "Integrated Security";
            this.isChkBox.UseVisualStyleBackColor = true;
            this.isChkBox.CheckedChanged += new System.EventHandler(this.isChkBox_CheckedChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Location = new System.Drawing.Point(18, 543);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(280, 39);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.leftTopPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.rightTopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox serverTxtBox;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.CheckBox isChkBox;
        private System.Windows.Forms.TextBox pwdTxtBox;
        private System.Windows.Forms.Label pwdLblTxt;
        private System.Windows.Forms.TextBox userTxtBox;
        private System.Windows.Forms.Label userIdLbl;
        private System.Windows.Forms.TextBox databaseTxt;
        private System.Windows.Forms.Label dbLbl;
        private System.Windows.Forms.Button saveBtn;
    }
}
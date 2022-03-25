namespace ims
{
    partial class Login
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
            this.unTxt = new System.Windows.Forms.Label();
            this.unTxtBox = new System.Windows.Forms.TextBox();
            this.pwdTxt = new System.Windows.Forms.Label();
            this.pwdTxtBox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.unErrorLabel = new System.Windows.Forms.Label();
            this.pwdErrorLabel = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.leftTopPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.rightTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.loginBtn);
            this.leftPanel.Controls.Add(this.pwdTxtBox);
            this.leftPanel.Controls.Add(this.pwdTxt);
            this.leftPanel.Controls.Add(this.unTxtBox);
            this.leftPanel.Controls.Add(this.unTxt);
            this.leftPanel.Controls.Add(this.pwdErrorLabel);
            this.leftPanel.Controls.Add(this.unErrorLabel);
            this.leftPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftPanel.Controls.SetChildIndex(this.unErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.pwdErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.leftTopPanel, 0);
            this.leftPanel.Controls.SetChildIndex(this.unTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.unTxtBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.pwdTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.pwdTxtBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.loginBtn, 0);
            // 
            // unTxt
            // 
            this.unTxt.AutoSize = true;
            this.unTxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unTxt.Location = new System.Drawing.Point(21, 230);
            this.unTxt.Name = "unTxt";
            this.unTxt.Size = new System.Drawing.Size(89, 23);
            this.unTxt.TabIndex = 1;
            this.unTxt.Text = "Username";
            this.unTxt.Click += new System.EventHandler(this.label1_Click);
            // 
            // unTxtBox
            // 
            this.unTxtBox.Location = new System.Drawing.Point(21, 262);
            this.unTxtBox.MaxLength = 30;
            this.unTxtBox.Name = "unTxtBox";
            this.unTxtBox.Size = new System.Drawing.Size(280, 27);
            this.unTxtBox.TabIndex = 2;
            this.unTxtBox.TextChanged += new System.EventHandler(this.unTxtBox_TextChanged);
            // 
            // pwdTxt
            // 
            this.pwdTxt.AutoSize = true;
            this.pwdTxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdTxt.Location = new System.Drawing.Point(21, 301);
            this.pwdTxt.Name = "pwdTxt";
            this.pwdTxt.Size = new System.Drawing.Size(85, 23);
            this.pwdTxt.TabIndex = 3;
            this.pwdTxt.Text = "Password";
            // 
            // pwdTxtBox
            // 
            this.pwdTxtBox.Location = new System.Drawing.Point(21, 333);
            this.pwdTxtBox.MaxLength = 30;
            this.pwdTxtBox.Name = "pwdTxtBox";
            this.pwdTxtBox.Size = new System.Drawing.Size(280, 27);
            this.pwdTxtBox.TabIndex = 4;
            this.pwdTxtBox.UseSystemPasswordChar = true;
            this.pwdTxtBox.TextChanged += new System.EventHandler(this.pwdTxtBox_TextChanged);
            // 
            // loginBtn
            // 
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(21, 389);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(280, 39);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // unErrorLabel
            // 
            this.unErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unErrorLabel.AutoSize = true;
            this.unErrorLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.unErrorLabel.Location = new System.Drawing.Point(112, 230);
            this.unErrorLabel.Name = "unErrorLabel";
            this.unErrorLabel.Size = new System.Drawing.Size(26, 32);
            this.unErrorLabel.TabIndex = 83;
            this.unErrorLabel.Text = "*";
            this.unErrorLabel.Visible = false;
            // 
            // pwdErrorLabel
            // 
            this.pwdErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pwdErrorLabel.AutoSize = true;
            this.pwdErrorLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.pwdErrorLabel.Location = new System.Drawing.Point(112, 301);
            this.pwdErrorLabel.Name = "pwdErrorLabel";
            this.pwdErrorLabel.Size = new System.Drawing.Size(26, 32);
            this.pwdErrorLabel.TabIndex = 82;
            this.pwdErrorLabel.Text = "*";
            this.pwdErrorLabel.Visible = false;
            // 
            // Login
            // 
            this.AcceptButton = this.loginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.leftTopPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.rightTopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox pwdTxtBox;
        private System.Windows.Forms.Label pwdTxt;
        private System.Windows.Forms.TextBox unTxtBox;
        private System.Windows.Forms.Label unTxt;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label pwdErrorLabel;
        private System.Windows.Forms.Label unErrorLabel;
    }
}
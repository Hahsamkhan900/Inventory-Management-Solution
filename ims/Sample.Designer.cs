namespace ims
{
    partial class Sample
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.leftTopPanel = new System.Windows.Forms.Panel();
            this.topLeftLabel = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.rightTopPanel = new System.Windows.Forms.Panel();
            this.topRightLabel = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.leftTopPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.rightTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.White;
            this.leftPanel.Controls.Add(this.leftTopPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(320, 673);
            this.leftPanel.TabIndex = 0;
            // 
            // leftTopPanel
            // 
            this.leftTopPanel.Controls.Add(this.topLeftLabel);
            this.leftTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.leftTopPanel.Location = new System.Drawing.Point(0, 0);
            this.leftTopPanel.Name = "leftTopPanel";
            this.leftTopPanel.Size = new System.Drawing.Size(320, 111);
            this.leftTopPanel.TabIndex = 0;
            // 
            // topLeftLabel
            // 
            this.topLeftLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topLeftLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLeftLabel.Location = new System.Drawing.Point(0, 0);
            this.topLeftLabel.Name = "topLeftLabel";
            this.topLeftLabel.Size = new System.Drawing.Size(320, 111);
            this.topLeftLabel.TabIndex = 0;
            this.topLeftLabel.Text = "Login Credentials";
            this.topLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.topLeftLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.Black;
            this.rightPanel.BackgroundImage = global::ims.Properties.Resources.sigma_logo;
            this.rightPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rightPanel.Controls.Add(this.rightTopPanel);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.ForeColor = System.Drawing.Color.White;
            this.rightPanel.Location = new System.Drawing.Point(320, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(942, 673);
            this.rightPanel.TabIndex = 1;
            // 
            // rightTopPanel
            // 
            this.rightTopPanel.Controls.Add(this.topRightLabel);
            this.rightTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.rightTopPanel.ForeColor = System.Drawing.Color.White;
            this.rightTopPanel.Location = new System.Drawing.Point(0, 0);
            this.rightTopPanel.Name = "rightTopPanel";
            this.rightTopPanel.Size = new System.Drawing.Size(942, 111);
            this.rightTopPanel.TabIndex = 0;
            // 
            // topRightLabel
            // 
            this.topRightLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topRightLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topRightLabel.Location = new System.Drawing.Point(0, 0);
            this.topRightLabel.Name = "topRightLabel";
            this.topRightLabel.Size = new System.Drawing.Size(942, 111);
            this.topRightLabel.TabIndex = 0;
            this.topRightLabel.Text = "Welcome To Login Page";
            this.topRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.topRightLabel.Click += new System.EventHandler(this.topRightLabel_Click);
            // 
            // Sample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.ControlBox = false;
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Sample";
            this.Load += new System.EventHandler(this.Sample_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftTopPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.rightTopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel leftPanel;
        protected System.Windows.Forms.Panel leftTopPanel;
        protected System.Windows.Forms.Panel rightPanel;
        protected System.Windows.Forms.Panel rightTopPanel;
        protected System.Windows.Forms.Label topLeftLabel;
        protected System.Windows.Forms.Label topRightLabel;
    }
}
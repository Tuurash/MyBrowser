namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.SearchTxt = new MetroFramework.Controls.MetroTextBox();
            this.HomeBtn = new MetroFramework.Controls.MetroButton();
            this.RFreshBtn = new MetroFramework.Controls.MetroButton();
            this.GoBtn = new MetroFramework.Controls.MetroButton();
            this.NextBtn = new MetroFramework.Controls.MetroButton();
            this.BackBtn = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.ProgressLBL = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchTxt
            // 
            // 
            // 
            // 
            this.SearchTxt.CustomButton.Image = null;
            this.SearchTxt.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.SearchTxt.CustomButton.Name = "";
            this.SearchTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SearchTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SearchTxt.CustomButton.TabIndex = 1;
            this.SearchTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SearchTxt.CustomButton.UseSelectable = true;
            this.SearchTxt.CustomButton.Visible = false;
            this.SearchTxt.Lines = new string[] {
        "http://"};
            this.SearchTxt.Location = new System.Drawing.Point(484, 3);
            this.SearchTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SearchTxt.MaxLength = 32767;
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.PasswordChar = '\0';
            this.SearchTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchTxt.SelectedText = "";
            this.SearchTxt.SelectionLength = 0;
            this.SearchTxt.SelectionStart = 0;
            this.SearchTxt.ShortcutsEnabled = true;
            this.SearchTxt.Size = new System.Drawing.Size(177, 23);
            this.SearchTxt.TabIndex = 8;
            this.SearchTxt.Text = "http://";
            this.SearchTxt.UseSelectable = true;
            this.SearchTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SearchTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchTxt_KeyPress);
            // 
            // HomeBtn
            // 
            this.HomeBtn.Location = new System.Drawing.Point(183, 0);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(50, 23);
            this.HomeBtn.TabIndex = 7;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseSelectable = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // RFreshBtn
            // 
            this.RFreshBtn.Location = new System.Drawing.Point(429, 3);
            this.RFreshBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RFreshBtn.Name = "RFreshBtn";
            this.RFreshBtn.Size = new System.Drawing.Size(50, 23);
            this.RFreshBtn.TabIndex = 6;
            this.RFreshBtn.Text = "Refresh";
            this.RFreshBtn.UseSelectable = true;
            this.RFreshBtn.Click += new System.EventHandler(this.RFreshBtn_Click);
            // 
            // GoBtn
            // 
            this.GoBtn.Location = new System.Drawing.Point(664, 0);
            this.GoBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.GoBtn.Name = "GoBtn";
            this.GoBtn.Size = new System.Drawing.Size(50, 23);
            this.GoBtn.TabIndex = 5;
            this.GoBtn.Text = "GO!!";
            this.GoBtn.UseSelectable = true;
            this.GoBtn.Click += new System.EventHandler(this.GoBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(106, 0);
            this.NextBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(50, 23);
            this.NextBtn.TabIndex = 4;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseSelectable = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(22, 0);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(50, 23);
            this.BackBtn.TabIndex = 3;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseSelectable = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.webBrowser);
            this.panel1.Controls.Add(this.GoBtn);
            this.panel1.Controls.Add(this.SearchTxt);
            this.panel1.Controls.Add(this.RFreshBtn);
            this.panel1.Controls.Add(this.BackBtn);
            this.panel1.Controls.Add(this.NextBtn);
            this.panel1.Controls.Add(this.HomeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(13, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 605);
            this.panel1.TabIndex = 9;
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(3, 45);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(758, 560);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            this.webBrowser.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser_ProgressChanged);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProgressBar.Location = new System.Drawing.Point(16, 641);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(100, 10);
            this.ProgressBar.TabIndex = 10;
            // 
            // ProgressLBL
            // 
            this.ProgressLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProgressLBL.AutoSize = true;
            this.ProgressLBL.Location = new System.Drawing.Point(116, 638);
            this.ProgressLBL.Name = "ProgressLBL";
            this.ProgressLBL.Size = new System.Drawing.Size(28, 13);
            this.ProgressLBL.TabIndex = 11;
            this.ProgressLBL.Text = "Ready";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(790, 655);
            this.Controls.Add(this.ProgressLBL);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.panel1);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(13, 30, 13, 20);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox SearchTxt;
        private MetroFramework.Controls.MetroButton HomeBtn;
        private MetroFramework.Controls.MetroButton RFreshBtn;
        private MetroFramework.Controls.MetroButton GoBtn;
        private MetroFramework.Controls.MetroButton NextBtn;
        private MetroFramework.Controls.MetroButton BackBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label ProgressLBL;
    }
}


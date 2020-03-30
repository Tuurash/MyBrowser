using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void RFreshBtn_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate("https://www.google.com/");
        }

        private void GoBtn_Click(object sender, EventArgs e)
        {
            navigate();
        }

        private void SearchTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter)
            { navigate(); }

        }

        private void navigate()
        {
            GoBtn.Enabled = false;
            SearchTxt.Enabled = false;
            webBrowser.Navigate(SearchTxt.Text);
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            GoBtn.Enabled = true;
            SearchTxt.Enabled = true;
        }
        
        private void webBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {try
            {
                if (e.CurrentProgress > 0 && e.MaximumProgress > 0)
                {
                    ProgressBar.Value = (int)(e.CurrentProgress * 100 / e.MaximumProgress);
                    ProgressLBL.Text = "Completed.";
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error found Progrssbar"+ex.ToString());
            }
        }
    
    }
}


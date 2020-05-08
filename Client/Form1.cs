using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class frmBrowser : Form
    {
        public frmBrowser()
        {
            InitializeComponent();
        }

        private void frmBrowser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            brpWebBrowser.GoBack();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            brpWebBrowser.GoForward();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            brpWebBrowser.Stop();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            brpWebBrowser.Navigate(txtBrowserUrl.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            brpWebBrowser.Refresh();
        }

        private void brpWebBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            txtBrowserUrl.Text = brpWebBrowser.Url.ToString();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            brpWebBrowser.Navigate("http://www.brprotective.com/");
        }
    }
}

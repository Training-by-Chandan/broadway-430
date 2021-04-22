using System;
using System.Windows.Forms;

namespace Broadway.DesktopApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //public WebBrowser browser => browser;


        public void Navigate(Uri url)
        {
            webBrowser1.Navigate(url);
        }
    }
}
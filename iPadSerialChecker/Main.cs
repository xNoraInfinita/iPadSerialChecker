using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iPadSerialChecker
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            browser.Url = new Uri("https://selfsolve.apple.com/agreementWarrantyDynamic.do");
            //sn
           
        }

        private void beginbtn_Click(object sender, EventArgs e)
        {
            browser.Document.GetElementById("sn").InnerText = "DMQMR72NFK10";
            browser.Document.GetElementById("warrantycheckbutton").InvokeMember("click");
            
        }
    
    }
}

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
        public int mistake = 0;
        public List<string> wrong = new List<string>();
        serialreader sr = new serialreader();

        public Main()
        {
            InitializeComponent();
            browser.Url = new Uri("https://selfsolve.apple.com/agreementWarrantyDynamic.do");
            //sn

        }

        private void beginbtn_Click(object sender, EventArgs e)
        {
            enterserialnumberandloop(sr.getnextserialnumber());

        }
        private void enterserialnumberandloop(string _inputserial)
        {
            browser.Document.GetElementById("sn").InnerText = _inputserial;
            browser.Document.GetElementById("warrantycheckbutton").InvokeMember("click");
            msg.Text = _inputserial;
           while(browser.ReadyState.ToString()!= "completed"){
              
           }
           
            this.redirecttohome();
            
        }
        private void redirecttohome()
        {
            Task.Delay(5500);
            browser.Url = new Uri("https://selfsolve.apple.com/agreementWarrantyDynamic.do");
            browser.Refresh();
        }
    

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace iPadSerialChecker
{
    public partial class Main : Form
    {
        public Boolean waitingforresult = false;
        public Boolean waitingforhome = false;
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
            
                if (_inputserial != null)
                {
                    browser.Document.GetElementById("sn").InnerText = _inputserial;
                    browser.Document.GetElementById("warrantycheckbutton").InvokeMember("click");
                    msg.Text = _inputserial;
                    waitingforresult = true;
                }
                else
                {
                    this.enterserialnumberandloop(sr.getnextserialnumber());
                }

            
        }
        private void redirecttohome()
        {
            waitingforhome = true;
            browser.Navigate("https://selfsolve.apple.com/agreementWarrantyDynamic.do");
          
            enterserialnumberandloop(sr.getnextserialnumber());
        }

        private void pageloaded(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (browser.ReadyState == WebBrowserReadyState.Complete)
            {
                if (waitingforresult)
                {

                    waitingforresult = false;

                    redirecttohome();

                }
                else if (waitingforhome)
                {
                    waitingforhome = false;
                    
                    //enterserialnumberandloop(sr.getnextserialnumber());
                }
            }
        }

        private void polldelay(int _delay)
        {
            var spin = new System.Threading.SpinWait();
            while (true)
            {

                spin.SpinOnce();
                if (spin.Count > _delay)
                {
                    break;
                }
            }
        }
    }
}

namespace iPadSerialChecker
{
    partial class Main
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
            this.browser = new System.Windows.Forms.WebBrowser();
            this.beginbtn = new System.Windows.Forms.Button();
            this.msg = new System.Windows.Forms.Label();
            this.fault = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // browser
            // 
            this.browser.Location = new System.Drawing.Point(-3, 54);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(774, 585);
            this.browser.TabIndex = 0;
            // 
            // beginbtn
            // 
            this.beginbtn.Location = new System.Drawing.Point(12, 12);
            this.beginbtn.Name = "beginbtn";
            this.beginbtn.Size = new System.Drawing.Size(88, 36);
            this.beginbtn.TabIndex = 1;
            this.beginbtn.Text = "Begin!";
            this.beginbtn.UseVisualStyleBackColor = true;
            this.beginbtn.Click += new System.EventHandler(this.beginbtn_Click);
            // 
            // msg
            // 
            this.msg.BackColor = System.Drawing.Color.White;
            this.msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg.Location = new System.Drawing.Point(247, 31);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(152, 17);
            this.msg.TabIndex = 2;
            this.msg.Text = "label1";
            this.msg.Click += new System.EventHandler(this.Onclick1);
            // 
            // fault
            // 
            this.fault.BackColor = System.Drawing.Color.White;
            this.fault.Location = new System.Drawing.Point(537, 31);
            this.fault.Name = "fault";
            this.fault.Size = new System.Drawing.Size(116, 17);
            this.fault.TabIndex = 3;
            this.fault.Text = "label1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(771, 638);
            this.Controls.Add(this.fault);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.beginbtn);
            this.Controls.Add(this.browser);
            this.Name = "Main";
            this.Text = "iPad Serial Checker by Chazz R";
            this.ResumeLayout(false);

        }

        private void Onclick1(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.Button beginbtn;
        private System.Windows.Forms.Label msg;
        private System.Windows.Forms.Label fault;
    }
}


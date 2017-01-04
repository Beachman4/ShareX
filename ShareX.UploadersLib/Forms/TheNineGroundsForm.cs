using System;
using System.Drawing;
using System.Windows.Forms;
using ShareX.HelpersLib;
using ShareX.UploadersLib.FileUploaders;
using ShareX.UploadersLib.Properties;

namespace ShareX.UploadersLib
{
    public partial class TheNineGroundsForm : Form
    {
        public string ApiKey { get; set; }

        public TheNineGroundsForm()
        {
            InitializeComponent();
        }

        private bool ValidationCheck()
        {
            bool result = true;

            if (string.IsNullOrEmpty(username_email_text.Text))
            {
                username_email_text.BackColor = Color.FromArgb(255, 200, 200);
                result = false;
            } else
            {
                username_email_text.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrEmpty(password_text.Text))
            {
                password_text.BackColor = Color.FromArgb(255, 200, 200);
                result = false;
            } else
            {
                password_text.BackColor = SystemColors.Window;
            }

            return result;
        }

        private void button_click(object sender, EventArgs e)
        {
            
        }
    }
}

using Demo.Shared.Models;
using Service.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void Loginbutton_Click(object sender, EventArgs e)
        {
            AuthenticateResult auth = null;
            Loginbutton.Enabled = false;
            Statuslabel.Text = "Authenticating";
            Statuslabel.ForeColor = Color.Gray;

            //Task.Run(()=> auth = CommonLogic.Authenticate());
            auth = CommonLogic.Authenticate();
            Loginbutton.Enabled = true;
            if (auth.Authenticated)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                Statuslabel.Text = "Access Denied";
            }
            Statuslabel.ForeColor = Color.Red;
           
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            string env = ConfigurationManager.AppSettings["env"];
            if (string.IsNullOrEmpty(env))
            {
                Statuslabel.Text = string.Empty;
                userText.Text = Environment.UserName;
            }
        }
    }
}

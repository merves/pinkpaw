using Hanu.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hanu
{
    public partial class LoginLayout : Form
    {
        public LoginLayout()
        {
            InitializeComponent();
        }
        Login login;
        Register register;

        Boolean loginViewVisible = true;
        private void LoginLayout_Load(object sender, EventArgs e)
        {
           
        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {
            login = new Login();
            register = new Register();
            panelRight.Controls.Add(login);
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        public void change_View()
        {
            panelRight.Controls.Clear();
            if (loginViewVisible)
            {
                panelRight.Controls.Add(register);
                loginViewVisible = false;
            }
            else
            {
                panelRight.Controls.Add(login);
                loginViewVisible = true;
            }
        }


    }
}

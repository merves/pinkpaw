using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Hanu.View
{
    public partial class Login : UserControl
    {
        MySqlConnection connect = new MySqlConnection(ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString);

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ((LoginLayout)this.ParentForm).change_View();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            MySqlDataAdapter adapper = new MySqlDataAdapter("select count(*) from user where name = '" + textBox1.Text + "' and pwd = '" + textBox2.Text + "'", connect);
            DataTable dt = new DataTable();
            adapper.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {


                Layout layout = new Layout();
                connect.Close();
                layout.Show();
                this.ParentForm.Hide();
            }

            else
            {
                MessageBox.Show("Username or Password is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}

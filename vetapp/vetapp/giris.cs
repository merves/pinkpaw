using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace vetapp
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void usernamelbl_Click(object sender, EventArgs e)
        {

        }

        private void signbtn_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string userpsw = textBox5.Text;
            MySqlConnection conn = new MySqlConnection("");
            MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from userinfo where username='" + textBox1.Text + "' and userpsw = '" + textBox5.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "0")
            {
                //MessageBox.Show("username and userpsw are mached", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("insert into userinfo(username,userpsw) values('" + textBox1.Text + "','" + textBox5.Text + "')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                MessageBox.Show("error", "alter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            asıl i2 = new asıl();
            this.Hide();
            i2.Show();


        }

        private void createacountlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hesap i1 = new hesap();
            this.Hide();
            i1.Show();
        }
    }
}

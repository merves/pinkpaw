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
    public partial class hesap : Form
    {
        public hesap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string lastname = textBox2.Text;
            string email = textBox3.Text;
            string tcno = textBox4.Text;
            string address = richTextBox1.Text;
            string password = textBox5.Text;
            MySqlConnection connection = new MySqlConnection("");
            MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from account where name='" + textBox1.Text + "' and lastname = '" + textBox2.Text + "' and email = '" + textBox3.Text + "'and tcno='" + textBox4.Text + "'and address='" + richTextBox1.Text + "'and password='" + textBox5.Text + "'", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "0")
            {
                //MessageBox.Show("aferin","information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("insert into account(name,lastname,email,tcno,address,password) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + richTextBox1.Text + "','" + textBox5.Text + "')", connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                MessageBox.Show("hatalısın", "alter", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            asıl i2 = new asıl();
            this.Hide();
            i2.Show();

        }
    }
}

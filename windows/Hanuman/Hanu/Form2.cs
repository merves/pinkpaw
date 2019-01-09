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

namespace hanu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            string lastname = textBox22.Text;
            string email = textBox3.Text;
            string no = textBox4.Text;
            string adr = richTextBox1.Text;
            MySqlConnection connector = new MySqlConnection();
            connector.ConnectionString = "server=pinkpawdb.cw2vs85p55vv.eu-central-1.rds.amazonaws.com;user id=pinkpaw; password = FfmA8Dtb3PpGen7q; persistsecurityinfo=True;database=ppdb";
            string query = "insert into user(name,pwd,lastname,email,no,adr) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox22.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + richTextBox1.Text + "');";
            MySqlCommand cmdDataBase = new MySqlCommand(query, connector);
            MySqlDataReader myreader;
            connector.Open();
            myreader = cmdDataBase.ExecuteReader();
            MessageBox.Show("Registered success", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            while (myreader.Read())
            {
            }
            connector.Close();

            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();


        }

        private void namelbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

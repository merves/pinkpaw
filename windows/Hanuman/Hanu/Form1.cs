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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
string user = textBox1.Text;
            string pass = textBox2.Text;
            
            MySqlConnection connector = new MySqlConnection();
            connector.ConnectionString = "server=pinkpawdb.cw2vs85p55vv.eu-central-1.rds.amazonaws.com;user id=pinkpaw; password = FfmA8Dtb3PpGen7q; persistsecurityinfo=True;database=ppdb";
            MySqlDataAdapter adapper = new MySqlDataAdapter("select count(*) from user where name = '" + textBox1.Text + "' and pwd = '" + textBox2.Text + "'", connector);
            DataTable taketable = new DataTable();
            adapper.Fill(taketable);
            if (taketable.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Usr and password are correct", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                anasayfa a = new anasayfa();
                this.Hide();
                a.Show();
            }
            else
            {
                MessageBox.Show("Username or Password is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            /*  string user = textBox1.Text;
              string pass = textBox2.Text;
              MySqlConnection connector = new MySqlConnection();
              connector.ConnectionString = "server=pinkpawdb.cw2vs85p55vv.eu-central-1.rds.amazonaws.com;user id=pinkpaw; password = FfmA8Dtb3PpGen7q; persistsecurityinfo=True;database=ppdb";
              string query = "insert into user(name,pwd) values ('" + textBox1.Text + "','" + textBox2.Text + "');";
              MySqlCommand cmdDataBase = new MySqlCommand(query, connector);
              MySqlDataReader myreader;
              connector.Open();
              myreader = cmdDataBase.ExecuteReader();
              MessageBox.Show("Registered success", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
              while (myreader.Read())
              {
              }
              connector.Close();
  */

            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

       
    }
}

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
    public partial class Customer : UserControl
    {
        MySqlConnection connector = new MySqlConnection(ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString);

        public Customer()
        {
            InitializeComponent();
            dataGridView1.DataSource = Getvalue();
            dataGridView2.DataSource = Getpet();
        }
        private DataTable Getvalue()
        {
            DataTable customer = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand("SELECT cname,surname,gsm,address,eposta FROM customer", connector))
            {
                connector.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                customer.Load(reader);
                connector.Close();
            }
            return customer;
        }
        private DataTable Getpet()
        {
            DataTable pet = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand("SELECT pname FROM pet where userid IS NULL", connector))
            {
                connector.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                pet.Load(reader);
                connector.Close();
            }
            return pet;
        }

            private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }
    }
}

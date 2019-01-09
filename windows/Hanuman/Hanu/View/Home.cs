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
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            dataGridView1.DataSource = Getvaccine();
            dataGridView2.DataSource = Getappointment();
            dataGridView3.DataSource = Getquestion();
        }

        private DataTable Getvaccine()
        {
            DataTable pet = new DataTable();
            MySqlConnection connector = new MySqlConnection("server=pinkpawdb.cw2vs85p55vv.eu-central-1.rds.amazonaws.com;user id=pinkpaw; password = NaN; persistsecurityinfo=True;database=ppdb; convert zero datetime=True");
            using (MySqlCommand cmd = new MySqlCommand("SELECT pname,pdt FROM pet", connector))
            {
                connector.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                pet.Load(reader);
            }
            return pet;
        }
        private DataTable Getappointment()
        {
            DataTable customer = new DataTable();
            MySqlConnection connector = new MySqlConnection("server=pinkpawdb.cw2vs85p55vv.eu-central-1.rds.amazonaws.com;user id=pinkpaw; password = NaN; persistsecurityinfo=True;database=ppdb; convert zero datetime=True");
            using (MySqlCommand cmd = new MySqlCommand("SELECT cname,vdt FROM customer ", connector))
            {
                connector.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                customer.Load(reader);
            }
                return customer;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        MySqlDataAdapter da;
        MySqlCommand cmd;
        DataSet ds;
        MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString);


        private DataTable Getquestion()
        {
            DataTable question = new DataTable();
            MySqlConnection connector = new MySqlConnection("server=pinkpawdb.cw2vs85p55vv.eu-central-1.rds.amazonaws.com;user id=pinkpaw; password = NaN; persistsecurityinfo=True;database=ppdb; convert zero datetime=True");
            using (MySqlCommand cmd = new MySqlCommand("select note_id,date,title,notes from note", connector))
            {
                connector.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                question.Load(reader);
            }
            return question;
        }
    }
}

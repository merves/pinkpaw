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
    public partial class Questions : UserControl
    {
        MySqlDataAdapter da;
        MySqlCommand cmd;
        DataSet ds;
        MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString);
        public Questions()
        {
            InitializeComponent();
        }

        private void Questions_Load(object sender, EventArgs e)
        {
            GridShow();
        }
        void GridShow()
        {

            da = new MySqlDataAdapter("select title,notes from note order by date", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "note");
            dataGridView1.DataSource = ds.Tables["note"];
            con.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hanu.View
{
    public partial class AppointmentHour : UserControl
    {
        public static int Column_size { get; set; }

        public static DateTime OpeningTime { get; set; }
        public static DateTime ClosingTime { get; set; }

        public static DateTime LaunchStart { get; set; }
        public static DateTime LaunchEnd { get; set; }
        public AppointmentHour()
        {
            InitializeComponent();
        }


        private void AppointmentHour_Load_1(object sender, EventArgs e)
        {

            DateTime time = new DateTime();
            time = DateTime.Today;
            time = time.Add(OpeningTime.TimeOfDay);

            bool isThere;
            int i = 0, j = 0;

            while (time.TimeOfDay < ClosingTime.TimeOfDay)
            {

                isThere = ((time.TimeOfDay <= LaunchEnd.TimeOfDay &&
                   time.TimeOfDay >= LaunchStart.TimeOfDay)) ? true : false;



                tblSaatler.Controls.Add(new Button()
                {
                    Text = String.Format("{0:t}", time),
                    Anchor = AnchorStyles.Bottom,
                    AutoSize = true,
                    Tag = time,
                    BackColor = (isThere) ? Color.Gray : Color.Green,
                    Enabled = !isThere

                }, i, j);
                i++;
                if (i >= Column_size)
                {
                    i = 0;
                    j++;
                    tblSaatler.ColumnCount++;
                }



                time = time.AddMinutes(15);
            }


        
    }
    }
}

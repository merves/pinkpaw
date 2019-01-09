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
    public partial class Appointment : UserControl
    {
        public Appointment()
        {
            InitializeComponent();
        }

        


        
        AppointmentHour appointmentHour;
        private void pnlHours_Refresh()
        {
            AppointmentHour.OpeningTime = new DateTime().AddHours(9);
            AppointmentHour.ClosingTime = AppointmentHour.OpeningTime.AddHours(8);
            AppointmentHour.LaunchStart = AppointmentHour.OpeningTime.AddHours(4);
            AppointmentHour.LaunchEnd = AppointmentHour.LaunchStart.AddHours(1);
            AppointmentHour.Column_size = 4;
            pnlHours.Controls.Clear();
            appointmentHour = new AppointmentHour();
            appointmentHour.Size = pnlHours.Size - (new Size(5, 5));
            pnlHours.Controls.Add(appointmentHour);

        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            pnlHours_Refresh();
        }
    }
}

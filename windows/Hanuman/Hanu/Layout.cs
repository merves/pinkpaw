using AForge.Video.DirectShow;
using Hanu.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hanu
{
    public partial class Layout : Form
    {
        private VideoCaptureDevice FinalFrame;
        public Layout()
        {
            InitializeComponent();
        }
        Customer customer;
        Pet pet;
        Appointment appointment;
        Questions questions;
        Home home;
        Admin admin;
        Mail mail;

        private void closeLabel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Layout_Load()
        {
            

        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {
            if (home == null)
            {
                HomeButton.BackColor = Color.Firebrick;
                home = new Home();
                panelRight.Controls.Add(home);
            }

        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            if (customer == null)
                customer = new Customer();

            selectMenuClear();
            customerButton.BackColor=Color.Firebrick;
            panelRight.Controls.Clear();
            panelRight.Controls.Add(customer);
        }

        private void PetButton_Click(object sender, EventArgs e)
        {
            if(pet == null)
                pet = new Pet();
            selectMenuClear();
            PetButton.BackColor = Color.Firebrick;
            panelRight.Controls.Clear();
            panelRight.Controls.Add(pet);
        }

        private void selectMenuClear()
        {
            customerButton.BackColor = Color.DarkRed;
            PetButton.BackColor = Color.DarkRed;
            appointmentButton.BackColor = Color.DarkRed;
            supportButton.BackColor = Color.DarkRed;
            HomeButton.BackColor = Color.DarkRed;
            adminButton.BackColor = Color.DarkRed;
            mailButton.BackColor = Color.DarkRed;
        }

        private void appointmentButton_Click(object sender, EventArgs e)
        {
            if (appointment == null)
                appointment = new Appointment();
            selectMenuClear();
            appointmentButton.BackColor = Color.Firebrick;
            panelRight.Controls.Clear();
            panelRight.Controls.Add(appointment);
        }

        private void supportButton_Click(object sender, EventArgs e)
        {
            if (questions == null)
                questions = new Questions();
            selectMenuClear();
            supportButton.BackColor = Color.Firebrick;
            panelRight.Controls.Clear();
            panelRight.Controls.Add(questions);
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            if (home == null)
                home = new Home();
            selectMenuClear();
            HomeButton.BackColor = Color.Firebrick;
            panelRight.Controls.Clear();
            panelRight.Controls.Add(home);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (admin == null)
                admin = new Admin();
            selectMenuClear();
            adminButton.BackColor = Color.Firebrick;
            panelRight.Controls.Clear();
            panelRight.Controls.Add(admin);
        }

        private void mailButton_Click(object sender, EventArgs e)
        {
            if (mail == null)
                mail = new Mail();
            selectMenuClear();
            mailButton.BackColor = Color.Firebrick;
            panelRight.Controls.Clear();
            panelRight.Controls.Add(mail);
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLeft_Click(object sender, EventArgs e)
        {
            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
        }
    }
}

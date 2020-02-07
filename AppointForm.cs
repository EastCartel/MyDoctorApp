using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDoctor
{
    public partial class AppointForm : Form
    {
        public AppointForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Doctorf d = new Doctorf();
            d.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PatientForm p = new PatientForm();
            p.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string Doctor = Nappoint.Text;
            string Patient = Pappoint.Text;
            string Time = Tappoint.Text;
            string Date = Dappoint.Text;
            string Location = Lappoint.Text;
            //int id = Program.ManageDoc.RemoveDoctor;



            Appointment ap = new Appointment(Doctor, Patient, Time, Date, Location);
            Program.ManageDoc.AddAppointment(ap);
            dataGridView1.DataSource = Program.ManageDoc.Appointments;
        }

        private void AppointForm_Load(object sender, EventArgs e)
        {
            int n = Program.ManageDoc.Doctors.Count;
            string[] vs = new string[n];
            for(int i = 0; i < n; i++)
            {
                string data = Program.ManageDoc.Doctors[i].name;
                vs[i] = data;
            }
            Nappoint.DataSource = vs;


            int y = Program.ManageDoc.Patients.Count;
            string[] vd = new string[y];
            for (int p = 0; p < y; p++)
            {
                string data1 = Program.ManageDoc.Patients[p].name;
                vd[p] = data1; 
            }
            Pappoint.DataSource = vd;
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AppointForm ap = new AppointForm();
            ap.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Nappoint_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

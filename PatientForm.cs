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
    public partial class PatientForm : Form
    {
        //MyDocApp ManagePatient;
        public PatientForm()
        {
            InitializeComponent();
            this.PatientList();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        public void PatientList()
        {
            dataGridView1.DataSource = Program.ManageDoc.Patients;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PatientForm p = new PatientForm();
            p.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Doctorf d = new Doctorf();
            d.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = Dname.Text;
            string Age = Dage.Text;
            string Gender = Dgender.Text;
            string BloodGroup = Dblood.Text;
            string Genotype = Dgenotype.Text;
            string PatientComplaint = Dcomplaint.Text;
            string Location = Dlocation.Text;

           Patient p = new Patient(Name, Age, Gender,BloodGroup, Genotype, PatientComplaint, Location);
            Program.ManageDoc.AddPatient(p);
            this.PatientList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Program.ManageDoc.Patients;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AppointForm ap = new AppointForm();
            ap.Show();
            //this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            //this.Hide();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

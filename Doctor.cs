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
    public partial class Doctorf : Form
    {
        MyDocApp DoctorApp = new MyDocApp();
        int rowNo;
        
        public Doctorf ()
        {
            InitializeComponent();
          //  ManageDoc = new MyDocApp();
        }

        //grid view method
        public void ListDisplay()
        {
            dataGridView1.DataSource = DoctorApp.Doctors;
        }

        private void Doctor_Load(object sender, EventArgs e)
        {

        }
        //method that generates random id as  string
        //public string generateID()
        //{
        //    return Guid.NewGuid().ToString("N");
        //}

        //method that accepts input and initializes it to the 
        private void button1_Click(object sender, EventArgs e)
        {

            string Name = Dname.Text;
            string Age = Dage.Text;
            string Gender = Dgender.Text;
            string Qualification = Dqual.Text;
            string Experience = Dexp.Text;
            string Specialization = Dspec.Text;
            string Location = Dlocation.Text;
            string Id = Did.Text;
            //string Id = this.generateID();
            Doctor d;
            if(Name == string.Empty && Age == string.Empty && Location == string.Empty)
            {
                MessageBox.Show("Place in a value");
            }
            else
            {
                d = new Doctor(Name, Age, Gender, Qualification, Experience, Specialization, Location, Id);
                DoctorApp.AddDoctor(d);

                this.ListDisplay();


                dataGridView1.DataSource = null;
                dataGridView1.DataSource = DoctorApp.Doctors;

            }




            //Doctor d = new Doctor(Name, Age, Gender, Qualification, Experience, Specialization, Location, Id);
            //Program.ManageDoc.AddDoctor(d);

            //this.ListDisplay();


            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = Program.ManageDoc.Doctors;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            AppointForm ap = new AppointForm();
            ap.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowNo = e.RowIndex;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //DataGridViewRow dataRow = dataGridView1.Rows[selectedRow]
           
        }

        private void Dname_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //int rowIndex = dataGridView1.CurrentCell.RowIndex;
            //dataGridView1.Rows.RemoveAt(rowIndex);

            //removes item from the datagrid -- whilst using the BindingList instead of List
            //dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

            
            Doctor doctorR = DoctorApp[rowNo];
            DoctorApp.RemoveDoctor(doctorR);
            
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DoctorApp.Doctors;
        }
    }
}

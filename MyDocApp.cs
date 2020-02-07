using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDoctor
{

    interface IGetDoctor
    {
        //void AddDoctor(Doctor d);
        bool AddDoctor(Doctor d);
        bool RemoveDoctor(Doctor d);
        bool UpdateDoctor(Doctor d);
        bool AddPatient(Patient P);
        bool RemovePatient(Patient P);
        bool UpdatePatient(Patient P);
    }

    class MyDocApp : IGetDoctor
    {
        //this was changed from list to BindingList to implement delete
        public List<Doctor> Doctors = new List<Doctor>();
        public List<Patient> Patients = new List<Patient>();
        public List<Appointment> Appointments = new List<Appointment>();

        public Doctor this[int num]
        {
            get
            {
                return Doctors[num];
            }
            set
            {
                //Doctors.FirstOrDefault(d => d.id == Id).name = value;
            }
        }

        public bool AddDoctor(Doctor d)
        {
            Doctors.Add(d);
            //Random rnd = new Random();
            return true;
        }

        public bool AddPatient(Patient P)
        {
            Patients.Add(P);
            return true;

        }

        public bool AddAppointment(Appointment ap)
        {
            Appointments.Add(ap);
            return true;
        }

        public bool RemoveDoctor(Doctor d)
        {
            Doctors.Remove(d);
            return true;
        }

        public bool RemovePatient(Patient P)
        {
            throw new NotImplementedException();
        }

        public bool UpdateDoctor(Doctor d)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePatient(Patient P)
        {
            throw new NotImplementedException();
        }
    }

    class Doctor
    {
        //properties that makes up the class Doctor
        public string name { get; set; }
        public string dateofbirth { get; set; }
        public string sex { get; set; }
        public string qualification { get; set; }
        public string experience { get; set; }
        public string specialization { get; set; }
        public string location { get; set; }
        public string id { get; set; }
        

        //constructor method that initializes the properties 
        public Doctor(string Name, string DateOfBirth, string Sex, string Qualification, string Experience, string Specialization, string Location, string Id)
        {
            this.name = Name;
            this.dateofbirth = DateOfBirth;
            this.sex = Sex;
            this.qualification = Qualification;
            this.experience = Experience;
            this.specialization = Specialization;
            this.location = Location;
            this.id = Id;
            
            
        }

        //lst

    }

    class Patient
    {
        public string name { get; set; }
        public string dateofbirth { get; set; }
        public string sex { get; set; }
        public string bloodgroup { get; set; }
        public string genotype { get; set; }
        public string patientcomplaint { get; set; }
        public string location { get; set; }

        public Patient(string Name, string DateOfBirth, string Sex, string BloodGroup, string Genotype, string PatientComplaint, string Location)
        {
            this.name = Name;
            this.dateofbirth = DateOfBirth;
            this.sex = Sex;
            this.bloodgroup = BloodGroup;
            this.genotype = Genotype;
            this.patientcomplaint = PatientComplaint;
            this.location = Location;

        }

    }

    class Appointment
    {
        public string doctor { get; set; }
        public string patient { get; set; }
        public string time { get; set; }
        public string date { get; set; }
        public string location { get; set; }

        public Appointment(string Doctor, string Patient, string Time, string Date, string Location)
        {
            this.doctor = Doctor;
            this.patient = Patient;
            this.time = Time;
            this.date = Date;
            this.location = Location;
            

        }

    }
}

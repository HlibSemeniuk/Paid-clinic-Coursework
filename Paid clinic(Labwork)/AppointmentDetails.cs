using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paid_clinic_Labwork_
{
    public partial class AppointmentDetails : Form
    {
        Appointment _appointment;
        bool _isDoctor;

        public AppointmentDetails(Appointment appointment, bool isDoctor)
        {
            _appointment = appointment;
            _isDoctor = isDoctor;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Icon = new Icon("clinic-icon.ico");
        }

        private void AppointmentDetails_Load(object sender, EventArgs e)
        {
            FillRows();
        }

        private void FillRows()
        {
            if (_isDoctor)
            {
                label_Person.Text = "Пацієнт:";
                textBox_Name.Text = _appointment.Patient.Name + ", " + (int)((DateTime.Now - _appointment.Patient.Birthdate).TotalDays / 365.242199) + " y/o";
            }
            else
            {
                label_Person.Text = "Лікар:";
                textBox_Name.Text = _appointment.Doctor.Name + ",  " + _appointment.Doctor.Specialization;
            }

            textBox_Date.Text = _appointment.Date.ToString("dd.MM.yyyy HH:mm");
            textBox_Symptoms.Text = _appointment.Examination.Symptoms;
            textBox_Diagnosis.Text = _appointment.Examination.Diagnosis;
            textBox_Recommendations.Text = _appointment.Examination.Treatment.Recommendations;
            textBox_Medicines.Text = _appointment.Examination.Treatment.Medicines;
            textBox_TreatmentPrice.Text = _appointment.Examination.Treatment.TreatmentPrice.ToString("C");

            if (_appointment.Patient.SocialDiscount)
                textBox_TreatmentPrice.Text += $" (зі знижкою {_appointment.Examination.Treatment.SocialDiscountPercent}%)";
        }

        private void textBox_Symptoms_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox_Diagnosis_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox_Recommendations_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox_Medicines_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox_TreatmentPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox_Date_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

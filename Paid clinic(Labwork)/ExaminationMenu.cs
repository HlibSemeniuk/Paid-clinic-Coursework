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
    public partial class ExaminationMenu : Form
    {

        Appointment _appointment = new Appointment();

        public ExaminationMenu(Appointment appointment)
        {
            _appointment = appointment;

            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Icon = new Icon("clinic-icon.ico");
        }

        private void ExaminationMenu_Load(object sender, EventArgs e)
        {
            if (_appointment.Patient.SocialDiscount == false)
            {
                label_Discount.Hide();
                textBox_Discount.Hide();
                label_PriceWithDiscount.Hide();
                textBox_PriceWithDiscount.Hide();
            }

            textBox_PatientInfo.Text = _appointment.Patient.Name;
            textBox_Date.Text = _appointment.Date.ToString("dd.MM.yyyy HH:mm");
            textBox_Discount.MaxLength = 2;
        }

        private void textBox_PriceWithDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox_Discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button_EndAppointment_Click(object sender, EventArgs e)
        {
            if (!AreRequiredFieldsFilled())
            {
                MessageBox.Show("Ви не вказали всі дані!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (_appointment.Patient.SocialDiscount == true && (textBox_Discount.Text.Length == 0))
            {
                MessageBox.Show("Ви не вказали всі дані!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (_appointment.Patient.SocialDiscount == false)
            {
                var treatment = new Treatment() { Recommendations = textBox_Recommendations.Text, Medicines = textBox_Medicines.Text, TreatmentPrice = decimal.Parse(textBox_TreatmentPrice.Text) };
                var examination = new Examination() { Diagnosis = textBox_Diagnosis.Text, Symptoms = textBox_Symptoms.Text, Treatment = treatment };
                _appointment.Examination = examination;
                _appointment.IsHappened = true;
                MessageBox.Show("Ви успішно завершили прийом!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (_appointment.Patient.SocialDiscount == true)
            {
                var treatment = new Treatment() { Recommendations = textBox_Recommendations.Text, Medicines = textBox_Medicines.Text, SocialDiscountPercent = float.Parse(textBox_Discount.Text), TreatmentPrice = decimal.Parse(textBox_PriceWithDiscount.Text) };
                var examination = new Examination() { Diagnosis = textBox_Diagnosis.Text, Symptoms = textBox_Symptoms.Text, Treatment = treatment };
                _appointment.Examination = examination;
                _appointment.IsHappened = true;
                MessageBox.Show("Ви успішно завершили прийом!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private bool AreRequiredFieldsFilled()
        {
            return textBox_Symptoms.Text.Length > 0 &&
                   textBox_Diagnosis.Text.Length > 0 &&
                   textBox_Recommendations.Text.Length > 0 &&
                   textBox_Medicines.Text.Length > 0 &&
                   textBox_TreatmentPrice.Text.Length > 0;
        }

        private void textBox_TreatmentPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_PatientInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox_Date_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox_TreatmentPrice_TextChanged(object sender, EventArgs e)
        {
            UpdatePriceWithDiscount();
        }

        private void textBox_Discount_TextChanged(object sender, EventArgs e)
        {
            UpdatePriceWithDiscount();
        }

        private void UpdatePriceWithDiscount()
        {
            if (textBox_TreatmentPrice.Text.Length > 0 && textBox_Discount.Text.Length > 0)
            {
                CalcPriceWithDiscount();
            }
            else if (textBox_TreatmentPrice.Text.Length == 0 || textBox_Discount.Text.Length == 0)
            {
                textBox_PriceWithDiscount.Text = "";
            }
        }
        private void CalcPriceWithDiscount()
        {
            var treatmentPrice = decimal.Parse(textBox_TreatmentPrice.Text);
            var textDiscount = textBox_Discount.Text;

            var discount = decimal.Parse(textDiscount);
            textBox_PriceWithDiscount.Text = (treatmentPrice * (1 - (discount / 100))).ToString();
        }
    }
}

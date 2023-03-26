using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paid_clinic_Labwork_
{
    public partial class RegistrationMenu : Form
    {
        List<Doctor> _doctors;
        List<Patient> _patients;

        public RegistrationMenu(List<Doctor> doctors, List<Patient> patients)
        {
            _doctors = doctors;
            _patients = patients;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Icon = new Icon("clinic-icon.ico");
        }

        private void button_SignUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Name.Text) || string.IsNullOrEmpty(textBox_Password.Text) || string.IsNullOrEmpty(maskedTextBox_Birthdate.Text))
            {
                MessageBox.Show("Усі дані не введені", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool isNamePasswordUnique = !_doctors.Any(d => d.Name == textBox_Name.Text && d.Password == textBox_Password.Text)
                        && !_patients.Any(p => p.Name == textBox_Name.Text && p.Password == textBox_Password.Text);

            if (!isNamePasswordUnique)
            {
                MessageBox.Show("Даний пароль не підходить", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (comboBox1.SelectedIndex == 0)
            {
                _patients.Add(new Patient() { Name = textBox_Name.Text, Birthdate = DateTime.Parse(maskedTextBox_Birthdate.Text), Password = textBox_Password.Text, SocialDiscount = radioButton_HasDiscount.Checked, Appointments = new List<Appointment>() });
            }
            else if (!string.IsNullOrEmpty(textBox_Specialuzation.Text))
            {
                _doctors.Add(new Doctor() { Name = textBox_Name.Text, Birthdate = DateTime.Parse(maskedTextBox_Birthdate.Text), Password = textBox_Password.Text, Specialization = textBox_Specialuzation.Text, Appointments = new List<Appointment>() });
            }
            else
            {
                MessageBox.Show("Усі дані не введені", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }


        private void RegistrationMenu_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Пацієнт");
            comboBox1.Items.Add("Лікар");
            comboBox1.SelectedIndex = 0;

            radioButton_NoDiscount.Checked = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label_Specialization.Hide();
                textBox_Specialuzation.Hide();

                radioButton_HasDiscount.Show();
                radioButton_NoDiscount.Show();
                label_SocialDiscount.Show();
            }
            else
            {
                label_Specialization.Show();
                textBox_Specialuzation.Show();

                radioButton_HasDiscount.Hide();
                radioButton_NoDiscount.Hide();
                label_SocialDiscount.Hide();
            }
        }

        private void radioButton_HasDiscount_Click(object sender, EventArgs e)
        {
            if (radioButton_HasDiscount.Checked == true)
            {
                radioButton_NoDiscount.Checked = false;
            }
        }

        private void radioButton_NoDiscount_Click(object sender, EventArgs e)
        {
            if (radioButton_NoDiscount.Checked == true)
            {
                radioButton_HasDiscount.Checked = false;
            }
        }

        private void textBox_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

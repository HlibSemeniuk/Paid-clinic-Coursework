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
    public partial class SignInMenu : Form
    {
        List<Doctor> _doctors;
        List<Patient> _patients;

        public SignInMenu(List<Patient> patients, List<Doctor> doctors)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            _patients = patients;
            _doctors = doctors;
            Icon = new Icon("clinic-icon.ico");
        }

        private void button_SignIn_Click(object sender, EventArgs e)
        {
            var name = textBox_Name.Text.Trim();
            var password = textBox_Password.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Усі дані не введені", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var user = _doctors.FirstOrDefault(d => d.Name == name) as User ?? _patients.FirstOrDefault(p => p.Name == name);

            if (user == null)
            {
                MessageBox.Show($"Користувача {name} не знайдено", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (user.Password != password)
            {
                MessageBox.Show("Неправильний пароль", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (user is Doctor doctor)
            {
                var doctorMenu = new DoctorMenu(doctor);
                this.Hide();
                doctorMenu.ShowDialog();
                this.Show();
            }
            else if (user is Patient patient)
            {
                var patientMenu = new PatientMenu(patient, _doctors);
                this.Hide();
                patientMenu.ShowDialog();
                this.Show();
            }
        }

        private void button_Registration_Click(object sender, EventArgs e)
        {
            RegistrationMenu registrationMenu = new RegistrationMenu(_doctors, _patients);
            this.Hide();
            registrationMenu.ShowDialog();
            this.Show();
        }


    }
}

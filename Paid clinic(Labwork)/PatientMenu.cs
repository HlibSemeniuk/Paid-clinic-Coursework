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
    public partial class PatientMenu : Form
    {
        List<Doctor> _doctors;
        Patient _patient = new Patient();
        int _selectedRow;

        public PatientMenu(Patient patient, List<Doctor> doctors)
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            _doctors = doctors;
            _patient = patient;
            Icon = new Icon("clinic-icon.ico");
        }

        private void button_ShowDetails_Click(object sender, EventArgs e)
        {
            if (_selectedRow >= 0)
            {
                var name = dataGridView1.Rows[_selectedRow].Cells[0].Value.ToString();
                DateTime date = DateTime.Parse(dataGridView1.Rows[_selectedRow].Cells[2].Value.ToString());
                var appoitnment = _patient.Appointments.First(a => a.Doctor.Name == name && a.Date == date);

                AppointmentDetails appointmentDetails = new AppointmentDetails(appoitnment, false);

                appointmentDetails.Show();
            }
        }

        private void PatientMenu_Load(object sender, EventArgs e)
        {
            label_Greeting.Text = $"Вітаємо, {_patient.Name}";
            comboBox1.Items.Add("Записи на прийоми");
            comboBox1.Items.Add("Архів прийомів");

            CreateColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (CheckIfSheduledExist())
            {
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                comboBox1.SelectedIndex = 1;
            }
        }

        private bool CheckIfSheduledExist()
        {
           return _patient.Appointments.Exists(a => a.IsHappened == false);
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Name", "Ім'я та прізвище лікаря");
            dataGridView1.Columns.Add("Specialization", "Спеціалізація");
            dataGridView1.Columns.Add("Date", "Дата");
        }

        private void RefreshDataGrid(DataGridView dgv, bool isforArchivedAppointment)
        {
            dgv.Rows.Clear();

            List<Appointment> appointments = _patient.Appointments.FindAll(a => a.IsHappened == isforArchivedAppointment);

            foreach (var appointment in appointments)
            {
                var patientName = appointment.Doctor.Name;
                dgv.Rows.Add(patientName, appointment.Doctor.Specialization, appointment.Date.ToString("dd.MM.yyyy HH:mm"));
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (!CheckIfSheduledExist())
                {
                    MessageBox.Show("Зараз прийомів не заплановано", "Інформування", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBox1.SelectedIndex = 1;
                    button_ShowDetails.Show();
                }
                else
                {
                    RefreshDataGrid(dataGridView1, false);
                    button_ShowDetails.Hide();
                }
            }
            else
            {
                RefreshDataGrid(dataGridView1, true);
                button_ShowDetails.Show();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedRow = e.RowIndex;
        }

        private void button_MakeAppointment_Click(object sender, EventArgs e)
        {
            var appointmentMenu = new AppointmentMenu(_patient, _doctors);
            appointmentMenu.ShowDialog();
            comboBox1.SelectedIndex = 0;
            RefreshDataGrid(dataGridView1, false);
        }
    }
}

using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Paid_clinic_Labwork_
{
    public partial class DoctorMenu : Form
    {
        Doctor _doctor = new Doctor();
        int _selectedRow;

        public DoctorMenu(Doctor doctor)
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            _doctor = doctor;
            Icon = new Icon("clinic-icon.ico");
        }

        private void DoctorMenu_Load(object sender, EventArgs e)
        {
            label_Greeting.Text = $"Вітаємо, {_doctor.Specialization} {_doctor.Name}";
            comboBox1.Items.Add("Прийоми");
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
            return _doctor.Appointments.Exists(a => a.IsHappened == false);
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Name", "Ім'я та прізвище пацієнта");
            dataGridView1.Columns.Add("Date", "Дата");
        }

        private void RefreshDataGrid(DataGridView dgv, bool isforArchivedAppointment)
        {
            dgv.Rows.Clear();

            List<Appointment> appointments = _doctor.Appointments.FindAll(a => a.IsHappened == isforArchivedAppointment);

            foreach (var appointment in appointments)
            {
                var patientName = appointment.Patient.Name;
                dgv.Rows.Add(patientName, appointment.Date.ToString("dd.MM.yyyy HH:mm"));
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedRow = 0;
            bool isScheduled = CheckIfSheduledExist();
            if (comboBox1.SelectedIndex == 0)
            {
                if (!CheckIfSheduledExist())
                {
                    MessageBox.Show("Зараз прийомів не заплановано", "Інформування", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBox1.SelectedIndex = 1;
                    button_StartExamination.Hide();
                    button_ShowDetails.Show();
                }
                else
                {
                    RefreshDataGrid(dataGridView1, false);
                    button_ShowDetails.Hide();
                    button_StartExamination.Show();
                }
            }
            else
            {
                RefreshDataGrid(dataGridView1, true);
                button_ShowDetails.Show();
                button_StartExamination.Hide();
            }
        }

        private void button_ShowDetails_Click(object sender, EventArgs e)
        {
            if (_selectedRow >= 0)
            {
                var name = dataGridView1.Rows[_selectedRow].Cells[0].Value.ToString();
                DateTime date = DateTime.Parse(dataGridView1.Rows[_selectedRow].Cells[1].Value.ToString());
                var appoitnment = _doctor.Appointments.First(a => a.Patient.Name == name && a.Date == date);

                AppointmentDetails appointmentDetails = new AppointmentDetails(appoitnment, true);

                appointmentDetails.Show();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedRow = e.RowIndex;
        }

        private void button_StartExamination_Click(object sender, EventArgs e)
        {
            if (_selectedRow >= 0)
            {
                var name = dataGridView1.Rows[_selectedRow].Cells[0].Value.ToString();
                DateTime date = DateTime.Parse(dataGridView1.Rows[_selectedRow].Cells[1].Value.ToString());
                var appoitnment = _doctor.Appointments.First(a => a.Patient.Name == name && a.Date == date);

                ExaminationMenu examinationMenu = new ExaminationMenu(appoitnment);
                examinationMenu.ShowDialog();

                if (CheckIfSheduledExist())
                {
                    RefreshDataGrid(dataGridView1, false);
                }
                else
                {
                    comboBox1.SelectedIndex = 1;
                }
            }
                
        }
    }
}

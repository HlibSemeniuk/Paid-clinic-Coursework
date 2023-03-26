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
    public partial class AppointmentMenu : Form
    {
        List<Doctor> _doctors;
        Patient _patient = new Patient();
        int _selectedRow;

        public AppointmentMenu(Patient patient, List<Doctor> doctors)
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            _doctors = doctors;
            _patient = patient;

            Icon = new Icon("clinic-icon.ico");
        }




        private void button_MakeAppointment_Click(object sender, EventArgs e)
        {
            if (_selectedRow >= 0)
            {
                var doctor = _doctors[_selectedRow];
                var date = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day, dateTimePicker.Value.Hour, dateTimePicker.Value.Minute, 0);
                var appointment = new Appointment() { Patient = _patient, Doctor = doctor, Date = date, Examination = new Examination(), IsHappened = false };
                _patient.Appointments.Add(appointment);
                doctor.Appointments.Add(appointment);

                MessageBox.Show("Ви успішно записались!", "Виконано", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Ви не обрали лікаря", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AppointmentMenu_Load(object sender, EventArgs e)
        {
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "dd/MM/yyyy hh:mm";
            CreateColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RefreshDataGrid();
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Name", "Лікар");
            dataGridView1.Columns.Add("Date", "Спеціалізація");
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void RefreshDataGrid()
        {
            dataGridView1.Rows.Clear();

            foreach (var doctor in _doctors)
            {
                dataGridView1.Rows.Add(doctor.Name, doctor.Specialization);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedRow = e.RowIndex;
            if (_selectedRow >= 0 ) 
            {
                textBox_DoctorInfo.Text = _doctors[_selectedRow].Name + ", " + _doctors[_selectedRow].Specialization;
            } 
        }

        private void textBox_DoctorInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

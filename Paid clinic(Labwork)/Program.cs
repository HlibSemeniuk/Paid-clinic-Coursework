using Entities;
using System.Runtime.CompilerServices;

namespace Paid_clinic_Labwork_
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        static void InitializeData(List<Doctor> doctors, List<Patient> patients)
        {
            var doctor = new Doctor
            {
                Name = "Іван Іванов",
                Birthdate = new DateTime(1970, 1, 1),
                Password = "doctorpassword",
                Specialization = "кардіолог"
            };

            var patient = new Patient
            {
                Name = "Марія Петренко",
                Birthdate = new DateTime(1985, 3, 15),
                Password = "patientpassword",
                SocialDiscount = true
            };

            var examination = new Examination
            {
                Symptoms = "Біль в грудях, запаморочення",
                Diagnosis = "Стенокардія",

                Treatment = new Treatment
                {
                    Recommendations = "Прогулянки на свіжому повітрі",
                    Medicines = "Нітрогліцерин",
                    TreatmentPrice = 1000m,
                    SocialDiscountPercent = 25f
                }
            };

            examination.Treatment.ApplySocialDiscount();

            var appointment = new Appointment
            {
                Date = new DateTime(2023, 4, 1, 10, 0, 0),
                IsHappened = true,
                Doctor = doctor,
                Patient = patient,
                Examination = examination
            };

            doctor.Appointments = new List<Appointment> { appointment };
            patient.Appointments = new List<Appointment> { appointment };

            var doctor2 = new Doctor
            {
                Name = "Оксана Іваненко",
                Birthdate = new DateTime(1985, 7, 20),
                Password = "doctorpass",
                Specialization = "дерматолог"
            };

            var patient2 = new Patient
            {
                Name = "Володимир Лисенко",
                Birthdate = new DateTime(1978, 4, 10),
                Password = "patientpass",
                SocialDiscount = false
            };

            var examination2 = new Examination
            {
                Symptoms = "Червоні висипання на тілі",
                Diagnosis = "Алергія на їжу",
                Treatment = new Treatment
                {
                    Recommendations = "Дотримуватись дієти",
                    Medicines = "Антигістаміни",
                    TreatmentPrice = 500m,
                    SocialDiscountPercent = 16f
                }
            };

            var appointment2 = new Appointment
            {
                Date = new DateTime(2023, 3, 30, 14, 0, 0),
                IsHappened = true,
                Doctor = doctor2,
                Patient = patient2,
                Examination = examination2
            };

            doctor2.Appointments = new List<Appointment> { appointment2 };
            patient2.Appointments = new List<Appointment> { appointment2 };

            doctors.Add(doctor);
            doctors.Add(doctor2);

            patients.Add(patient);
            patients.Add(patient2);
        }

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            List<Doctor> doctors = new List<Doctor>();
            List< Patient> patients = new List<Patient>();

            InitializeData(doctors, patients);
            Application.Run(new SignInMenu(patients, doctors));
        }
    }
}
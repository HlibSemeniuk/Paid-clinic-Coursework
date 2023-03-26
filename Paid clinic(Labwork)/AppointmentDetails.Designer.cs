namespace Paid_clinic_Labwork_
{
    partial class AppointmentDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_Symptoms = new Label();
            label_Diagnosis = new Label();
            label_Medicines = new Label();
            label_Recommendations = new Label();
            label1 = new Label();
            textBox_Symptoms = new TextBox();
            textBox_Diagnosis = new TextBox();
            textBox_Medicines = new TextBox();
            textBox_Recommendations = new TextBox();
            textBox_TreatmentPrice = new TextBox();
            label_Date = new Label();
            textBox_Date = new TextBox();
            textBox_Name = new TextBox();
            label_Person = new Label();
            SuspendLayout();
            // 
            // label_Symptoms
            // 
            label_Symptoms.AutoSize = true;
            label_Symptoms.Location = new Point(27, 73);
            label_Symptoms.Name = "label_Symptoms";
            label_Symptoms.Size = new Size(69, 15);
            label_Symptoms.TabIndex = 0;
            label_Symptoms.Text = "Симптоми:";
            // 
            // label_Diagnosis
            // 
            label_Diagnosis.AutoSize = true;
            label_Diagnosis.Location = new Point(45, 102);
            label_Diagnosis.Name = "label_Diagnosis";
            label_Diagnosis.Size = new Size(51, 15);
            label_Diagnosis.TabIndex = 1;
            label_Diagnosis.Text = "Діагноз:";
            // 
            // label_Medicines
            // 
            label_Medicines.AutoSize = true;
            label_Medicines.Location = new Point(62, 180);
            label_Medicines.Name = "label_Medicines";
            label_Medicines.Size = new Size(34, 15);
            label_Medicines.TabIndex = 2;
            label_Medicines.Text = "Ліки:";
            // 
            // label_Recommendations
            // 
            label_Recommendations.AutoSize = true;
            label_Recommendations.Location = new Point(13, 130);
            label_Recommendations.Name = "label_Recommendations";
            label_Recommendations.Size = new Size(83, 15);
            label_Recommendations.TabIndex = 3;
            label_Recommendations.Text = "Рекомендації:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 212);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 4;
            label1.Text = "Ціна лікування:";
            // 
            // textBox_Symptoms
            // 
            textBox_Symptoms.Location = new Point(102, 70);
            textBox_Symptoms.Name = "textBox_Symptoms";
            textBox_Symptoms.Size = new Size(206, 23);
            textBox_Symptoms.TabIndex = 5;
            textBox_Symptoms.KeyPress += textBox_Symptoms_KeyPress;
            // 
            // textBox_Diagnosis
            // 
            textBox_Diagnosis.Location = new Point(102, 99);
            textBox_Diagnosis.Name = "textBox_Diagnosis";
            textBox_Diagnosis.Size = new Size(206, 23);
            textBox_Diagnosis.TabIndex = 6;
            textBox_Diagnosis.KeyPress += textBox_Diagnosis_KeyPress;
            // 
            // textBox_Medicines
            // 
            textBox_Medicines.Location = new Point(102, 180);
            textBox_Medicines.Name = "textBox_Medicines";
            textBox_Medicines.Size = new Size(206, 23);
            textBox_Medicines.TabIndex = 7;
            textBox_Medicines.KeyPress += textBox_Medicines_KeyPress;
            // 
            // textBox_Recommendations
            // 
            textBox_Recommendations.Location = new Point(102, 127);
            textBox_Recommendations.Multiline = true;
            textBox_Recommendations.Name = "textBox_Recommendations";
            textBox_Recommendations.Size = new Size(206, 44);
            textBox_Recommendations.TabIndex = 8;
            textBox_Recommendations.KeyPress += textBox_Recommendations_KeyPress;
            // 
            // textBox_TreatmentPrice
            // 
            textBox_TreatmentPrice.Location = new Point(102, 209);
            textBox_TreatmentPrice.Name = "textBox_TreatmentPrice";
            textBox_TreatmentPrice.Size = new Size(206, 23);
            textBox_TreatmentPrice.TabIndex = 9;
            textBox_TreatmentPrice.KeyPress += textBox_TreatmentPrice_KeyPress;
            // 
            // label_Date
            // 
            label_Date.AutoSize = true;
            label_Date.Location = new Point(61, 44);
            label_Date.Name = "label_Date";
            label_Date.Size = new Size(35, 15);
            label_Date.TabIndex = 10;
            label_Date.Text = "Дата:";
            // 
            // textBox_Date
            // 
            textBox_Date.Location = new Point(102, 41);
            textBox_Date.Name = "textBox_Date";
            textBox_Date.Size = new Size(206, 23);
            textBox_Date.TabIndex = 11;
            textBox_Date.KeyPress += textBox_Date_KeyPress;
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(102, 12);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(206, 23);
            textBox_Name.TabIndex = 12;
            textBox_Name.KeyPress += textBox_Name_KeyPress;
            // 
            // label_Person
            // 
            label_Person.AutoSize = true;
            label_Person.Location = new Point(45, 12);
            label_Person.Name = "label_Person";
            label_Person.Size = new Size(32, 15);
            label_Person.TabIndex = 13;
            label_Person.Text = "label";
            // 
            // AppointmentDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 239);
            Controls.Add(label_Person);
            Controls.Add(textBox_Name);
            Controls.Add(textBox_Date);
            Controls.Add(label_Date);
            Controls.Add(textBox_TreatmentPrice);
            Controls.Add(textBox_Recommendations);
            Controls.Add(textBox_Medicines);
            Controls.Add(textBox_Diagnosis);
            Controls.Add(textBox_Symptoms);
            Controls.Add(label1);
            Controls.Add(label_Recommendations);
            Controls.Add(label_Medicines);
            Controls.Add(label_Diagnosis);
            Controls.Add(label_Symptoms);
            Name = "AppointmentDetails";
            Text = "AppointmentDetails";
            Load += AppointmentDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Symptoms;
        private Label label_Diagnosis;
        private Label label_Medicines;
        private Label label_Recommendations;
        private Label label1;
        private TextBox textBox_Symptoms;
        private TextBox textBox_Diagnosis;
        private TextBox textBox_Medicines;
        private TextBox textBox_Recommendations;
        private TextBox textBox_TreatmentPrice;
        private Label label_Date;
        private TextBox textBox_Date;
        private TextBox textBox_Name;
        private Label label_Person;
    }
}
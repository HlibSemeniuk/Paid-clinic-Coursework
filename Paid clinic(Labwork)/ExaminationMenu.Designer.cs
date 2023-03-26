namespace Paid_clinic_Labwork_
{
    partial class ExaminationMenu
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
            textBox_Date = new TextBox();
            label_Date = new Label();
            textBox_TreatmentPrice = new TextBox();
            textBox_Recommendations = new TextBox();
            textBox_Medicines = new TextBox();
            textBox_Diagnosis = new TextBox();
            textBox_Symptoms = new TextBox();
            label1 = new Label();
            label_Recommendations = new Label();
            label_Medicines = new Label();
            label_Diagnosis = new Label();
            label_Symptoms = new Label();
            label_Discount = new Label();
            label_PatientInfo = new Label();
            textBox_PatientInfo = new TextBox();
            textBox_Discount = new TextBox();
            button_EndAppointment = new Button();
            textBox_PriceWithDiscount = new TextBox();
            label_PriceWithDiscount = new Label();
            SuspendLayout();
            // 
            // textBox_Date
            // 
            textBox_Date.Location = new Point(102, 41);
            textBox_Date.Name = "textBox_Date";
            textBox_Date.Size = new Size(206, 23);
            textBox_Date.TabIndex = 23;
            textBox_Date.KeyPress += textBox_Date_KeyPress;
            // 
            // label_Date
            // 
            label_Date.AutoSize = true;
            label_Date.Location = new Point(59, 44);
            label_Date.Name = "label_Date";
            label_Date.Size = new Size(35, 15);
            label_Date.TabIndex = 22;
            label_Date.Text = "Дата:";
            // 
            // textBox_TreatmentPrice
            // 
            textBox_TreatmentPrice.Location = new Point(102, 207);
            textBox_TreatmentPrice.Name = "textBox_TreatmentPrice";
            textBox_TreatmentPrice.Size = new Size(102, 23);
            textBox_TreatmentPrice.TabIndex = 21;
            textBox_TreatmentPrice.TextChanged += textBox_TreatmentPrice_TextChanged;
            textBox_TreatmentPrice.KeyPress += textBox_TreatmentPrice_KeyPress;
            // 
            // textBox_Recommendations
            // 
            textBox_Recommendations.Location = new Point(102, 128);
            textBox_Recommendations.Multiline = true;
            textBox_Recommendations.Name = "textBox_Recommendations";
            textBox_Recommendations.Size = new Size(204, 44);
            textBox_Recommendations.TabIndex = 20;
            // 
            // textBox_Medicines
            // 
            textBox_Medicines.Location = new Point(102, 178);
            textBox_Medicines.Name = "textBox_Medicines";
            textBox_Medicines.Size = new Size(206, 23);
            textBox_Medicines.TabIndex = 19;
            // 
            // textBox_Diagnosis
            // 
            textBox_Diagnosis.Location = new Point(102, 99);
            textBox_Diagnosis.Name = "textBox_Diagnosis";
            textBox_Diagnosis.Size = new Size(206, 23);
            textBox_Diagnosis.TabIndex = 18;
            // 
            // textBox_Symptoms
            // 
            textBox_Symptoms.Location = new Point(102, 70);
            textBox_Symptoms.Name = "textBox_Symptoms";
            textBox_Symptoms.Size = new Size(206, 23);
            textBox_Symptoms.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 210);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 16;
            label1.Text = "Ціна лікування:";
            // 
            // label_Recommendations
            // 
            label_Recommendations.AutoSize = true;
            label_Recommendations.Location = new Point(13, 131);
            label_Recommendations.Name = "label_Recommendations";
            label_Recommendations.Size = new Size(83, 15);
            label_Recommendations.TabIndex = 15;
            label_Recommendations.Text = "Рекомендації:";
            // 
            // label_Medicines
            // 
            label_Medicines.AutoSize = true;
            label_Medicines.Location = new Point(60, 181);
            label_Medicines.Name = "label_Medicines";
            label_Medicines.Size = new Size(34, 15);
            label_Medicines.TabIndex = 14;
            label_Medicines.Text = "Ліки:";
            // 
            // label_Diagnosis
            // 
            label_Diagnosis.AutoSize = true;
            label_Diagnosis.Location = new Point(45, 102);
            label_Diagnosis.Name = "label_Diagnosis";
            label_Diagnosis.Size = new Size(51, 15);
            label_Diagnosis.TabIndex = 13;
            label_Diagnosis.Text = "Діагноз:";
            // 
            // label_Symptoms
            // 
            label_Symptoms.AutoSize = true;
            label_Symptoms.Location = new Point(27, 73);
            label_Symptoms.Name = "label_Symptoms";
            label_Symptoms.Size = new Size(69, 15);
            label_Symptoms.TabIndex = 12;
            label_Symptoms.Text = "Симптоми:";
            // 
            // label_Discount
            // 
            label_Discount.AutoSize = true;
            label_Discount.Location = new Point(42, 239);
            label_Discount.Name = "label_Discount";
            label_Discount.Size = new Size(52, 15);
            label_Discount.TabIndex = 24;
            label_Discount.Text = "Знижка:";
            // 
            // label_PatientInfo
            // 
            label_PatientInfo.AutoSize = true;
            label_PatientInfo.Location = new Point(43, 15);
            label_PatientInfo.Name = "label_PatientInfo";
            label_PatientInfo.Size = new Size(53, 15);
            label_PatientInfo.TabIndex = 25;
            label_PatientInfo.Text = "Пацієнт:";
            // 
            // textBox_PatientInfo
            // 
            textBox_PatientInfo.Location = new Point(102, 12);
            textBox_PatientInfo.Name = "textBox_PatientInfo";
            textBox_PatientInfo.Size = new Size(204, 23);
            textBox_PatientInfo.TabIndex = 26;
            textBox_PatientInfo.KeyPress += textBox_PatientInfo_KeyPress;
            // 
            // textBox_Discount
            // 
            textBox_Discount.Location = new Point(102, 236);
            textBox_Discount.Name = "textBox_Discount";
            textBox_Discount.Size = new Size(102, 23);
            textBox_Discount.TabIndex = 27;
            textBox_Discount.TextChanged += textBox_Discount_TextChanged;
            textBox_Discount.KeyPress += textBox_Discount_KeyPress;
            // 
            // button_EndAppointment
            // 
            button_EndAppointment.Location = new Point(129, 294);
            button_EndAppointment.Name = "button_EndAppointment";
            button_EndAppointment.Size = new Size(119, 23);
            button_EndAppointment.TabIndex = 28;
            button_EndAppointment.Text = "Закінчити прийом";
            button_EndAppointment.UseVisualStyleBackColor = true;
            button_EndAppointment.Click += button_EndAppointment_Click;
            // 
            // textBox_PriceWithDiscount
            // 
            textBox_PriceWithDiscount.Location = new Point(102, 265);
            textBox_PriceWithDiscount.Name = "textBox_PriceWithDiscount";
            textBox_PriceWithDiscount.Size = new Size(102, 23);
            textBox_PriceWithDiscount.TabIndex = 29;
            textBox_PriceWithDiscount.KeyPress += textBox_PriceWithDiscount_KeyPress;
            // 
            // label_PriceWithDiscount
            // 
            label_PriceWithDiscount.AutoSize = true;
            label_PriceWithDiscount.Location = new Point(22, 268);
            label_PriceWithDiscount.Name = "label_PriceWithDiscount";
            label_PriceWithDiscount.Size = new Size(74, 15);
            label_PriceWithDiscount.TabIndex = 30;
            label_PriceWithDiscount.Text = "Зі знижкою:";
            // 
            // ExaminationMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 321);
            Controls.Add(label_PriceWithDiscount);
            Controls.Add(textBox_PriceWithDiscount);
            Controls.Add(button_EndAppointment);
            Controls.Add(textBox_Discount);
            Controls.Add(textBox_PatientInfo);
            Controls.Add(label_PatientInfo);
            Controls.Add(label_Discount);
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
            Name = "ExaminationMenu";
            Text = "ExaminationMenu";
            Load += ExaminationMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Date;
        private Label label_Date;
        private TextBox textBox_TreatmentPrice;
        private TextBox textBox_Recommendations;
        private TextBox textBox_Medicines;
        private TextBox textBox_Diagnosis;
        private TextBox textBox_Symptoms;
        private Label label1;
        private Label label_Recommendations;
        private Label label_Medicines;
        private Label label_Diagnosis;
        private Label label_Symptoms;
        private Label label_Discount;
        private Label label_PatientInfo;
        private TextBox textBox_PatientInfo;
        private TextBox textBox_Discount;
        private Button button_EndAppointment;
        private TextBox textBox_PriceWithDiscount;
        private Label label_PriceWithDiscount;
    }
}
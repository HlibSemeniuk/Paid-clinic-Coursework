namespace Paid_clinic_Labwork_
{
    partial class AppointmentMenu
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
            dataGridView1 = new DataGridView();
            dateTimePicker = new DateTimePicker();
            button_MakeAppointment = new Button();
            textBox_DoctorInfo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(104, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(103, 211);
            dateTimePicker.MaxDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dateTimePicker.MinDate = new DateTime(2023, 3, 26, 0, 0, 0, 0);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(240, 23);
            dateTimePicker.TabIndex = 1;
            // 
            // button_MakeAppointment
            // 
            button_MakeAppointment.Location = new Point(177, 240);
            button_MakeAppointment.Name = "button_MakeAppointment";
            button_MakeAppointment.Size = new Size(78, 23);
            button_MakeAppointment.TabIndex = 2;
            button_MakeAppointment.Text = "Записатись";
            button_MakeAppointment.UseVisualStyleBackColor = true;
            button_MakeAppointment.Click += button_MakeAppointment_Click;
            // 
            // textBox_DoctorInfo
            // 
            textBox_DoctorInfo.Location = new Point(103, 185);
            textBox_DoctorInfo.Name = "textBox_DoctorInfo";
            textBox_DoctorInfo.Size = new Size(241, 23);
            textBox_DoctorInfo.TabIndex = 3;
            textBox_DoctorInfo.KeyPress += textBox_DoctorInfo_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 185);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 4;
            label1.Text = "Лікар:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 215);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 5;
            label2.Text = "Дата прийому:";
            // 
            // AppointmentMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 267);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_DoctorInfo);
            Controls.Add(button_MakeAppointment);
            Controls.Add(dateTimePicker);
            Controls.Add(dataGridView1);
            Name = "AppointmentMenu";
            Text = "AppointmentMenu";
            Load += AppointmentMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker;
        private Button button_MakeAppointment;
        private TextBox textBox_DoctorInfo;
        private Label label1;
        private Label label2;
    }
}
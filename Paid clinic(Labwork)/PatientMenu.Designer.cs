namespace Paid_clinic_Labwork_
{
    partial class PatientMenu
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
            button_ShowDetails = new Button();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            label_Greeting = new Label();
            button_MakeAppointment = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button_ShowDetails
            // 
            button_ShowDetails.Location = new Point(261, 234);
            button_ShowDetails.Name = "button_ShowDetails";
            button_ShowDetails.Size = new Size(75, 23);
            button_ShowDetails.TabIndex = 7;
            button_ShowDetails.Text = "Подробиці";
            button_ShowDetails.UseVisualStyleBackColor = true;
            button_ShowDetails.Click += button_ShowDetails_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(24, 49);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(391, 150);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label_Greeting
            // 
            label_Greeting.AutoSize = true;
            label_Greeting.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Greeting.Location = new Point(24, 7);
            label_Greeting.Name = "label_Greeting";
            label_Greeting.Size = new Size(121, 25);
            label_Greeting.TabIndex = 4;
            label_Greeting.Text = "Привітання";
            // 
            // button_MakeAppointment
            // 
            button_MakeAppointment.Location = new Point(89, 234);
            button_MakeAppointment.Name = "button_MakeAppointment";
            button_MakeAppointment.Size = new Size(83, 23);
            button_MakeAppointment.TabIndex = 8;
            button_MakeAppointment.Text = "Записатись";
            button_MakeAppointment.UseVisualStyleBackColor = true;
            button_MakeAppointment.Click += button_MakeAppointment_Click;
            // 
            // PatientMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 298);
            Controls.Add(button_MakeAppointment);
            Controls.Add(button_ShowDetails);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label_Greeting);
            Name = "PatientMenu";
            Text = "PatientMenu";
            Load += PatientMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_ShowDetails;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Label label_Greeting;
        private Button button_MakeAppointment;
    }
}
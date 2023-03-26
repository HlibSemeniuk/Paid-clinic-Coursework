namespace Paid_clinic_Labwork_
{
    partial class DoctorMenu
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
            label_Greeting = new Label();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            button_ShowDetails = new Button();
            button_StartExamination = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label_Greeting
            // 
            label_Greeting.AutoSize = true;
            label_Greeting.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Greeting.Location = new Point(36, 9);
            label_Greeting.Name = "label_Greeting";
            label_Greeting.Size = new Size(121, 25);
            label_Greeting.TabIndex = 0;
            label_Greeting.Text = "Привітання";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(391, 150);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(36, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button_ShowDetails
            // 
            button_ShowDetails.Location = new Point(180, 236);
            button_ShowDetails.Name = "button_ShowDetails";
            button_ShowDetails.Size = new Size(75, 23);
            button_ShowDetails.TabIndex = 3;
            button_ShowDetails.Text = "Подробиці";
            button_ShowDetails.UseVisualStyleBackColor = true;
            button_ShowDetails.Click += button_ShowDetails_Click;
            // 
            // button_StartExamination
            // 
            button_StartExamination.Location = new Point(180, 236);
            button_StartExamination.Name = "button_StartExamination";
            button_StartExamination.Size = new Size(109, 23);
            button_StartExamination.TabIndex = 4;
            button_StartExamination.Text = "Почати прийом";
            button_StartExamination.UseVisualStyleBackColor = true;
            button_StartExamination.Click += button_StartExamination_Click;
            // 
            // DoctorMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 300);
            Controls.Add(button_StartExamination);
            Controls.Add(button_ShowDetails);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label_Greeting);
            Name = "DoctorMenu";
            Text = "DoctorMenu";
            Load += DoctorMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Greeting;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Button button_ShowDetails;
        private Button button_StartExamination;
    }
}
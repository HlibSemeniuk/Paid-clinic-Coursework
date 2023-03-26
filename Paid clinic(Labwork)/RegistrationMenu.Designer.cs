namespace Paid_clinic_Labwork_
{
    partial class RegistrationMenu
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
            label_Name = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label_Specialization = new Label();
            comboBox1 = new ComboBox();
            textBox_Name = new TextBox();
            maskedTextBox_Birthdate = new MaskedTextBox();
            textBox_Password = new TextBox();
            textBox_Specialuzation = new TextBox();
            button_SignUp = new Button();
            label_SocialDiscount = new Label();
            radioButton_HasDiscount = new RadioButton();
            radioButton_NoDiscount = new RadioButton();
            SuspendLayout();
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Location = new Point(9, 42);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(100, 15);
            label_Name.TabIndex = 0;
            label_Name.Text = "Ім'я та прізвище:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 15);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Хто ви?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 70);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 2;
            label2.Text = "Дата народження:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 102);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 3;
            label3.Text = "Пароль:";
            // 
            // label_Specialization
            // 
            label_Specialization.AutoSize = true;
            label_Specialization.Location = new Point(22, 133);
            label_Specialization.Name = "label_Specialization";
            label_Specialization.Size = new Size(84, 15);
            label_Specialization.TabIndex = 4;
            label_Specialization.Text = "Спеціалізація:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(112, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(145, 23);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(112, 41);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(145, 23);
            textBox_Name.TabIndex = 6;
            textBox_Name.KeyPress += textBox_Name_KeyPress;
            // 
            // maskedTextBox_Birthdate
            // 
            maskedTextBox_Birthdate.Location = new Point(112, 70);
            maskedTextBox_Birthdate.Mask = "00/00/0000";
            maskedTextBox_Birthdate.Name = "maskedTextBox_Birthdate";
            maskedTextBox_Birthdate.Size = new Size(145, 23);
            maskedTextBox_Birthdate.TabIndex = 7;
            maskedTextBox_Birthdate.ValidatingType = typeof(DateTime);
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(112, 99);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(145, 23);
            textBox_Password.TabIndex = 8;
            // 
            // textBox_Specialuzation
            // 
            textBox_Specialuzation.Location = new Point(112, 128);
            textBox_Specialuzation.Name = "textBox_Specialuzation";
            textBox_Specialuzation.Size = new Size(145, 23);
            textBox_Specialuzation.TabIndex = 9;
            // 
            // button_SignUp
            // 
            button_SignUp.Location = new Point(129, 157);
            button_SignUp.Name = "button_SignUp";
            button_SignUp.Size = new Size(110, 23);
            button_SignUp.TabIndex = 10;
            button_SignUp.Text = "Зареєструватись";
            button_SignUp.UseVisualStyleBackColor = true;
            button_SignUp.Click += button_SignUp_Click;
            // 
            // label_SocialDiscount
            // 
            label_SocialDiscount.AutoSize = true;
            label_SocialDiscount.Location = new Point(-1, 133);
            label_SocialDiscount.Name = "label_SocialDiscount";
            label_SocialDiscount.Size = new Size(110, 15);
            label_SocialDiscount.TabIndex = 11;
            label_SocialDiscount.Text = "Соціальна знижка:";
            // 
            // radioButton_HasDiscount
            // 
            radioButton_HasDiscount.AutoSize = true;
            radioButton_HasDiscount.Location = new Point(115, 131);
            radioButton_HasDiscount.Name = "radioButton_HasDiscount";
            radioButton_HasDiscount.Size = new Size(32, 19);
            radioButton_HasDiscount.TabIndex = 12;
            radioButton_HasDiscount.TabStop = true;
            radioButton_HasDiscount.Text = "Є";
            radioButton_HasDiscount.UseVisualStyleBackColor = true;
            radioButton_HasDiscount.Click += radioButton_HasDiscount_Click;
            // 
            // radioButton_NoDiscount
            // 
            radioButton_NoDiscount.AutoSize = true;
            radioButton_NoDiscount.Location = new Point(178, 131);
            radioButton_NoDiscount.Name = "radioButton_NoDiscount";
            radioButton_NoDiscount.Size = new Size(61, 19);
            radioButton_NoDiscount.TabIndex = 13;
            radioButton_NoDiscount.TabStop = true;
            radioButton_NoDiscount.Text = "Немає";
            radioButton_NoDiscount.UseVisualStyleBackColor = true;
            radioButton_NoDiscount.Click += radioButton_NoDiscount_Click;
            // 
            // RegistrationMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 200);
            Controls.Add(radioButton_NoDiscount);
            Controls.Add(radioButton_HasDiscount);
            Controls.Add(label_SocialDiscount);
            Controls.Add(button_SignUp);
            Controls.Add(textBox_Specialuzation);
            Controls.Add(textBox_Password);
            Controls.Add(maskedTextBox_Birthdate);
            Controls.Add(textBox_Name);
            Controls.Add(comboBox1);
            Controls.Add(label_Specialization);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label_Name);
            Name = "RegistrationMenu";
            Text = "RegistrationMenu";
            Load += RegistrationMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Name;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label_Specialization;
        private ComboBox comboBox1;
        private TextBox textBox_Name;
        private MaskedTextBox maskedTextBox_Birthdate;
        private TextBox textBox_Password;
        private TextBox textBox_Specialuzation;
        private Button button_SignUp;
        private Label label_SocialDiscount;
        private RadioButton radioButton_HasDiscount;
        private RadioButton radioButton_NoDiscount;
    }
}
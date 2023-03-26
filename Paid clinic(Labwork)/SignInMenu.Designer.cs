namespace Paid_clinic_Labwork_
{
    partial class SignInMenu
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
            label_Password = new Label();
            textBox_Name = new TextBox();
            textBox_Password = new TextBox();
            button_SignIn = new Button();
            button_Registration = new Button();
            SuspendLayout();
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Location = new Point(12, 9);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(100, 15);
            label_Name.TabIndex = 0;
            label_Name.Text = "Ім'я та прізвище:";
            // 
            // label_Password
            // 
            label_Password.AutoSize = true;
            label_Password.Location = new Point(60, 38);
            label_Password.Name = "label_Password";
            label_Password.Size = new Size(52, 15);
            label_Password.TabIndex = 1;
            label_Password.Text = "Пароль:";
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(118, 6);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(172, 23);
            textBox_Name.TabIndex = 2;
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(118, 35);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(172, 23);
            textBox_Password.TabIndex = 3;
            // 
            // button_SignIn
            // 
            button_SignIn.Location = new Point(105, 64);
            button_SignIn.Name = "button_SignIn";
            button_SignIn.Size = new Size(75, 23);
            button_SignIn.TabIndex = 4;
            button_SignIn.Text = "Увійти";
            button_SignIn.UseVisualStyleBackColor = true;
            button_SignIn.Click += button_SignIn_Click;
            // 
            // button_Registration
            // 
            button_Registration.Location = new Point(195, 64);
            button_Registration.Name = "button_Registration";
            button_Registration.Size = new Size(107, 23);
            button_Registration.TabIndex = 5;
            button_Registration.Text = "Зареєструватись";
            button_Registration.UseVisualStyleBackColor = true;
            button_Registration.Click += button_Registration_Click;
            // 
            // SignInMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 102);
            Controls.Add(button_Registration);
            Controls.Add(button_SignIn);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_Name);
            Controls.Add(label_Password);
            Controls.Add(label_Name);
            Name = "SignInMenu";
            Text = "SignInMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Name;
        private Label label_Password;
        private TextBox textBox_Name;
        private TextBox textBox_Password;
        private Button button_SignIn;
        private Button button_Registration;
    }
}
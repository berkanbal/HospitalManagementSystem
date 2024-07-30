namespace HospitalManagementSystem.Forms
{
    partial class PatientSignUpGUI
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
            rjBtnPatientSignUp = new CustomTools.RJButton.RJButton();
            rjBtnAdminBackMain = new CustomTools.RJButton.RJButton();
            lbl_AdminLoginGUI = new Label();
            textBoxPatientName = new TextBox();
            textBoxPatientSurname = new TextBox();
            textBoxP_GSM_No = new TextBox();
            textBoxP_IdentificationNo = new TextBox();
            textBoxP_AgainPassword = new TextBox();
            textBoxP_Password = new TextBox();
            SuspendLayout();
            // 
            // rjBtnPatientSignUp
            // 
            rjBtnPatientSignUp.BackColor = Color.Black;
            rjBtnPatientSignUp.BackgroundColor = Color.Black;
            rjBtnPatientSignUp.BorderColor = Color.Salmon;
            rjBtnPatientSignUp.BorderRadius = 17;
            rjBtnPatientSignUp.BorderSize = 0;
            rjBtnPatientSignUp.FlatAppearance.BorderSize = 0;
            rjBtnPatientSignUp.FlatStyle = FlatStyle.Flat;
            rjBtnPatientSignUp.Font = new Font("Yu Gothic UI Semibold", 10F);
            rjBtnPatientSignUp.ForeColor = Color.White;
            rjBtnPatientSignUp.Location = new Point(130, 299);
            rjBtnPatientSignUp.Name = "rjBtnPatientSignUp";
            rjBtnPatientSignUp.Size = new Size(140, 31);
            rjBtnPatientSignUp.TabIndex = 33;
            rjBtnPatientSignUp.Text = "Sign Up";
            rjBtnPatientSignUp.TextColor = Color.White;
            rjBtnPatientSignUp.UseVisualStyleBackColor = false;
            rjBtnPatientSignUp.Click += rjBtnPatientSignUp_Click;
            // 
            // rjBtnAdminBackMain
            // 
            rjBtnAdminBackMain.BackColor = Color.White;
            rjBtnAdminBackMain.BackgroundColor = Color.White;
            rjBtnAdminBackMain.BorderColor = Color.RosyBrown;
            rjBtnAdminBackMain.BorderRadius = 20;
            rjBtnAdminBackMain.BorderSize = 0;
            rjBtnAdminBackMain.FlatAppearance.BorderSize = 0;
            rjBtnAdminBackMain.FlatStyle = FlatStyle.Flat;
            rjBtnAdminBackMain.ForeColor = Color.White;
            rjBtnAdminBackMain.Image = Properties.Resources.LeftArrowIcon;
            rjBtnAdminBackMain.Location = new Point(3, 3);
            rjBtnAdminBackMain.Name = "rjBtnAdminBackMain";
            rjBtnAdminBackMain.Size = new Size(40, 40);
            rjBtnAdminBackMain.TabIndex = 35;
            rjBtnAdminBackMain.TextColor = Color.White;
            rjBtnAdminBackMain.UseVisualStyleBackColor = false;
            rjBtnAdminBackMain.Click += rjBtnAdminBackMain_Click;
            // 
            // lbl_AdminLoginGUI
            // 
            lbl_AdminLoginGUI.AutoSize = true;
            lbl_AdminLoginGUI.Font = new Font("Yu Gothic UI Semibold", 13F);
            lbl_AdminLoginGUI.Location = new Point(160, 10);
            lbl_AdminLoginGUI.Name = "lbl_AdminLoginGUI";
            lbl_AdminLoginGUI.Size = new Size(81, 25);
            lbl_AdminLoginGUI.TabIndex = 36;
            lbl_AdminLoginGUI.Text = "Register";
            // 
            // textBoxPatientName
            // 
            textBoxPatientName.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textBoxPatientName.Location = new Point(67, 54);
            textBoxPatientName.Name = "textBoxPatientName";
            textBoxPatientName.PlaceholderText = "Name";
            textBoxPatientName.Size = new Size(266, 24);
            textBoxPatientName.TabIndex = 37;
            // 
            // textBoxPatientSurname
            // 
            textBoxPatientSurname.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textBoxPatientSurname.Location = new Point(67, 93);
            textBoxPatientSurname.Name = "textBoxPatientSurname";
            textBoxPatientSurname.PlaceholderText = "Surname";
            textBoxPatientSurname.Size = new Size(266, 24);
            textBoxPatientSurname.TabIndex = 39;
            // 
            // textBoxP_GSM_No
            // 
            textBoxP_GSM_No.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textBoxP_GSM_No.Location = new Point(67, 171);
            textBoxP_GSM_No.Name = "textBoxP_GSM_No";
            textBoxP_GSM_No.PlaceholderText = "GSM No";
            textBoxP_GSM_No.Size = new Size(266, 24);
            textBoxP_GSM_No.TabIndex = 41;
            textBoxP_GSM_No.KeyPress += textBoxP_GSM_No_KeyPress;
            // 
            // textBoxP_IdentificationNo
            // 
            textBoxP_IdentificationNo.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textBoxP_IdentificationNo.Location = new Point(67, 132);
            textBoxP_IdentificationNo.Name = "textBoxP_IdentificationNo";
            textBoxP_IdentificationNo.PlaceholderText = "Identification No";
            textBoxP_IdentificationNo.Size = new Size(266, 24);
            textBoxP_IdentificationNo.TabIndex = 40;
            textBoxP_IdentificationNo.KeyPress += textBoxP_IdentificationNo_KeyPress;
            // 
            // textBoxP_AgainPassword
            // 
            textBoxP_AgainPassword.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textBoxP_AgainPassword.Location = new Point(67, 249);
            textBoxP_AgainPassword.Name = "textBoxP_AgainPassword";
            textBoxP_AgainPassword.PasswordChar = '*';
            textBoxP_AgainPassword.PlaceholderText = "Password Again";
            textBoxP_AgainPassword.Size = new Size(266, 24);
            textBoxP_AgainPassword.TabIndex = 43;
            // 
            // textBoxP_Password
            // 
            textBoxP_Password.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textBoxP_Password.Location = new Point(67, 210);
            textBoxP_Password.Name = "textBoxP_Password";
            textBoxP_Password.PasswordChar = '*';
            textBoxP_Password.PlaceholderText = "Password";
            textBoxP_Password.Size = new Size(266, 24);
            textBoxP_Password.TabIndex = 42;
            // 
            // PatientSignUpGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 350);
            Controls.Add(textBoxP_AgainPassword);
            Controls.Add(textBoxP_Password);
            Controls.Add(textBoxP_GSM_No);
            Controls.Add(textBoxP_IdentificationNo);
            Controls.Add(textBoxPatientSurname);
            Controls.Add(textBoxPatientName);
            Controls.Add(lbl_AdminLoginGUI);
            Controls.Add(rjBtnAdminBackMain);
            Controls.Add(rjBtnPatientSignUp);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PatientSignUpGUI";
            Text = "PatientSignUpGUI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CustomTools.RJButton.RJButton rjBtnPatientSignUp;
        private CustomTools.RJButton.RJButton rjBtnAdminBackMain;
        private Label lbl_AdminLoginGUI;
        private TextBox textBoxPatientName;
        private TextBox textBoxPatientSurname;
        private TextBox textBoxP_GSM_No;
        private TextBox textBoxP_IdentificationNo;
        private TextBox textBoxP_AgainPassword;
        private TextBox textBoxP_Password;
    }
}
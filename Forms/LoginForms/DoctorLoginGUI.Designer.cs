namespace HospitalManagementSystem.Forms.LoginForms
{
    partial class DoctorLoginGUI
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
            rjBtnDoctorBackMain = new CustomTools.RJButton.RJButton();
            rjBtnDoctorSignIn = new CustomTools.RJButton.RJButton();
            labelDoctorPassword = new Label();
            labelDoctorID = new Label();
            lbl_DoctorLoginGUI = new Label();
            textBoxDoctorLogiId = new TextBox();
            textboxDoctorPassword = new TextBox();
            SuspendLayout();
            // 
            // rjBtnDoctorBackMain
            // 
            rjBtnDoctorBackMain.BackColor = Color.White;
            rjBtnDoctorBackMain.BackgroundColor = Color.White;
            rjBtnDoctorBackMain.BorderColor = Color.RosyBrown;
            rjBtnDoctorBackMain.BorderRadius = 20;
            rjBtnDoctorBackMain.BorderSize = 0;
            rjBtnDoctorBackMain.FlatAppearance.BorderSize = 0;
            rjBtnDoctorBackMain.FlatStyle = FlatStyle.Flat;
            rjBtnDoctorBackMain.ForeColor = Color.White;
            rjBtnDoctorBackMain.Image = Properties.Resources.LeftArrowIcon;
            rjBtnDoctorBackMain.Location = new Point(3, 4);
            rjBtnDoctorBackMain.Margin = new Padding(3, 4, 3, 4);
            rjBtnDoctorBackMain.Name = "rjBtnDoctorBackMain";
            rjBtnDoctorBackMain.Size = new Size(46, 53);
            rjBtnDoctorBackMain.TabIndex = 21;
            rjBtnDoctorBackMain.TextColor = Color.White;
            rjBtnDoctorBackMain.UseVisualStyleBackColor = false;
            rjBtnDoctorBackMain.Click += rjBtnDoctorBackMain_Click;
            // 
            // rjBtnDoctorSignIn
            // 
            rjBtnDoctorSignIn.BackColor = Color.Black;
            rjBtnDoctorSignIn.BackgroundColor = Color.Black;
            rjBtnDoctorSignIn.BorderColor = Color.Salmon;
            rjBtnDoctorSignIn.BorderRadius = 17;
            rjBtnDoctorSignIn.BorderSize = 0;
            rjBtnDoctorSignIn.FlatAppearance.BorderSize = 0;
            rjBtnDoctorSignIn.FlatStyle = FlatStyle.Flat;
            rjBtnDoctorSignIn.Font = new Font("Yu Gothic UI Semibold", 10F);
            rjBtnDoctorSignIn.ForeColor = Color.White;
            rjBtnDoctorSignIn.Location = new Point(149, 337);
            rjBtnDoctorSignIn.Margin = new Padding(3, 4, 3, 4);
            rjBtnDoctorSignIn.Name = "rjBtnDoctorSignIn";
            rjBtnDoctorSignIn.Size = new Size(160, 41);
            rjBtnDoctorSignIn.TabIndex = 20;
            rjBtnDoctorSignIn.Text = "Sign in";
            rjBtnDoctorSignIn.TextColor = Color.White;
            rjBtnDoctorSignIn.UseVisualStyleBackColor = false;
            rjBtnDoctorSignIn.Click += rjBtnDoctorSignIn_Click;
            // 
            // labelDoctorPassword
            // 
            labelDoctorPassword.AutoSize = true;
            labelDoctorPassword.Font = new Font("Yu Gothic UI Semibold", 11F);
            labelDoctorPassword.Location = new Point(86, 239);
            labelDoctorPassword.Name = "labelDoctorPassword";
            labelDoctorPassword.Size = new Size(92, 25);
            labelDoctorPassword.TabIndex = 18;
            labelDoctorPassword.Text = "Password";
            // 
            // labelDoctorID
            // 
            labelDoctorID.AutoSize = true;
            labelDoctorID.Font = new Font("Yu Gothic UI Semibold", 11F);
            labelDoctorID.Location = new Point(86, 148);
            labelDoctorID.Name = "labelDoctorID";
            labelDoctorID.Size = new Size(157, 25);
            labelDoctorID.TabIndex = 16;
            labelDoctorID.Text = "Identification No";
            // 
            // lbl_DoctorLoginGUI
            // 
            lbl_DoctorLoginGUI.AutoSize = true;
            lbl_DoctorLoginGUI.Font = new Font("Yu Gothic UI Semibold", 13F);
            lbl_DoctorLoginGUI.Location = new Point(151, 83);
            lbl_DoctorLoginGUI.Name = "lbl_DoctorLoginGUI";
            lbl_DoctorLoginGUI.Size = new Size(163, 30);
            lbl_DoctorLoginGUI.TabIndex = 15;
            lbl_DoctorLoginGUI.Text = "Ready to Login";
            // 
            // textBoxDoctorLogiId
            // 
            textBoxDoctorLogiId.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textBoxDoctorLogiId.Location = new Point(86, 187);
            textBoxDoctorLogiId.Margin = new Padding(3, 4, 3, 4);
            textBoxDoctorLogiId.Name = "textBoxDoctorLogiId";
            textBoxDoctorLogiId.PlaceholderText = "ID";
            textBoxDoctorLogiId.Size = new Size(303, 29);
            textBoxDoctorLogiId.TabIndex = 40;
            textBoxDoctorLogiId.KeyPress += textBoxDoctorLogiId_KeyPress;
            // 
            // textboxDoctorPassword
            // 
            textboxDoctorPassword.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textboxDoctorPassword.Location = new Point(86, 277);
            textboxDoctorPassword.Margin = new Padding(3, 4, 3, 4);
            textboxDoctorPassword.Name = "textboxDoctorPassword";
            textboxDoctorPassword.PasswordChar = '*';
            textboxDoctorPassword.PlaceholderText = "Password";
            textboxDoctorPassword.Size = new Size(303, 29);
            textboxDoctorPassword.TabIndex = 41;
            // 
            // DoctorLoginGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(457, 467);
            Controls.Add(textboxDoctorPassword);
            Controls.Add(textBoxDoctorLogiId);
            Controls.Add(rjBtnDoctorBackMain);
            Controls.Add(rjBtnDoctorSignIn);
            Controls.Add(labelDoctorPassword);
            Controls.Add(labelDoctorID);
            Controls.Add(lbl_DoctorLoginGUI);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "DoctorLoginGUI";
            Text = "DoctorLogin";
            Load += DoctorLoginGUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomTools.RJButton.RJButton rjBtnDoctorBackMain;
        private CustomTools.RJButton.RJButton rjBtnDoctorSignIn;
        private Label labelDoctorPassword;
        private Label labelDoctorID;
        private Label lbl_DoctorLoginGUI;
        private TextBox textBoxDoctorLogiId;
        private TextBox textboxDoctorPassword;
    }
}
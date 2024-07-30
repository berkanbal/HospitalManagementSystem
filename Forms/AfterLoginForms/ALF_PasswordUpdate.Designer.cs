namespace HospitalManagementSystem.Forms.AfterLoginForms
{
    partial class ALF_PasswordUpdate
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
            rjBtnPasswordUpdate = new CustomTools.RJButton.RJButton();
            rjBtnAdminBackMain = new CustomTools.RJButton.RJButton();
            textboxOldPassword = new TextBox();
            textboxNewPassword = new TextBox();
            textboxNewPasswordAgain = new TextBox();
            SuspendLayout();
            // 
            // rjBtnPasswordUpdate
            // 
            rjBtnPasswordUpdate.BackColor = Color.Black;
            rjBtnPasswordUpdate.BackgroundColor = Color.Black;
            rjBtnPasswordUpdate.BorderColor = Color.Salmon;
            rjBtnPasswordUpdate.BorderRadius = 17;
            rjBtnPasswordUpdate.BorderSize = 0;
            rjBtnPasswordUpdate.FlatAppearance.BorderSize = 0;
            rjBtnPasswordUpdate.FlatStyle = FlatStyle.Flat;
            rjBtnPasswordUpdate.Font = new Font("Yu Gothic UI Semibold", 10F);
            rjBtnPasswordUpdate.ForeColor = Color.White;
            rjBtnPasswordUpdate.Location = new Point(421, 317);
            rjBtnPasswordUpdate.Margin = new Padding(3, 4, 3, 4);
            rjBtnPasswordUpdate.Name = "rjBtnPasswordUpdate";
            rjBtnPasswordUpdate.Size = new Size(160, 41);
            rjBtnPasswordUpdate.TabIndex = 36;
            rjBtnPasswordUpdate.Text = "Update";
            rjBtnPasswordUpdate.TextColor = Color.White;
            rjBtnPasswordUpdate.UseVisualStyleBackColor = false;
            rjBtnPasswordUpdate.Click += rjBtnPasswordUpdate_Click;
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
            rjBtnAdminBackMain.Location = new Point(3, 4);
            rjBtnAdminBackMain.Margin = new Padding(3, 4, 3, 4);
            rjBtnAdminBackMain.Name = "rjBtnAdminBackMain";
            rjBtnAdminBackMain.Size = new Size(46, 53);
            rjBtnAdminBackMain.TabIndex = 38;
            rjBtnAdminBackMain.TextColor = Color.White;
            rjBtnAdminBackMain.UseVisualStyleBackColor = false;
            rjBtnAdminBackMain.Click += rjBtnAdminBackMain_Click;
            // 
            // textboxOldPassword
            // 
            textboxOldPassword.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textboxOldPassword.Location = new Point(377, 172);
            textboxOldPassword.Margin = new Padding(3, 4, 3, 4);
            textboxOldPassword.Name = "textboxOldPassword";
            textboxOldPassword.PlaceholderText = "Old Password";
            textboxOldPassword.Size = new Size(260, 29);
            textboxOldPassword.TabIndex = 79;
            // 
            // textboxNewPassword
            // 
            textboxNewPassword.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textboxNewPassword.Location = new Point(377, 220);
            textboxNewPassword.Margin = new Padding(3, 4, 3, 4);
            textboxNewPassword.Name = "textboxNewPassword";
            textboxNewPassword.PlaceholderText = "New Password";
            textboxNewPassword.Size = new Size(260, 29);
            textboxNewPassword.TabIndex = 80;
            // 
            // textboxNewPasswordAgain
            // 
            textboxNewPasswordAgain.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textboxNewPasswordAgain.Location = new Point(377, 268);
            textboxNewPasswordAgain.Margin = new Padding(3, 4, 3, 4);
            textboxNewPasswordAgain.Name = "textboxNewPasswordAgain";
            textboxNewPasswordAgain.PlaceholderText = "New Password Again";
            textboxNewPasswordAgain.Size = new Size(260, 29);
            textboxNewPasswordAgain.TabIndex = 81;
            // 
            // ALF_PasswordUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1040, 536);
            Controls.Add(textboxNewPasswordAgain);
            Controls.Add(textboxNewPassword);
            Controls.Add(textboxOldPassword);
            Controls.Add(rjBtnAdminBackMain);
            Controls.Add(rjBtnPasswordUpdate);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ALF_PasswordUpdate";
            Text = "ALF_PasswordUpdate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomTools.RJButton.RJButton rjBtnPasswordUpdate;
        private CustomTools.RJButton.RJButton rjBtnAdminBackMain;
        private TextBox textboxOldPassword;
        private TextBox textboxNewPassword;
        private TextBox textboxNewPasswordAgain;
    }
}
namespace HospitalManagementSystem.Forms.LoginForms
{
    partial class AdminLoginGUI
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
            rjBtnAdminBackMain = new CustomTools.RJButton.RJButton();
            rjBtnAdminSignIn = new CustomTools.RJButton.RJButton();
            labelAdminPassword = new Label();
            labelAdminID = new Label();
            lbl_AdminLoginGUI = new Label();
            textBoxAdminLogiId = new TextBox();
            textboxAdminPassword = new TextBox();
            SuspendLayout();
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
            rjBtnAdminBackMain.TabIndex = 28;
            rjBtnAdminBackMain.TextColor = Color.White;
            rjBtnAdminBackMain.UseVisualStyleBackColor = false;
            rjBtnAdminBackMain.Click += rjBtnAdminBackMain_Click;
            // 
            // rjBtnAdminSignIn
            // 
            rjBtnAdminSignIn.BackColor = Color.Black;
            rjBtnAdminSignIn.BackgroundColor = Color.Black;
            rjBtnAdminSignIn.BorderColor = Color.Salmon;
            rjBtnAdminSignIn.BorderRadius = 17;
            rjBtnAdminSignIn.BorderSize = 0;
            rjBtnAdminSignIn.FlatAppearance.BorderSize = 0;
            rjBtnAdminSignIn.FlatStyle = FlatStyle.Flat;
            rjBtnAdminSignIn.Font = new Font("Yu Gothic UI Semibold", 10F);
            rjBtnAdminSignIn.ForeColor = Color.White;
            rjBtnAdminSignIn.Location = new Point(130, 253);
            rjBtnAdminSignIn.Name = "rjBtnAdminSignIn";
            rjBtnAdminSignIn.Size = new Size(140, 31);
            rjBtnAdminSignIn.TabIndex = 27;
            rjBtnAdminSignIn.Text = "Sign in";
            rjBtnAdminSignIn.TextColor = Color.White;
            rjBtnAdminSignIn.UseVisualStyleBackColor = false;
            rjBtnAdminSignIn.Click += rjBtnAdminSignIn_Click;
            // 
            // labelAdminPassword
            // 
            labelAdminPassword.AutoSize = true;
            labelAdminPassword.Font = new Font("Yu Gothic UI Semibold", 11F);
            labelAdminPassword.Location = new Point(75, 178);
            labelAdminPassword.Name = "labelAdminPassword";
            labelAdminPassword.Size = new Size(73, 20);
            labelAdminPassword.TabIndex = 25;
            labelAdminPassword.Text = "Password";
            // 
            // labelAdminID
            // 
            labelAdminID.AutoSize = true;
            labelAdminID.Font = new Font("Yu Gothic UI Semibold", 11F);
            labelAdminID.Location = new Point(75, 109);
            labelAdminID.Name = "labelAdminID";
            labelAdminID.Size = new Size(124, 20);
            labelAdminID.TabIndex = 23;
            labelAdminID.Text = "Identification No";
            // 
            // lbl_AdminLoginGUI
            // 
            lbl_AdminLoginGUI.AutoSize = true;
            lbl_AdminLoginGUI.Font = new Font("Yu Gothic UI Semibold", 13F);
            lbl_AdminLoginGUI.Location = new Point(132, 62);
            lbl_AdminLoginGUI.Name = "lbl_AdminLoginGUI";
            lbl_AdminLoginGUI.Size = new Size(137, 25);
            lbl_AdminLoginGUI.TabIndex = 22;
            lbl_AdminLoginGUI.Text = "Ready to Login";
            // 
            // textBoxAdminLogiId
            // 
            textBoxAdminLogiId.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textBoxAdminLogiId.Location = new Point(75, 140);
            textBoxAdminLogiId.Name = "textBoxAdminLogiId";
            textBoxAdminLogiId.PlaceholderText = "ID";
            textBoxAdminLogiId.Size = new Size(266, 24);
            textBoxAdminLogiId.TabIndex = 41;
            textBoxAdminLogiId.KeyPress += textBoxAdminLogiId_KeyPress;
            // 
            // textboxAdminPassword
            // 
            textboxAdminPassword.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textboxAdminPassword.Location = new Point(75, 209);
            textboxAdminPassword.Name = "textboxAdminPassword";
            textboxAdminPassword.PasswordChar = '*';
            textboxAdminPassword.PlaceholderText = "Password";
            textboxAdminPassword.Size = new Size(266, 24);
            textboxAdminPassword.TabIndex = 42;
            // 
            // AdminLoginGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 350);
            Controls.Add(textboxAdminPassword);
            Controls.Add(textBoxAdminLogiId);
            Controls.Add(rjBtnAdminBackMain);
            Controls.Add(rjBtnAdminSignIn);
            Controls.Add(labelAdminPassword);
            Controls.Add(labelAdminID);
            Controls.Add(lbl_AdminLoginGUI);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminLoginGUI";
            Text = "AdminLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomTools.RJButton.RJButton rjBtnAdminBackMain;
        private CustomTools.RJButton.RJButton rjBtnAdminSignIn;
        private Label labelAdminPassword;
        private Label labelAdminID;
        private Label lbl_AdminLoginGUI;
        private TextBox textBoxAdminLogiId;
        private TextBox textboxAdminPassword;
    }
}
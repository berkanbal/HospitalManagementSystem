namespace HospitalManagementSystem.Forms.LoginForms
{
    partial class SecretaryLoginGUI
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
            rjBtnSecretaryBackMain = new CustomTools.RJButton.RJButton();
            rjBtnSecretarySignIn = new CustomTools.RJButton.RJButton();
            label_Secretary_Password = new Label();
            label_Secretary_ID = new Label();
            lbl_SecretaryLoginGUI = new Label();
            textBoxSecretaryLoginId = new TextBox();
            textboxSecretaryPasswordId = new TextBox();
            SuspendLayout();
            // 
            // rjBtnSecretaryBackMain
            // 
            rjBtnSecretaryBackMain.BackColor = Color.White;
            rjBtnSecretaryBackMain.BackgroundColor = Color.White;
            rjBtnSecretaryBackMain.BorderColor = Color.RosyBrown;
            rjBtnSecretaryBackMain.BorderRadius = 20;
            rjBtnSecretaryBackMain.BorderSize = 0;
            rjBtnSecretaryBackMain.FlatAppearance.BorderSize = 0;
            rjBtnSecretaryBackMain.FlatStyle = FlatStyle.Flat;
            rjBtnSecretaryBackMain.ForeColor = Color.White;
            rjBtnSecretaryBackMain.Image = Properties.Resources.LeftArrowIcon;
            rjBtnSecretaryBackMain.Location = new Point(3, 3);
            rjBtnSecretaryBackMain.Name = "rjBtnSecretaryBackMain";
            rjBtnSecretaryBackMain.Size = new Size(40, 40);
            rjBtnSecretaryBackMain.TabIndex = 21;
            rjBtnSecretaryBackMain.TextColor = Color.White;
            rjBtnSecretaryBackMain.UseVisualStyleBackColor = false;
            rjBtnSecretaryBackMain.Click += rjBtnSecretaryBackMain_Click;
            // 
            // rjBtnSecretarySignIn
            // 
            rjBtnSecretarySignIn.BackColor = Color.Black;
            rjBtnSecretarySignIn.BackgroundColor = Color.Black;
            rjBtnSecretarySignIn.BorderColor = Color.Salmon;
            rjBtnSecretarySignIn.BorderRadius = 17;
            rjBtnSecretarySignIn.BorderSize = 0;
            rjBtnSecretarySignIn.FlatAppearance.BorderSize = 0;
            rjBtnSecretarySignIn.FlatStyle = FlatStyle.Flat;
            rjBtnSecretarySignIn.Font = new Font("Yu Gothic UI Semibold", 10F);
            rjBtnSecretarySignIn.ForeColor = Color.White;
            rjBtnSecretarySignIn.Location = new Point(130, 253);
            rjBtnSecretarySignIn.Name = "rjBtnSecretarySignIn";
            rjBtnSecretarySignIn.Size = new Size(140, 31);
            rjBtnSecretarySignIn.TabIndex = 20;
            rjBtnSecretarySignIn.Text = "Sign in";
            rjBtnSecretarySignIn.TextColor = Color.White;
            rjBtnSecretarySignIn.UseVisualStyleBackColor = false;
            rjBtnSecretarySignIn.Click += rjBtnSecretarySignIn_Click;
            // 
            // label_Secretary_Password
            // 
            label_Secretary_Password.AutoSize = true;
            label_Secretary_Password.Font = new Font("Yu Gothic UI Semibold", 11F);
            label_Secretary_Password.Location = new Point(60, 180);
            label_Secretary_Password.Name = "label_Secretary_Password";
            label_Secretary_Password.Size = new Size(73, 20);
            label_Secretary_Password.TabIndex = 18;
            label_Secretary_Password.Text = "Password";
            // 
            // label_Secretary_ID
            // 
            label_Secretary_ID.AutoSize = true;
            label_Secretary_ID.Font = new Font("Yu Gothic UI Semibold", 11F);
            label_Secretary_ID.Location = new Point(60, 110);
            label_Secretary_ID.Name = "label_Secretary_ID";
            label_Secretary_ID.Size = new Size(124, 20);
            label_Secretary_ID.TabIndex = 16;
            label_Secretary_ID.Text = "Identification No";
            // 
            // lbl_SecretaryLoginGUI
            // 
            lbl_SecretaryLoginGUI.AutoSize = true;
            lbl_SecretaryLoginGUI.Font = new Font("Yu Gothic UI Semibold", 13F);
            lbl_SecretaryLoginGUI.Location = new Point(132, 62);
            lbl_SecretaryLoginGUI.Name = "lbl_SecretaryLoginGUI";
            lbl_SecretaryLoginGUI.Size = new Size(137, 25);
            lbl_SecretaryLoginGUI.TabIndex = 15;
            lbl_SecretaryLoginGUI.Text = "Ready to Login";
            // 
            // textBoxSecretaryLoginId
            // 
            textBoxSecretaryLoginId.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textBoxSecretaryLoginId.Location = new Point(60, 140);
            textBoxSecretaryLoginId.Name = "textBoxSecretaryLoginId";
            textBoxSecretaryLoginId.PlaceholderText = "ID";
            textBoxSecretaryLoginId.Size = new Size(266, 24);
            textBoxSecretaryLoginId.TabIndex = 38;
            textBoxSecretaryLoginId.KeyPress += textBoxSecretaryLoginId_KeyPress;
            // 
            // textboxSecretaryPasswordId
            // 
            textboxSecretaryPasswordId.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textboxSecretaryPasswordId.Location = new Point(60, 212);
            textboxSecretaryPasswordId.Name = "textboxSecretaryPasswordId";
            textboxSecretaryPasswordId.PasswordChar = '*';
            textboxSecretaryPasswordId.PlaceholderText = "Password";
            textboxSecretaryPasswordId.Size = new Size(266, 24);
            textboxSecretaryPasswordId.TabIndex = 39;
            // 
            // SecretaryLoginGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(384, 311);
            Controls.Add(textboxSecretaryPasswordId);
            Controls.Add(textBoxSecretaryLoginId);
            Controls.Add(rjBtnSecretaryBackMain);
            Controls.Add(rjBtnSecretarySignIn);
            Controls.Add(label_Secretary_Password);
            Controls.Add(label_Secretary_ID);
            Controls.Add(lbl_SecretaryLoginGUI);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SecretaryLoginGUI";
            Text = "SecretaryLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomTools.RJButton.RJButton rjBtnSecretaryBackMain;
        private CustomTools.RJButton.RJButton rjBtnSecretarySignIn;
        private Label label_Secretary_Password;
        private Label label_Secretary_ID;
        private Label lbl_SecretaryLoginGUI;
        private TextBox textBoxSecretaryLoginId;
        private TextBox textboxSecretaryPasswordId;
    }
}
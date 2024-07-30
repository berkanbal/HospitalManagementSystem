namespace HospitalManagementSystem.Forms.AfterLoginForms
{
    partial class PALF_Bilgilerim
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
            linkLabelPasswordUpdate = new LinkLabel();
            textboxPALF_GSM = new TextBox();
            textboxPALF_Id = new TextBox();
            textboxPALF_Surname = new TextBox();
            textboxPALF_Name = new TextBox();
            buttonPALF_Upd = new CustomTools.RJButton.RJButton();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // linkLabelPasswordUpdate
            // 
            linkLabelPasswordUpdate.AutoSize = true;
            linkLabelPasswordUpdate.Location = new Point(297, 391);
            linkLabelPasswordUpdate.Name = "linkLabelPasswordUpdate";
            linkLabelPasswordUpdate.Size = new Size(215, 20);
            linkLabelPasswordUpdate.TabIndex = 39;
            linkLabelPasswordUpdate.TabStop = true;
            linkLabelPasswordUpdate.Text = "Click here to changer password";
            linkLabelPasswordUpdate.LinkClicked += linkLabelPasswordUpdate_LinkClicked;
            // 
            // textboxPALF_GSM
            // 
            textboxPALF_GSM.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textboxPALF_GSM.Location = new Point(265, 284);
            textboxPALF_GSM.Margin = new Padding(3, 4, 3, 4);
            textboxPALF_GSM.Name = "textboxPALF_GSM";
            textboxPALF_GSM.PlaceholderText = "GSM";
            textboxPALF_GSM.Size = new Size(260, 29);
            textboxPALF_GSM.TabIndex = 90;
            // 
            // textboxPALF_Id
            // 
            textboxPALF_Id.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textboxPALF_Id.Location = new Point(265, 235);
            textboxPALF_Id.Margin = new Padding(3, 4, 3, 4);
            textboxPALF_Id.Name = "textboxPALF_Id";
            textboxPALF_Id.PlaceholderText = "ID";
            textboxPALF_Id.Size = new Size(260, 29);
            textboxPALF_Id.TabIndex = 89;
            // 
            // textboxPALF_Surname
            // 
            textboxPALF_Surname.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textboxPALF_Surname.Location = new Point(264, 184);
            textboxPALF_Surname.Margin = new Padding(3, 4, 3, 4);
            textboxPALF_Surname.Name = "textboxPALF_Surname";
            textboxPALF_Surname.PlaceholderText = "Surname";
            textboxPALF_Surname.Size = new Size(260, 29);
            textboxPALF_Surname.TabIndex = 88;
            // 
            // textboxPALF_Name
            // 
            textboxPALF_Name.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textboxPALF_Name.Location = new Point(264, 136);
            textboxPALF_Name.Margin = new Padding(3, 4, 3, 4);
            textboxPALF_Name.Name = "textboxPALF_Name";
            textboxPALF_Name.PlaceholderText = "Name";
            textboxPALF_Name.Size = new Size(260, 29);
            textboxPALF_Name.TabIndex = 87;
            // 
            // buttonPALF_Upd
            // 
            buttonPALF_Upd.BackColor = Color.Black;
            buttonPALF_Upd.BackgroundColor = Color.Black;
            buttonPALF_Upd.BorderColor = Color.Salmon;
            buttonPALF_Upd.BorderRadius = 17;
            buttonPALF_Upd.BorderSize = 0;
            buttonPALF_Upd.FlatAppearance.BorderSize = 0;
            buttonPALF_Upd.FlatStyle = FlatStyle.Flat;
            buttonPALF_Upd.Font = new Font("Yu Gothic UI Semibold", 10F);
            buttonPALF_Upd.ForeColor = Color.White;
            buttonPALF_Upd.Location = new Point(321, 330);
            buttonPALF_Upd.Margin = new Padding(3, 4, 3, 4);
            buttonPALF_Upd.Name = "buttonPALF_Upd";
            buttonPALF_Upd.Size = new Size(160, 41);
            buttonPALF_Upd.TabIndex = 86;
            buttonPALF_Upd.Text = "Update";
            buttonPALF_Upd.TextColor = Color.White;
            buttonPALF_Upd.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI Semibold", 11F);
            label4.Location = new Point(164, 286);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 85;
            label4.Text = "GSM No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 11F);
            label3.Location = new Point(97, 237);
            label3.Name = "label3";
            label3.Size = new Size(162, 25);
            label3.TabIndex = 84;
            label3.Text = "Identification No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 11F);
            label2.Location = new Point(159, 186);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 83;
            label2.Text = "Surname:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 11F);
            label1.Location = new Point(183, 138);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 82;
            label1.Text = "Name:";
            // 
            // PALF_Bilgilerim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1040, 536);
            Controls.Add(textboxPALF_GSM);
            Controls.Add(textboxPALF_Id);
            Controls.Add(textboxPALF_Surname);
            Controls.Add(textboxPALF_Name);
            Controls.Add(buttonPALF_Upd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(linkLabelPasswordUpdate);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PALF_Bilgilerim";
            Text = "PALF_Bilgilerim";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LinkLabel linkLabelPasswordUpdate;
        private TextBox textboxPALF_GSM;
        private TextBox textboxPALF_Id;
        private TextBox textboxPALF_Surname;
        private TextBox textboxPALF_Name;
        private CustomTools.RJButton.RJButton buttonPALF_Upd;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
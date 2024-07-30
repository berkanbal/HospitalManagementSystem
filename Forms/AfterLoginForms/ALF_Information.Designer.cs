namespace HospitalManagementSystem.Forms.AfterLoginForms
{
    partial class ALF_Information
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
            buttonPALF_Upd = new CustomTools.RJButton.RJButton();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textboxALF_Name = new TextBox();
            textboxALF_Surname = new TextBox();
            textboxALF_Id = new TextBox();
            textboxALF_GSM = new TextBox();
            SuspendLayout();
            // 
            // linkLabelPasswordUpdate
            // 
            linkLabelPasswordUpdate.AutoSize = true;
            linkLabelPasswordUpdate.Location = new Point(411, 394);
            linkLabelPasswordUpdate.Name = "linkLabelPasswordUpdate";
            linkLabelPasswordUpdate.Size = new Size(210, 20);
            linkLabelPasswordUpdate.TabIndex = 49;
            linkLabelPasswordUpdate.TabStop = true;
            linkLabelPasswordUpdate.Text = "Click here to change password";
            linkLabelPasswordUpdate.LinkClicked += linkLabelPasswordUpdate_LinkClicked;
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
            buttonPALF_Upd.Location = new Point(436, 330);
            buttonPALF_Upd.Margin = new Padding(3, 4, 3, 4);
            buttonPALF_Upd.Name = "buttonPALF_Upd";
            buttonPALF_Upd.Size = new Size(160, 41);
            buttonPALF_Upd.TabIndex = 44;
            buttonPALF_Upd.Text = "Update";
            buttonPALF_Upd.TextColor = Color.White;
            buttonPALF_Upd.UseVisualStyleBackColor = false;
            buttonPALF_Upd.Click += buttonPALF_Upd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI Semibold", 11F);
            label4.Location = new Point(311, 280);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 43;
            label4.Text = "GSM No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 11F);
            label3.Location = new Point(244, 231);
            label3.Name = "label3";
            label3.Size = new Size(162, 25);
            label3.TabIndex = 42;
            label3.Text = "Identification No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 11F);
            label2.Location = new Point(306, 180);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 41;
            label2.Text = "Surname:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 11F);
            label1.Location = new Point(330, 133);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 40;
            label1.Text = "Name:";
            // 
            // textboxALF_Name
            // 
            textboxALF_Name.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textboxALF_Name.Location = new Point(411, 131);
            textboxALF_Name.Margin = new Padding(3, 4, 3, 4);
            textboxALF_Name.Name = "textboxALF_Name";
            textboxALF_Name.PlaceholderText = "Name";
            textboxALF_Name.Size = new Size(260, 29);
            textboxALF_Name.TabIndex = 78;
            // 
            // textboxALF_Surname
            // 
            textboxALF_Surname.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textboxALF_Surname.Location = new Point(411, 178);
            textboxALF_Surname.Margin = new Padding(3, 4, 3, 4);
            textboxALF_Surname.Name = "textboxALF_Surname";
            textboxALF_Surname.PlaceholderText = "Surname";
            textboxALF_Surname.Size = new Size(260, 29);
            textboxALF_Surname.TabIndex = 79;
            // 
            // textboxALF_Id
            // 
            textboxALF_Id.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textboxALF_Id.Location = new Point(412, 229);
            textboxALF_Id.Margin = new Padding(3, 4, 3, 4);
            textboxALF_Id.Name = "textboxALF_Id";
            textboxALF_Id.PlaceholderText = "ID";
            textboxALF_Id.Size = new Size(260, 29);
            textboxALF_Id.TabIndex = 80;
            textboxALF_Id.KeyPress += textboxALF_Id_KeyPress;
            // 
            // textboxALF_GSM
            // 
            textboxALF_GSM.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textboxALF_GSM.Location = new Point(412, 278);
            textboxALF_GSM.Margin = new Padding(3, 4, 3, 4);
            textboxALF_GSM.Name = "textboxALF_GSM";
            textboxALF_GSM.PlaceholderText = "GSM";
            textboxALF_GSM.Size = new Size(260, 29);
            textboxALF_GSM.TabIndex = 81;
            textboxALF_GSM.KeyPress += textboxALF_GSM_KeyPress;
            // 
            // ALF_Information
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1040, 536);
            Controls.Add(textboxALF_GSM);
            Controls.Add(textboxALF_Id);
            Controls.Add(textboxALF_Surname);
            Controls.Add(textboxALF_Name);
            Controls.Add(linkLabelPasswordUpdate);
            Controls.Add(buttonPALF_Upd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ALF_Information";
            Text = "ALF_Information";
            Load += ALF_Information_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabelPasswordUpdate;
        private CustomTools.RJButton.RJButton buttonPALF_Upd;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textboxALF_Name;
        private TextBox textboxALF_Surname;
        private TextBox textboxALF_Id;
        private TextBox textboxALF_GSM;
    }
}
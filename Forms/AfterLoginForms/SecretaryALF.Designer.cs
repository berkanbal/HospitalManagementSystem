namespace HospitalManagementSystem.Forms.AfterLoginForms
{
    partial class SecretaryALF
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
            panel1 = new Panel();
            labelPALF_Hg = new Label();
            SALF_MainPageMakeAppointments = new Button();
            label2 = new Label();
            SALF_MainPageInformation = new Button();
            label4 = new Label();
            labelDALF_SecretaryID = new Label();
            Salf_secretaryName = new Label();
            pictureBox1 = new PictureBox();
            SALF_MainPageAppointments = new Button();
            panelSecretaryAlf = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Salmon;
            panel1.Controls.Add(labelPALF_Hg);
            panel1.Controls.Add(SALF_MainPageMakeAppointments);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(SALF_MainPageInformation);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(labelDALF_SecretaryID);
            panel1.Controls.Add(Salf_secretaryName);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(SALF_MainPageAppointments);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 621);
            panel1.TabIndex = 0;
            // 
            // labelPALF_Hg
            // 
            labelPALF_Hg.AutoSize = true;
            labelPALF_Hg.Font = new Font("Yu Gothic UI Semibold", 15F);
            labelPALF_Hg.Location = new Point(101, 9);
            labelPALF_Hg.Name = "labelPALF_Hg";
            labelPALF_Hg.Size = new Size(120, 35);
            labelPALF_Hg.TabIndex = 49;
            labelPALF_Hg.Text = "Welcome";
            // 
            // SALF_MainPageMakeAppointments
            // 
            SALF_MainPageMakeAppointments.Font = new Font("Yu Gothic UI Semibold", 12F);
            SALF_MainPageMakeAppointments.Location = new Point(0, 195);
            SALF_MainPageMakeAppointments.Name = "SALF_MainPageMakeAppointments";
            SALF_MainPageMakeAppointments.Size = new Size(338, 53);
            SALF_MainPageMakeAppointments.TabIndex = 1;
            SALF_MainPageMakeAppointments.Text = "Make an Appointment";
            SALF_MainPageMakeAppointments.UseVisualStyleBackColor = true;
            SALF_MainPageMakeAppointments.Click += SALF_MainPageMakeAppointments_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Yu Gothic UI Semibold", 10F);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(176, 103);
            label2.Name = "label2";
            label2.Size = new Size(119, 23);
            label2.TabIndex = 48;
            label2.Text = "label";
            // 
            // SALF_MainPageInformation
            // 
            SALF_MainPageInformation.Font = new Font("Yu Gothic UI Semibold", 12F);
            SALF_MainPageInformation.Location = new Point(0, 293);
            SALF_MainPageInformation.Name = "SALF_MainPageInformation";
            SALF_MainPageInformation.Size = new Size(338, 53);
            SALF_MainPageInformation.TabIndex = 3;
            SALF_MainPageInformation.Text = "Information";
            SALF_MainPageInformation.UseVisualStyleBackColor = true;
            SALF_MainPageInformation.Click += SALF_MainPageInformation_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Salmon;
            label4.Font = new Font("Yu Gothic UI Semibold", 10F);
            label4.Location = new Point(176, 67);
            label4.Name = "label4";
            label4.Size = new Size(46, 23);
            label4.TabIndex = 47;
            label4.Text = "label";
            // 
            // labelDALF_SecretaryID
            // 
            labelDALF_SecretaryID.AutoSize = true;
            labelDALF_SecretaryID.BackColor = Color.Salmon;
            labelDALF_SecretaryID.Font = new Font("Yu Gothic UI Semibold", 10F);
            labelDALF_SecretaryID.Location = new Point(30, 67);
            labelDALF_SecretaryID.Name = "labelDALF_SecretaryID";
            labelDALF_SecretaryID.Size = new Size(120, 23);
            labelDALF_SecretaryID.TabIndex = 43;
            labelDALF_SecretaryID.Text = "Secretary ID =";
            // 
            // Salf_secretaryName
            // 
            Salf_secretaryName.AutoSize = true;
            Salf_secretaryName.BackColor = Color.Salmon;
            Salf_secretaryName.Font = new Font("Yu Gothic UI Semibold", 10F);
            Salf_secretaryName.Location = new Point(30, 103);
            Salf_secretaryName.Name = "Salf_secretaryName";
            Salf_secretaryName.Size = new Size(149, 23);
            Salf_secretaryName.TabIndex = 44;
            Salf_secretaryName.Text = "Secretary Name =";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = Properties.Resources.HospitalSystemLoginGUILogo;
            pictureBox1.Location = new Point(0, 343);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(338, 278);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // SALF_MainPageAppointments
            // 
            SALF_MainPageAppointments.Font = new Font("Yu Gothic UI Semibold", 12F);
            SALF_MainPageAppointments.Location = new Point(0, 244);
            SALF_MainPageAppointments.Name = "SALF_MainPageAppointments";
            SALF_MainPageAppointments.Size = new Size(338, 53);
            SALF_MainPageAppointments.TabIndex = 2;
            SALF_MainPageAppointments.Text = "Appointments";
            SALF_MainPageAppointments.UseVisualStyleBackColor = true;
            SALF_MainPageAppointments.Click += SALF_MainPageAppointments_Click;
            // 
            // panelSecretaryAlf
            // 
            panelSecretaryAlf.BackColor = Color.White;
            panelSecretaryAlf.Dock = DockStyle.Fill;
            panelSecretaryAlf.Location = new Point(338, 0);
            panelSecretaryAlf.Name = "panelSecretaryAlf";
            panelSecretaryAlf.Size = new Size(994, 621);
            panelSecretaryAlf.TabIndex = 1;
            // 
            // SecretaryALF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 621);
            Controls.Add(panelSecretaryAlf);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SecretaryALF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SecretaryALF";
            FormClosed += SecretaryALF_FormClosed;
            Load += SecretaryALF_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button SALF_MainPageInformation;
        private Button SALF_MainPageAppointments;
        private Button SALF_MainPageMakeAppointments;
        private Panel panelSecretaryAlf;
        private Label Salf_secretaryName;
        private Label labelDALF_SecretaryID;
        private Label label4;
        private Label label2;
        private Label labelPALF_Hg;
        private PictureBox pictureBox1;
    }
}
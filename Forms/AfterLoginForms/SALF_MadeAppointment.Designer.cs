namespace HospitalManagementSystem.Forms.AfterLoginForms
{
    partial class SALF_MadeAppointment
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
            ButtonSALF_MakeAnAppointment = new CustomTools.RJButton.RJButton();
            LabelSALF_PatientId = new Label();
            textboxSALF_PatientId = new TextBox();
            RandevuSaat = new Label();
            cbSaat = new ComboBox();
            cBoxRandevuPoliklinikSecSek = new ComboBox();
            label3 = new Label();
            cboxdoktorSek = new ComboBox();
            label2 = new Label();
            dtpRandevuTarihSec = new DateTimePicker();
            label1 = new Label();
            SuspendLayout();
            // 
            // ButtonSALF_MakeAnAppointment
            // 
            ButtonSALF_MakeAnAppointment.BackColor = Color.SkyBlue;
            ButtonSALF_MakeAnAppointment.BackgroundColor = Color.SkyBlue;
            ButtonSALF_MakeAnAppointment.BorderColor = Color.Salmon;
            ButtonSALF_MakeAnAppointment.BorderRadius = 10;
            ButtonSALF_MakeAnAppointment.BorderSize = 0;
            ButtonSALF_MakeAnAppointment.FlatAppearance.BorderSize = 0;
            ButtonSALF_MakeAnAppointment.FlatStyle = FlatStyle.Flat;
            ButtonSALF_MakeAnAppointment.Font = new Font("Yu Gothic UI Semibold", 10F);
            ButtonSALF_MakeAnAppointment.ForeColor = Color.White;
            ButtonSALF_MakeAnAppointment.Location = new Point(388, 399);
            ButtonSALF_MakeAnAppointment.Margin = new Padding(3, 4, 3, 4);
            ButtonSALF_MakeAnAppointment.Name = "ButtonSALF_MakeAnAppointment";
            ButtonSALF_MakeAnAppointment.Size = new Size(224, 36);
            ButtonSALF_MakeAnAppointment.TabIndex = 64;
            ButtonSALF_MakeAnAppointment.Text = "Make An Appointment";
            ButtonSALF_MakeAnAppointment.TextColor = Color.White;
            ButtonSALF_MakeAnAppointment.UseVisualStyleBackColor = false;
            ButtonSALF_MakeAnAppointment.Click += ButtonSALF_MakeAnAppointment_Click;
            // 
            // LabelSALF_PatientId
            // 
            LabelSALF_PatientId.AutoSize = true;
            LabelSALF_PatientId.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold);
            LabelSALF_PatientId.Location = new Point(272, 170);
            LabelSALF_PatientId.Name = "LabelSALF_PatientId";
            LabelSALF_PatientId.Size = new Size(113, 28);
            LabelSALF_PatientId.TabIndex = 63;
            LabelSALF_PatientId.Text = "Patient ID :";
            // 
            // textboxSALF_PatientId
            // 
            textboxSALF_PatientId.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textboxSALF_PatientId.Location = new Point(388, 170);
            textboxSALF_PatientId.Margin = new Padding(3, 4, 3, 4);
            textboxSALF_PatientId.Name = "textboxSALF_PatientId";
            textboxSALF_PatientId.PlaceholderText = "ID";
            textboxSALF_PatientId.Size = new Size(228, 29);
            textboxSALF_PatientId.TabIndex = 81;
            textboxSALF_PatientId.KeyPress += textboxSALF_PatientId_KeyPress;
            // 
            // RandevuSaat
            // 
            RandevuSaat.AutoSize = true;
            RandevuSaat.Font = new Font("Yu Gothic UI Semibold", 13F);
            RandevuSaat.Location = new Point(314, 349);
            RandevuSaat.Name = "RandevuSaat";
            RandevuSaat.Size = new Size(73, 30);
            RandevuSaat.TabIndex = 90;
            RandevuSaat.Text = "Time :";
            // 
            // cbSaat
            // 
            cbSaat.FormattingEnabled = true;
            cbSaat.Items.AddRange(new object[] { "10.00", "10.30", "11.00", "11.30", "12.00", "12.30", "13.00", "13.30", "14.00", "14.30", "15.00", "15.30" });
            cbSaat.Location = new Point(388, 353);
            cbSaat.Margin = new Padding(3, 4, 3, 4);
            cbSaat.Name = "cbSaat";
            cbSaat.Size = new Size(228, 28);
            cbSaat.TabIndex = 89;
            // 
            // cBoxRandevuPoliklinikSecSek
            // 
            cBoxRandevuPoliklinikSecSek.FormattingEnabled = true;
            cBoxRandevuPoliklinikSecSek.Items.AddRange(new object[] { "Kulak Burun Boğaz", "Beyin Cerrahi", "Çocuk Hastalıkları" });
            cBoxRandevuPoliklinikSecSek.Location = new Point(388, 218);
            cBoxRandevuPoliklinikSecSek.Margin = new Padding(3, 4, 3, 4);
            cBoxRandevuPoliklinikSecSek.Name = "cBoxRandevuPoliklinikSecSek";
            cBoxRandevuPoliklinikSecSek.Size = new Size(228, 28);
            cBoxRandevuPoliklinikSecSek.TabIndex = 87;
            cBoxRandevuPoliklinikSecSek.SelectedIndexChanged += cBoxRandevuPoliklinikSecSek_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 13F);
            label3.Location = new Point(272, 214);
            label3.Name = "label3";
            label3.Size = new Size(113, 30);
            label3.TabIndex = 86;
            label3.Text = "Policlinic :";
            // 
            // cboxdoktorSek
            // 
            cboxdoktorSek.FormattingEnabled = true;
            cboxdoktorSek.Location = new Point(388, 264);
            cboxdoktorSek.Margin = new Padding(3, 4, 3, 4);
            cboxdoktorSek.Name = "cboxdoktorSek";
            cboxdoktorSek.Size = new Size(228, 28);
            cboxdoktorSek.TabIndex = 85;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 13F);
            label2.Location = new Point(293, 260);
            label2.Name = "label2";
            label2.Size = new Size(92, 30);
            label2.TabIndex = 84;
            label2.Text = "Doctor :";
            // 
            // dtpRandevuTarihSec
            // 
            dtpRandevuTarihSec.Font = new Font("Segoe UI", 12F);
            dtpRandevuTarihSec.Location = new Point(388, 302);
            dtpRandevuTarihSec.Margin = new Padding(3, 4, 3, 4);
            dtpRandevuTarihSec.Name = "dtpRandevuTarihSec";
            dtpRandevuTarihSec.Size = new Size(228, 34);
            dtpRandevuTarihSec.TabIndex = 83;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 13F);
            label1.Location = new Point(314, 305);
            label1.Name = "label1";
            label1.Size = new Size(71, 30);
            label1.TabIndex = 82;
            label1.Text = "Date :";
            // 
            // SALF_MadeAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(946, 621);
            Controls.Add(RandevuSaat);
            Controls.Add(cbSaat);
            Controls.Add(cBoxRandevuPoliklinikSecSek);
            Controls.Add(label3);
            Controls.Add(cboxdoktorSek);
            Controls.Add(label2);
            Controls.Add(dtpRandevuTarihSec);
            Controls.Add(label1);
            Controls.Add(textboxSALF_PatientId);
            Controls.Add(ButtonSALF_MakeAnAppointment);
            Controls.Add(LabelSALF_PatientId);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SALF_MadeAppointment";
            Text = "SALF_MadeAppointment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CustomTools.RJButton.RJButton ButtonSALF_MakeAnAppointment;
        private Label LabelSALF_PatientId;
        private TextBox textboxSALF_PatientId;
        private Label RandevuSaat;
        private ComboBox cbSaat;
        private ComboBox cBoxRandevuPoliklinikSecSek;
        private Label label3;
        private ComboBox cboxdoktorSek;
        private Label label2;
        private DateTimePicker dtpRandevuTarihSec;
        private Label label1;
    }
}
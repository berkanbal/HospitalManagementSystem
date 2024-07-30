namespace HospitalManagementSystem.Forms.AfterLoginForms
{
    partial class PALF_RandevuAl
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
            label1 = new Label();
            dtpRandevuTarihSec = new DateTimePicker();
            label2 = new Label();
            cBoxRandevuDoktorSec = new ComboBox();
            label3 = new Label();
            cBoxRandevuPoliklinikSec = new ComboBox();
            btnRandevuAl = new Button();
            cbSaat = new ComboBox();
            RandevuSaat = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 13F);
            label1.Location = new Point(365, 230);
            label1.Name = "label1";
            label1.Size = new Size(71, 30);
            label1.TabIndex = 0;
            label1.Text = "Date :";
            // 
            // dtpRandevuTarihSec
            // 
            dtpRandevuTarihSec.Font = new Font("Microsoft Sans Serif", 12F);
            dtpRandevuTarihSec.Location = new Point(438, 228);
            dtpRandevuTarihSec.Margin = new Padding(3, 4, 3, 4);
            dtpRandevuTarihSec.Name = "dtpRandevuTarihSec";
            dtpRandevuTarihSec.Size = new Size(256, 30);
            dtpRandevuTarihSec.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 13F);
            label2.Location = new Point(343, 185);
            label2.Name = "label2";
            label2.Size = new Size(92, 30);
            label2.TabIndex = 2;
            label2.Text = "Doctor :";
            // 
            // cBoxRandevuDoktorSec
            // 
            cBoxRandevuDoktorSec.FormattingEnabled = true;
            cBoxRandevuDoktorSec.Location = new Point(438, 189);
            cBoxRandevuDoktorSec.Margin = new Padding(3, 4, 3, 4);
            cBoxRandevuDoktorSec.Name = "cBoxRandevuDoktorSec";
            cBoxRandevuDoktorSec.Size = new Size(256, 28);
            cBoxRandevuDoktorSec.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 13F);
            label3.Location = new Point(323, 140);
            label3.Name = "label3";
            label3.Size = new Size(113, 30);
            label3.TabIndex = 4;
            label3.Text = "Policlinic :";
            // 
            // cBoxRandevuPoliklinikSec
            // 
            cBoxRandevuPoliklinikSec.FormattingEnabled = true;
            cBoxRandevuPoliklinikSec.Items.AddRange(new object[] { "Kulak Burun Boğaz", "Beyin Cerrahi", "Çocuk Hastalıkları" });
            cBoxRandevuPoliklinikSec.Location = new Point(438, 144);
            cBoxRandevuPoliklinikSec.Margin = new Padding(3, 4, 3, 4);
            cBoxRandevuPoliklinikSec.Name = "cBoxRandevuPoliklinikSec";
            cBoxRandevuPoliklinikSec.Size = new Size(256, 28);
            cBoxRandevuPoliklinikSec.TabIndex = 5;
            cBoxRandevuPoliklinikSec.SelectedIndexChanged += cBoxRandevuPoliklinikSec_SelectedIndexChanged;
            // 
            // btnRandevuAl
            // 
            btnRandevuAl.Font = new Font("Yu Gothic UI Semibold", 10F);
            btnRandevuAl.Location = new Point(438, 369);
            btnRandevuAl.Margin = new Padding(3, 4, 3, 4);
            btnRandevuAl.Name = "btnRandevuAl";
            btnRandevuAl.Size = new Size(256, 39);
            btnRandevuAl.TabIndex = 6;
            btnRandevuAl.Text = "Appointment";
            btnRandevuAl.UseVisualStyleBackColor = true;
            btnRandevuAl.Click += btnRandevuAl_Click;
            // 
            // cbSaat
            // 
            cbSaat.FormattingEnabled = true;
            cbSaat.Items.AddRange(new object[] { "10.00", "11.00", "12.00", "13.00", "14.00", "15.00" });
            cbSaat.Location = new Point(438, 278);
            cbSaat.Margin = new Padding(3, 4, 3, 4);
            cbSaat.Name = "cbSaat";
            cbSaat.Size = new Size(256, 28);
            cbSaat.TabIndex = 7;
            // 
            // RandevuSaat
            // 
            RandevuSaat.AutoSize = true;
            RandevuSaat.Font = new Font("Yu Gothic UI Semibold", 13F);
            RandevuSaat.Location = new Point(365, 274);
            RandevuSaat.Name = "RandevuSaat";
            RandevuSaat.Size = new Size(73, 30);
            RandevuSaat.TabIndex = 8;
            RandevuSaat.Text = "Time :";
            // 
            // PALF_RandevuAl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1040, 536);
            Controls.Add(RandevuSaat);
            Controls.Add(cbSaat);
            Controls.Add(btnRandevuAl);
            Controls.Add(cBoxRandevuPoliklinikSec);
            Controls.Add(label3);
            Controls.Add(cBoxRandevuDoktorSec);
            Controls.Add(label2);
            Controls.Add(dtpRandevuTarihSec);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PALF_RandevuAl";
            Text = "PALF_RandevuAl";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpRandevuTarihSec;
        private Label label2;
        private ComboBox cBoxRandevuDoktorSec;
        private Label label3;
        private ComboBox cBoxRandevuPoliklinikSec;
        private Button btnRandevuAl;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private ListView listView1;
        private ComboBox cbSaat;
        private Label RandevuSaat;
    }
}
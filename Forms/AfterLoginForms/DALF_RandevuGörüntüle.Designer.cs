namespace HospitalManagementSystem.Forms.AfterLoginForms
{
    partial class DALF_RandevuGörüntüle
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
            dataGridViewDALF_Appointments = new DataGridView();
            buttonDALF_Upd = new CustomTools.RJButton.RJButton();
            buttonDALF_Del = new CustomTools.RJButton.RJButton();
            buttonDALF_Save = new CustomTools.RJButton.RJButton();
            labelDALF_Presc = new Label();
            labelDALF_Diag = new Label();
            labelDALF_PatiId = new Label();
            labelDALF_Patinam = new Label();
            textboxDALF_PatientId = new TextBox();
            textboxDALF_PatientName = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDALF_Appointments).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDALF_Appointments
            // 
            dataGridViewDALF_Appointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDALF_Appointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDALF_Appointments.Location = new Point(352, 65);
            dataGridViewDALF_Appointments.Name = "dataGridViewDALF_Appointments";
            dataGridViewDALF_Appointments.RowHeadersWidth = 51;
            dataGridViewDALF_Appointments.Size = new Size(566, 472);
            dataGridViewDALF_Appointments.TabIndex = 2;
            dataGridViewDALF_Appointments.CellClick += dataGridViewDALF_Appointments_CellClick;
            dataGridViewDALF_Appointments.CellFormatting += dataGridViewDALF_Appointments_CellFormatting;
            // 
            // buttonDALF_Upd
            // 
            buttonDALF_Upd.BackColor = Color.SkyBlue;
            buttonDALF_Upd.BackgroundColor = Color.SkyBlue;
            buttonDALF_Upd.BorderColor = Color.Salmon;
            buttonDALF_Upd.BorderRadius = 10;
            buttonDALF_Upd.BorderSize = 0;
            buttonDALF_Upd.FlatAppearance.BorderSize = 0;
            buttonDALF_Upd.FlatStyle = FlatStyle.Flat;
            buttonDALF_Upd.Font = new Font("Yu Gothic UI Semibold", 10F);
            buttonDALF_Upd.ForeColor = Color.White;
            buttonDALF_Upd.Location = new Point(164, 403);
            buttonDALF_Upd.Margin = new Padding(3, 4, 3, 4);
            buttonDALF_Upd.Name = "buttonDALF_Upd";
            buttonDALF_Upd.Size = new Size(178, 36);
            buttonDALF_Upd.TabIndex = 34;
            buttonDALF_Upd.Text = "Update";
            buttonDALF_Upd.TextColor = Color.White;
            buttonDALF_Upd.UseVisualStyleBackColor = false;
            buttonDALF_Upd.Click += buttonDALF_Upd_Click;
            // 
            // buttonDALF_Del
            // 
            buttonDALF_Del.BackColor = Color.Red;
            buttonDALF_Del.BackgroundColor = Color.Red;
            buttonDALF_Del.BorderColor = Color.Salmon;
            buttonDALF_Del.BorderRadius = 10;
            buttonDALF_Del.BorderSize = 0;
            buttonDALF_Del.FlatAppearance.BorderSize = 0;
            buttonDALF_Del.FlatStyle = FlatStyle.Flat;
            buttonDALF_Del.Font = new Font("Yu Gothic UI Semibold", 10F);
            buttonDALF_Del.ForeColor = Color.White;
            buttonDALF_Del.Location = new Point(24, 403);
            buttonDALF_Del.Margin = new Padding(3, 4, 3, 4);
            buttonDALF_Del.Name = "buttonDALF_Del";
            buttonDALF_Del.Size = new Size(134, 36);
            buttonDALF_Del.TabIndex = 35;
            buttonDALF_Del.Text = "Delete";
            buttonDALF_Del.TextColor = Color.White;
            buttonDALF_Del.UseVisualStyleBackColor = false;
            buttonDALF_Del.Click += buttonDALF_Del_Click;
            // 
            // buttonDALF_Save
            // 
            buttonDALF_Save.BackColor = Color.Salmon;
            buttonDALF_Save.BackgroundColor = Color.Salmon;
            buttonDALF_Save.BorderColor = Color.Salmon;
            buttonDALF_Save.BorderRadius = 15;
            buttonDALF_Save.BorderSize = 0;
            buttonDALF_Save.FlatAppearance.BorderSize = 0;
            buttonDALF_Save.FlatStyle = FlatStyle.Flat;
            buttonDALF_Save.Font = new Font("Yu Gothic UI Semibold", 10F);
            buttonDALF_Save.ForeColor = Color.White;
            buttonDALF_Save.Location = new Point(24, 355);
            buttonDALF_Save.Margin = new Padding(3, 4, 3, 4);
            buttonDALF_Save.Name = "buttonDALF_Save";
            buttonDALF_Save.Size = new Size(318, 43);
            buttonDALF_Save.TabIndex = 36;
            buttonDALF_Save.Text = "Save";
            buttonDALF_Save.TextColor = Color.White;
            buttonDALF_Save.UseVisualStyleBackColor = false;
            buttonDALF_Save.Click += buttonDALF_Save_Click;
            // 
            // labelDALF_Presc
            // 
            labelDALF_Presc.AutoSize = true;
            labelDALF_Presc.Font = new Font("Yu Gothic UI Semibold", 11F);
            labelDALF_Presc.Location = new Point(17, 284);
            labelDALF_Presc.Name = "labelDALF_Presc";
            labelDALF_Presc.Size = new Size(122, 25);
            labelDALF_Presc.TabIndex = 44;
            labelDALF_Presc.Text = "Prescriptions";
            // 
            // labelDALF_Diag
            // 
            labelDALF_Diag.AutoSize = true;
            labelDALF_Diag.Font = new Font("Yu Gothic UI Semibold", 11F);
            labelDALF_Diag.Location = new Point(17, 234);
            labelDALF_Diag.Name = "labelDALF_Diag";
            labelDALF_Diag.Size = new Size(109, 25);
            labelDALF_Diag.TabIndex = 43;
            labelDALF_Diag.Text = "Diagnosing";
            // 
            // labelDALF_PatiId
            // 
            labelDALF_PatiId.AutoSize = true;
            labelDALF_PatiId.Font = new Font("Yu Gothic UI Semibold", 11F);
            labelDALF_PatiId.Location = new Point(17, 136);
            labelDALF_PatiId.Name = "labelDALF_PatiId";
            labelDALF_PatiId.Size = new Size(98, 25);
            labelDALF_PatiId.TabIndex = 42;
            labelDALF_PatiId.Text = "Patient ID";
            // 
            // labelDALF_Patinam
            // 
            labelDALF_Patinam.AutoSize = true;
            labelDALF_Patinam.Font = new Font("Yu Gothic UI Semibold", 11F);
            labelDALF_Patinam.Location = new Point(17, 189);
            labelDALF_Patinam.Name = "labelDALF_Patinam";
            labelDALF_Patinam.Size = new Size(130, 25);
            labelDALF_Patinam.TabIndex = 41;
            labelDALF_Patinam.Text = "Patient Name";
            // 
            // textboxDALF_PatientId
            // 
            textboxDALF_PatientId.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textboxDALF_PatientId.Location = new Point(151, 134);
            textboxDALF_PatientId.Margin = new Padding(3, 4, 3, 4);
            textboxDALF_PatientId.Name = "textboxDALF_PatientId";
            textboxDALF_PatientId.PlaceholderText = "ID";
            textboxDALF_PatientId.Size = new Size(191, 29);
            textboxDALF_PatientId.TabIndex = 80;
            textboxDALF_PatientId.KeyPress += textboxDALF_PatientId_KeyPress;
            // 
            // textboxDALF_PatientName
            // 
            textboxDALF_PatientName.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textboxDALF_PatientName.Location = new Point(151, 187);
            textboxDALF_PatientName.Margin = new Padding(3, 4, 3, 4);
            textboxDALF_PatientName.Name = "textboxDALF_PatientName";
            textboxDALF_PatientName.PlaceholderText = "Name";
            textboxDALF_PatientName.Size = new Size(191, 29);
            textboxDALF_PatientName.TabIndex = 81;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tanı 1", "Tanı 2", "Tanı 3" });
            comboBox1.Location = new Point(151, 235);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(191, 28);
            comboBox1.TabIndex = 84;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Reçete 1", "Reçete 2", "Reçete 3" });
            comboBox2.Location = new Point(151, 285);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(191, 28);
            comboBox2.TabIndex = 85;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // DALF_RandevuGörüntüle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(946, 621);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textboxDALF_PatientName);
            Controls.Add(textboxDALF_PatientId);
            Controls.Add(labelDALF_Presc);
            Controls.Add(labelDALF_Diag);
            Controls.Add(labelDALF_PatiId);
            Controls.Add(labelDALF_Patinam);
            Controls.Add(buttonDALF_Save);
            Controls.Add(buttonDALF_Del);
            Controls.Add(buttonDALF_Upd);
            Controls.Add(dataGridViewDALF_Appointments);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DALF_RandevuGörüntüle";
            Text = "DALF_RandevuGörüntüle";
            Load += DALF_RandevuGörüntüle_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDALF_Appointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewDALF_Appointments;
        private CustomTools.RJButton.RJButton buttonDALF_Upd;
        private CustomTools.RJButton.RJButton buttonDALF_Del;
        private CustomTools.RJButton.RJButton buttonDALF_Save;
        private Label labelDALF_Presc;
        private Label labelDALF_Diag;
        private Label labelDALF_PatiId;
        private Label labelDALF_Patinam;
        private TextBox textboxDALF_PatientId;
        private TextBox textboxDALF_PatientName;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}
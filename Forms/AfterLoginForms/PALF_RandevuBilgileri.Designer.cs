namespace HospitalManagementSystem.Forms.AfterLoginForms
{
    partial class PALF_RandevuBilgileri
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
            components = new System.ComponentModel.Container();
            dataGridViewAktifRandevu = new DataGridView();
            appointmentIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            appointmentDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            appointmentTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            doctorNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            doctorPointDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            patientIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            appointmentBindingSource = new BindingSource(components);
            label1 = new Label();
            doctorRatingButton = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAktifRandevu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)appointmentBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAktifRandevu
            // 
            dataGridViewAktifRandevu.AutoGenerateColumns = false;
            dataGridViewAktifRandevu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAktifRandevu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAktifRandevu.Columns.AddRange(new DataGridViewColumn[] { appointmentIdDataGridViewTextBoxColumn, appointmentDateDataGridViewTextBoxColumn, appointmentTimeDataGridViewTextBoxColumn, doctorNameDataGridViewTextBoxColumn, doctorPointDataGridViewTextBoxColumn, patientIDDataGridViewTextBoxColumn });
            dataGridViewAktifRandevu.DataSource = appointmentBindingSource;
            dataGridViewAktifRandevu.Location = new Point(14, 43);
            dataGridViewAktifRandevu.Margin = new Padding(3, 4, 3, 4);
            dataGridViewAktifRandevu.Name = "dataGridViewAktifRandevu";
            dataGridViewAktifRandevu.RowHeadersWidth = 51;
            dataGridViewAktifRandevu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAktifRandevu.Size = new Size(994, 448);
            dataGridViewAktifRandevu.TabIndex = 0;
            dataGridViewAktifRandevu.CellMouseClick += dataGridViewAktifRandevu_CellMouseClick;
            dataGridViewAktifRandevu.MouseEnter += dataGridViewAktifRandevu_MouseEnter;
            // 
            // appointmentIdDataGridViewTextBoxColumn
            // 
            appointmentIdDataGridViewTextBoxColumn.DataPropertyName = "AppointmentId";
            appointmentIdDataGridViewTextBoxColumn.HeaderText = "AppointmentId";
            appointmentIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            appointmentIdDataGridViewTextBoxColumn.Name = "appointmentIdDataGridViewTextBoxColumn";
            // 
            // appointmentDateDataGridViewTextBoxColumn
            // 
            appointmentDateDataGridViewTextBoxColumn.DataPropertyName = "AppointmentDate";
            appointmentDateDataGridViewTextBoxColumn.HeaderText = "AppointmentDate";
            appointmentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            appointmentDateDataGridViewTextBoxColumn.Name = "appointmentDateDataGridViewTextBoxColumn";
            // 
            // appointmentTimeDataGridViewTextBoxColumn
            // 
            appointmentTimeDataGridViewTextBoxColumn.DataPropertyName = "AppointmentTime";
            appointmentTimeDataGridViewTextBoxColumn.HeaderText = "AppointmentTime";
            appointmentTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            appointmentTimeDataGridViewTextBoxColumn.Name = "appointmentTimeDataGridViewTextBoxColumn";
            // 
            // doctorNameDataGridViewTextBoxColumn
            // 
            doctorNameDataGridViewTextBoxColumn.DataPropertyName = "DoctorName";
            doctorNameDataGridViewTextBoxColumn.HeaderText = "DoctorName";
            doctorNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            doctorNameDataGridViewTextBoxColumn.Name = "doctorNameDataGridViewTextBoxColumn";
            // 
            // doctorPointDataGridViewTextBoxColumn
            // 
            doctorPointDataGridViewTextBoxColumn.DataPropertyName = "DoctorPoint";
            doctorPointDataGridViewTextBoxColumn.HeaderText = "DoctorPoint";
            doctorPointDataGridViewTextBoxColumn.MinimumWidth = 6;
            doctorPointDataGridViewTextBoxColumn.Name = "doctorPointDataGridViewTextBoxColumn";
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            patientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID";
            patientIDDataGridViewTextBoxColumn.HeaderText = "PatientID";
            patientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            // 
            // appointmentBindingSource
            // 
            appointmentBindingSource.DataSource = typeof(Database.Appointment);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 2;
            label1.Text = "Randevular";
            // 
            // doctorRatingButton
            // 
            doctorRatingButton.Location = new Point(547, 499);
            doctorRatingButton.Margin = new Padding(3, 4, 3, 4);
            doctorRatingButton.Name = "doctorRatingButton";
            doctorRatingButton.Size = new Size(137, 31);
            doctorRatingButton.TabIndex = 3;
            doctorRatingButton.Text = "Doctor Rating";
            doctorRatingButton.UseVisualStyleBackColor = true;
            doctorRatingButton.Click += doctorRatingButton_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1 (Vey Bad)", "2 (Bad)", "3 (Normal)", "4 (Good)", "5 (Very Good)" });
            comboBox1.Location = new Point(432, 499);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(107, 28);
            comboBox1.TabIndex = 4;
            // 
            // PALF_RandevuBilgileri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1040, 536);
            Controls.Add(comboBox1);
            Controls.Add(doctorRatingButton);
            Controls.Add(label1);
            Controls.Add(dataGridViewAktifRandevu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PALF_RandevuBilgileri";
            Text = "PALF_RandevuBilgileri";
            Load += PALF_RandevuBilgileri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAktifRandevu).EndInit();
            ((System.ComponentModel.ISupportInitialize)appointmentBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewAktifRandevu;
        private Label label1;
        private DataGridViewTextBoxColumn appointmentIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn appointmentDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn appointmentTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn doctorNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn doctorPointDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private BindingSource appointmentBindingSource;
        private Button doctorRatingButton;
        private ComboBox comboBox1;
    }
}
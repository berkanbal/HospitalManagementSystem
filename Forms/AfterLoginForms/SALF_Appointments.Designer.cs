namespace HospitalManagementSystem.Forms.AfterLoginForms
{
    partial class SALF_Appointments
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
            DataGridSALF_Appointments = new DataGridView();
            LabelSALF_AllAppointments = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridSALF_Appointments).BeginInit();
            SuspendLayout();
            // 
            // DataGridSALF_Appointments
            // 
            DataGridSALF_Appointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridSALF_Appointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridSALF_Appointments.Location = new Point(93, 80);
            DataGridSALF_Appointments.Name = "DataGridSALF_Appointments";
            DataGridSALF_Appointments.RowHeadersWidth = 51;
            DataGridSALF_Appointments.Size = new Size(819, 498);
            DataGridSALF_Appointments.TabIndex = 0;
            // 
            // LabelSALF_AllAppointments
            // 
            LabelSALF_AllAppointments.AutoSize = true;
            LabelSALF_AllAppointments.Font = new Font("Yu Gothic UI Semibold", 11F);
            LabelSALF_AllAppointments.Location = new Point(93, 38);
            LabelSALF_AllAppointments.Name = "LabelSALF_AllAppointments";
            LabelSALF_AllAppointments.Size = new Size(162, 25);
            LabelSALF_AllAppointments.TabIndex = 53;
            LabelSALF_AllAppointments.Text = "All Appointments";
            // 
            // SALF_Appointments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(998, 621);
            Controls.Add(LabelSALF_AllAppointments);
            Controls.Add(DataGridSALF_Appointments);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SALF_Appointments";
            Text = "SALF_Appointments";
            Load += SALF_Appointments_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridSALF_Appointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridSALF_Appointments;
        private Label LabelSALF_AllAppointments;
    }
}
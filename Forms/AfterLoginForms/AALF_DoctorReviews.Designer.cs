namespace HospitalManagementSystem.Forms.AfterLoginForms
{
    partial class AALF_DoctorReviews
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
            dataGridViewAALF_DoctorReviews = new DataGridView();
            labelAALF_DR = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAALF_DoctorReviews).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAALF_DoctorReviews
            // 
            dataGridViewAALF_DoctorReviews.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAALF_DoctorReviews.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAALF_DoctorReviews.Location = new Point(247, 87);
            dataGridViewAALF_DoctorReviews.Name = "dataGridViewAALF_DoctorReviews";
            dataGridViewAALF_DoctorReviews.RowHeadersWidth = 51;
            dataGridViewAALF_DoctorReviews.Size = new Size(920, 413);
            dataGridViewAALF_DoctorReviews.TabIndex = 0;
            // 
            // labelAALF_DR
            // 
            labelAALF_DR.AutoSize = true;
            labelAALF_DR.Font = new Font("Yu Gothic UI Semibold", 13F);
            labelAALF_DR.Location = new Point(247, 32);
            labelAALF_DR.Name = "labelAALF_DR";
            labelAALF_DR.Size = new Size(168, 30);
            labelAALF_DR.TabIndex = 29;
            labelAALF_DR.Text = "Doctor Reviews";
            // 
            // AALF_DoctorReviews
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1448, 553);
            Controls.Add(labelAALF_DR);
            Controls.Add(dataGridViewAALF_DoctorReviews);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AALF_DoctorReviews";
            Text = "AALF_DoctorReviews";
            Load += AALF_DoctorReviews_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAALF_DoctorReviews).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewAALF_DoctorReviews;
        private Label labelAALF_DR;
    }
}
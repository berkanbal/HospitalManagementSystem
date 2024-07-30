using HospitalManagementSystem.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.Forms.AfterLoginForms
{
    public partial class DALF_RandevuGörüntüle : Form
    {
        HospitalDbContext context;
        public string patientDB_ID { get; set; }
        public DALF_RandevuGörüntüle()
        {
            InitializeComponent();
            context = new HospitalDbContext();
        }

        private void textboxDALF_PatientId_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.TextBoxValidation.onlyNumber(sender, e, textboxDALF_PatientId);
        }

        private void buttonDALF_Save_Click(object sender, EventArgs e)
        {
            using (HospitalDbContext context = new HospitalDbContext())
            {

                if (textboxDALF_PatientId.Text != "")
                {
                    MessageBox.Show("Database Registration successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen bir hasta ID'si giriniz.");
                }
            }
        }

        private void DALF_RandevuGörüntüle_Load(object sender, EventArgs e)
        {
            Helper.Helper helper = new Helper.Helper();
            helper.loadDataPatients(dataGridViewDALF_Appointments, context);
        }

        private void dataGridViewDALF_Appointments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewDALF_Appointments.Columns[e.ColumnIndex].Name == "password" && e.Value != null)
            {
                // Hücre değerini sansürle
                e.Value = new string('*', 5);
                e.FormattingApplied = true;
            }
        }

        private void dataGridViewDALF_Appointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;
            if (selectedRowIndex >= 0 && selectedRowIndex < dataGridViewDALF_Appointments.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridViewDALF_Appointments.Rows[selectedRowIndex];

                string columnName = selectedRow.Cells["name"].Value.ToString();
                string columnID = selectedRow.Cells["identification"].Value.ToString();


                this.patientDB_ID = selectedRow.Cells["PatientID"].Value.ToString();

                textboxDALF_PatientName.Text = columnName;
                textboxDALF_PatientId.Text = columnID;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Tanım 1":
                    comboBox1.Items.Clear();
                    comboBox1.Text = string.Empty;
                    comboBox1.Items.AddRange(new string[] { "Tanı 1", "Tanı 2", "Tanı 3" });
                    break;
                case "Tanım 2":
                    comboBox1.Items.Clear();
                    comboBox1.Text = string.Empty;
                    comboBox1.Items.AddRange(new string[] { "Tanı 1", "Tanı 2", "Tanı 3" });
                    break;
                case "Tanım 3":
                    comboBox1.Items.Clear();
                    comboBox1.Text = string.Empty;
                    comboBox1.Items.AddRange(new string[] { "Tanı 1", "Tanı 2", "Tanı 3" });
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {
                case "Reçetem 1":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(new string[] { "Reçete 1", "Reçete 2", "Reçete 3" });
                    break;
                case "Reçetem 2":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(new string[] { "Reçete 1", "Reçete 2", "Reçete 3" });
                    break;
                case "Reçetem 3":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(new string[] { "Reçete 1", "Reçete 2", "Reçete 3" });
                    break;
            }
        }

        private void buttonDALF_Upd_Click(object sender, EventArgs e)
        {
            using (HospitalDbContext context = new HospitalDbContext())
            {

                if (textboxDALF_PatientId.Text != "")
                {
                    MessageBox.Show("Database Registration successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen bir hasta ID'si giriniz.");
                }
            }
        }

        private void buttonDALF_Del_Click(object sender, EventArgs e)
        {
            using (HospitalDbContext context = new HospitalDbContext())
            {

                if (textboxDALF_PatientId.Text != "")
                {
                    MessageBox.Show("Database Registration successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen bir hasta ID'si giriniz.");
                }
            }
        }
    }
}

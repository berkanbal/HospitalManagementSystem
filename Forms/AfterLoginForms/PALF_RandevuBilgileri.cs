using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Data.Common;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace HospitalManagementSystem.Forms.AfterLoginForms
{
    public partial class PALF_RandevuBilgileri : Form
    {
        SqlConnection bag = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=HospitalManagementSystem;Integrated Security=True;Trust Server Certificate=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;

        public PALF_RandevuBilgileri()
        {
            InitializeComponent();
        }

        public void randevuGetir(string pid)
        {
            dataGridViewAktifRandevu.DataSource = null;
            pid = PatientALF.gidenpatiid.ToString();

            bag.Open();
            string query = "SELECT * FROM Appointments WHERE PatientID = @PatiID";

            using (SqlCommand cmd = new SqlCommand(query, bag))
            {
                cmd.Parameters.AddWithValue("@PatiID", pid);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewAktifRandevu.DataSource = dt;
                }
            }

            bag.Close();
        }

        public void dataGridViewAktifRandevu_MouseEnter(object sender, EventArgs e)
        {
            randevuGetir(PatientALF.gidenpatiid);
        }

        int i = 0;

        public void doctorRatingButton_Click(object sender, EventArgs e)
        {
            string sorgu = ("UPDATE Appointments SET DoctorPoint=@doctorPoint WHERE AppointmentID=@AppID");
            cmd = new SqlCommand(sorgu, bag);
            cmd.Parameters.AddWithValue("@doctorPoint", comboBox1.Text);
            cmd.Parameters.AddWithValue("@AppID", dataGridViewAktifRandevu.Rows[i].Cells[0].Value);
            bag.Open();
            cmd.ExecuteNonQuery();
            bag.Close();
            randevuGetir(PatientALF.gidenpatiid);
        }

        private void PALF_RandevuBilgileri_Load(object sender, EventArgs e)
        {
            randevuGetir(PatientALF.gidenpatiid);
        }

        private void dataGridViewAktifRandevu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;
        }
    }

}

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
using Azure.Core.Pipeline;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using HospitalManagementSystem.Database;
using System.Diagnostics;


namespace HospitalManagementSystem.Forms.AfterLoginForms
{
    public partial class PALF_RandevuAl : Form
    {
        SqlConnection bag = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=HospitalManagementSystem;Integrated Security=True;Trust Server Certificate=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;

        public PALF_RandevuAl()
        {
            InitializeComponent();
        }

        void doctorgetir1()
        {
            bag.Open();
            cmd = new SqlCommand("Select *from Doctors where branch='Kulak Burun Boğaz'", bag);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cBoxRandevuDoktorSec.Items.Add(reader[1] + " " + reader[2]);
            }
            bag.Close();
        }

        void doctorgetir2()
        {
            bag.Open();
            cmd = new SqlCommand("Select *from Doctors where branch='Beyin Cerrahi'", bag);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cBoxRandevuDoktorSec.Items.Add(reader[1] + " " + reader[2]);
            }
            bag.Close();
        }

        void doctorgetir3()
        {
            bag.Open();
            cmd = new SqlCommand("Select *from Doctors where branch='Çocuk Hastalıkları'", bag);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cBoxRandevuDoktorSec.Items.Add(reader[1] + " " + reader[2]);
            }
            bag.Close();
        }

        private void cBoxRandevuPoliklinikSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cBoxRandevuPoliklinikSec.Text)
            {
                case "Kulak Burun Boğaz":
                    cBoxRandevuDoktorSec.Items.Clear();
                    cBoxRandevuDoktorSec.Text = string.Empty;
                    doctorgetir1();
                    break;

                case "Beyin Cerrahi":
                    cBoxRandevuDoktorSec.Items.Clear();
                    cBoxRandevuDoktorSec.Text = string.Empty;
                    doctorgetir2();
                    break;

                case "Çocuk Hastalıkları":
                    cBoxRandevuDoktorSec.Items.Clear();
                    cBoxRandevuDoktorSec.Text = string.Empty;
                    doctorgetir3();
                    break;
            }
        }

        public void saatkontrol(string doctorName, DateTime date, string saat, string pid)
        {
            doctorName = cBoxRandevuDoktorSec.Text;
            saat = cbSaat.Text;
            date = dtpRandevuTarihSec.Value;
            DateOnly dateonly = DateOnly.FromDateTime(date);
            pid = PatientALF.gidenpatiid.ToString();

            bag.Open();

            string query = "SELECT COUNT(*) FROM Appointments WHERE DoctorName = @DoctorName AND AppointmentTime = @AppointmentTime AND AppointmentDate = @AppointmentDate";

            using (SqlCommand cmd = new SqlCommand(query, bag))
            {
                cmd.Parameters.AddWithValue("@DoctorName", doctorName);
                cmd.Parameters.AddWithValue("@AppointmentTime", saat);
                cmd.Parameters.AddWithValue("@AppointmentDate", dateonly);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("There is already an appointment for this doctor at this time.");
                }
                else
                {
                    string insertQuery = "INSERT INTO Appointments (DoctorName, AppointmentDate, AppointmentTime,PatientID) VALUES (@DoctorName, @AppointmentDate, @AppointmentTime,@PatiID)";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, bag))
                    {
                        insertCmd.Parameters.AddWithValue("@DoctorName", doctorName);
                        insertCmd.Parameters.AddWithValue("@AppointmentDate", dateonly);
                        insertCmd.Parameters.AddWithValue("@AppointmentTime", saat);
                        insertCmd.Parameters.AddWithValue("@PatiID", pid);

                        insertCmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("You are appointment successfully booked");
                }
            }
            bag.Close();
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            saatkontrol(cBoxRandevuDoktorSec.Text, dtpRandevuTarihSec.Value, cbSaat.Text, PatientALF.gidenpatiid);
        }
    }
}


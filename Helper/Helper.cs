using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementSystem.Database;

namespace HospitalManagementSystem.Helper
{
    public class Helper
    {
        private Panel panel;
        public Helper(Panel _panel)
        {
            this.panel = _panel;
        }
        public Helper()
        {
            
        }
        public void formGoster(Form form, string formName)
        {
            panel.Controls.Clear();
            
            if (form != null)
            {
                switch (formName)
                {
                    case "MainLoginButtons":
                        form.TopLevel = false;
                        form.AutoScroll = true;
                        form.Dock = DockStyle.None;
                        form.Location = new Point(1, 56);
                        panel.Controls.Add(form);
                        form.Show();
                        break;
                    case "PatientLoginGUI":
                        form.TopLevel = false;
                        form.AutoScroll = true;
                        form.Dock = DockStyle.None;
                        form.Location = new Point(1, 56);
                        panel.Controls.Add(form);
                        form.Show();
                        break;
                    case "DoctorLoginGUI":
                        form.TopLevel = false;
                        form.AutoScroll = true;
                        form.Dock = DockStyle.None;
                        form.Location = new Point(1, 56);
                        panel.Controls.Add(form);
                        form.Show();
                        break;
                    case "SecretaryLoginGUI":
                        form.TopLevel = false;
                        form.AutoScroll = true;
                        form.Dock = DockStyle.None;
                        form.Location = new Point(1, 56);
                        panel.Controls.Add(form);
                        form.Show();
                        break;
                    case "AdminLoginGUI":
                        form.TopLevel = false;
                        form.AutoScroll = true;
                        form.Dock = DockStyle.None;
                        form.Location = new Point(1, 56);
                        panel.Controls.Add(form);
                        form.Show();
                        break;
                    case "PatientSignUpGUI":
                        form.TopLevel = false;
                        form.AutoScroll = true;
                        form.Dock = DockStyle.None;
                        form.Location = new Point(1, 56);
                        panel.Controls.Add(form);
                        form.Show();
                        break;
                    case "PALF_RandevuAl":
                        form.TopLevel = false;
                        form.FormBorderStyle = FormBorderStyle.None;
                        form.Dock = DockStyle.Fill;
                        panel.Controls.Clear();
                        panel.Controls.Add(form);
                        form.Show();
                        break;
                    case "PALF_RandevuBilgileri":
                        form.TopLevel = false;
                        form.FormBorderStyle = FormBorderStyle.None;
                        form.Dock = DockStyle.Fill;
                        panel.Controls.Clear();
                        panel.Controls.Add(form);
                        form.Show();
                        break;
                    case "PALF_Bilgilerim":
                        form.TopLevel = false;
                        form.FormBorderStyle = FormBorderStyle.None;
                        form.Dock = DockStyle.Fill;
                        panel.Controls.Clear();
                        panel.Controls.Add(form);
                        form.Show();
                        break;
                    case "DALF_Bilgilerim":
                        form.TopLevel = false;
                        form.FormBorderStyle = FormBorderStyle.None;
                        form.Dock = DockStyle.Fill;
                        panel.Controls.Clear();
                        panel.Controls.Add(form);
                        form.Show();
                        break;
                    case "DALF_RandevuGörüntüle":
                        form.TopLevel = false;
                        form.FormBorderStyle = FormBorderStyle.None;
                        form.Dock = DockStyle.Fill;
                        panel.Controls.Clear();
                        panel.Controls.Add(form);
                        form.Show();
                        break;
                    case "SALF_MadeAppointment":
                        form.TopLevel = false;
                        form.FormBorderStyle = FormBorderStyle.None;
                        form.Dock = DockStyle.Fill;
                        panel.Controls.Clear();
                        panel.Controls.Add(form);
                        form.Show();
                        break;
                    case "SALF_Information":
                        form.TopLevel = false;
                        form.FormBorderStyle = FormBorderStyle.None;
                        form.Dock = DockStyle.Fill;
                        panel.Controls.Clear();
                        panel.Controls.Add(form);
                        form.Show();
                        break;
                    case "SALF_Appointments":
                        form.TopLevel = false;
                        form.FormBorderStyle = FormBorderStyle.None;
                        form.Dock = DockStyle.Fill;
                        panel.Controls.Clear();
                        panel.Controls.Add(form);
                        form.Show();
                        break;
                    case "ALF_PasswordUpdate":
                        form.TopLevel = false;
                        form.FormBorderStyle = FormBorderStyle.None;
                        form.Dock = DockStyle.Fill;
                        panel.Controls.Clear();
                        panel.Controls.Add(form);
                        form.Show();
                        break;
                    case "AALF_SecretaryEdit":
                        form.TopLevel = false;
                        form.FormBorderStyle = FormBorderStyle.None;
                        form.Dock = DockStyle.Fill;
                        panel.Controls.Clear();
                        panel.Controls.Add(form);
                        form.Show();
                        break;
                    case "AALF_DoctorEdit":
                        form.TopLevel = false;
                        form.FormBorderStyle = FormBorderStyle.None;
                        form.Dock = DockStyle.Fill;
                        panel.Controls.Clear();
                        panel.Controls.Add(form);
                        form.Show();
                        break;
                    case "AALF_DoctorReviews":
                        form.TopLevel = false;
                        form.FormBorderStyle = FormBorderStyle.None;
                        form.Dock = DockStyle.Fill;
                        panel.Controls.Clear();
                        panel.Controls.Add(form);
                        form.Show();
                        break;
                    case "ALF_Information":
                        form.TopLevel = false;
                        form.FormBorderStyle = FormBorderStyle.None;
                        form.Dock = DockStyle.Fill;
                        panel.Controls.Clear();
                        panel.Controls.Add(form);
                        form.Show();
                        break;
                    default:
                        panel.Controls.Clear();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Sayfa bulunamadi.");
            }
        }
        public void loadDataSecretaries(DataGridView dataGridView, HospitalDbContext context)
        {
            dataGridView.DataSource = context.Secretaries.ToList();
        }
        public void loadDataDoctors(DataGridView dataGridView, HospitalDbContext context)
        {
            dataGridView.DataSource = context.Doctors.ToList();
        }

        public void loadDataDoctorsReviews(DataGridView dataGridView, HospitalDbContext context)
        {
            dataGridView.DataSource = context.Appointments.ToList();
        }
        public void loadDataPatients(DataGridView dataGridView, HospitalDbContext context)
        {
            dataGridView.DataSource = context.Patients.ToList();
        }

    }
}

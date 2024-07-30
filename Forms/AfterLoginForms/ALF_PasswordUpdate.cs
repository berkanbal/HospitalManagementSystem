using HospitalManagementSystem.Database;
using HospitalManagementSystem.Forms.LoginForms;
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
    public partial class ALF_PasswordUpdate : Form
    {
        Panel panel;
        Helper.Helper helper;
        public Object gelenKullanici { get; set; }
        public Doctor doctor { get; set; }
        public Secretary secretary { get; set; }
        public Patient patient { get; set; }
        public ALF_PasswordUpdate()
        {
            InitializeComponent();
        }
        public ALF_PasswordUpdate(Panel _panel)
        {
            InitializeComponent();
            this.panel = _panel;
        }
        public ALF_PasswordUpdate(Panel _panel, Object _gelenKullanici)
        {
            InitializeComponent();
            this.panel = _panel;
            this.gelenKullanici = _gelenKullanici;

            if (gelenKullanici is Patient)
            {
                patient = (Patient)gelenKullanici;
            }
            else if (gelenKullanici is Secretary)
            {
                secretary = (Secretary)gelenKullanici;
            }
            else if (gelenKullanici is Doctor)
            {
                doctor = (Doctor)gelenKullanici;
            }
        }

        private void rjBtnAdminBackMain_Click(object sender, EventArgs e)
        {
            Helper.Helper helper = new Helper.Helper(panel);
            ALF_Information pALF_Bilgilerim = new ALF_Information(panel, gelenKullanici);
            helper.formGoster(pALF_Bilgilerim, pALF_Bilgilerim.Name);
        }

        private void rjBtnPasswordUpdate_Click(object sender, EventArgs e)
        {
            using (var context = new HospitalDbContext())
            {
                if (gelenKullanici is Doctor)
                {
                    context.updateDoctorPasswordByID(Convert.ToInt32(doctor.DoctorId),
                        textboxOldPassword.Text,
                        textboxNewPassword.Text,
                        textboxNewPasswordAgain.Text,
                        doctor.password
                        );
                }
                else if (gelenKullanici is Secretary)
                {
                    context.updateSecretaryPasswordByID(Convert.ToInt32(secretary.SecretaryId),
                        textboxOldPassword.Text,
                        textboxNewPassword.Text,
                        textboxNewPasswordAgain.Text,
                        secretary.password
                        );
                }
                else if (gelenKullanici is Patient)
                {
                    context.updatePatientPasswordByID(Convert.ToInt32(patient.PatientId),
                        textboxOldPassword.Text,
                        textboxNewPassword.Text,
                        textboxNewPasswordAgain.Text,
                        patient.password
                        );
                }
                context.SaveChanges();
            }
        }
    }
}

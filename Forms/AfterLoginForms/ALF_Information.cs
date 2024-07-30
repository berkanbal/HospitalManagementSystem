using HospitalManagementSystem.Database;
using HospitalManagementSystem.UML;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class ALF_Information : Form
    {
        Panel panel;
        ALF_PasswordUpdate _ALF_PasswordUpdate;
        public Object gelenKullanici { get; set; }
        public Doctor doctor { get; set; }
        public Secretary secretary { get; set; }
        public Patient patient { get; set; }
        public ALF_Information()
        {
            InitializeComponent();
        }
        public ALF_Information(Panel _panel)
        {
            InitializeComponent();
            this.panel = _panel;
            _ALF_PasswordUpdate = new ALF_PasswordUpdate(panel);
        }
        public ALF_Information(Panel _panel, Object _gelenKullanici)
        {
            InitializeComponent();
            this.panel = _panel;
            _ALF_PasswordUpdate = new ALF_PasswordUpdate(panel);
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

        private void linkLabelPasswordUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Helper.Helper helper = new Helper.Helper(panel);
            ALF_PasswordUpdate aLF_PasswordUpdate = new ALF_PasswordUpdate(panel,gelenKullanici);
            helper.formGoster(aLF_PasswordUpdate, aLF_PasswordUpdate.Name);
        }

        private void textboxALF_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.TextBoxValidation.onlyNumber(sender, e, textboxALF_Id);
        }

        private void textboxALF_GSM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.TextBoxValidation.onlyNumber(sender, e, textboxALF_GSM);
        }
        private void ALF_Information_Load(object sender, EventArgs e)
        {

            using (var context = new HospitalDbContext())
            {
                if (gelenKullanici is Doctor)
                {
                    textboxALF_Name.Text = doctor.name;
                    textboxALF_Surname.Text = doctor.surname;
                    textboxALF_Id.Text = doctor.identification;
                    textboxALF_GSM.Text = doctor.GSM_No;
                }
                else if (gelenKullanici is Secretary)
                {
                    textboxALF_Name.Text = secretary.name;
                    textboxALF_Surname.Text = secretary.surname;
                    textboxALF_Id.Text = secretary.identification;
                    textboxALF_GSM.Text = secretary.GSM_No;
                }
                else if (gelenKullanici is Patient)
                {
                    textboxALF_Name.Text = patient.name;
                    textboxALF_Surname.Text = patient.surname;
                    textboxALF_Id.Text = patient.identification;
                    textboxALF_GSM.Text = patient.GSM_No;
                }
            }
        }

        private void buttonPALF_Upd_Click(object sender, EventArgs e)
        {
            using (var context = new HospitalDbContext())
            {
                if (gelenKullanici is Doctor)
                {
                    context.updateDoctorByID(Convert.ToInt32(doctor.DoctorId),
                        textboxALF_Name.Text,
                        textboxALF_Surname.Text,
                        textboxALF_Id.Text,
                        textboxALF_GSM.Text
                        );
                }
                else if (gelenKullanici is Secretary)
                {
                    context.updateSecretaryByID(Convert.ToInt32(secretary.SecretaryId),
                        textboxALF_Name.Text,
                        textboxALF_Surname.Text,
                        textboxALF_Id.Text,
                        textboxALF_GSM.Text
                        );
                }
                else if (gelenKullanici is Patient)
                {
                    context.updatePatientByID(Convert.ToInt32(patient.PatientId),
                    textboxALF_Name.Text,
                    textboxALF_Surname.Text,
                    textboxALF_Id.Text,
                    textboxALF_GSM.Text
                    );
                }
                context.SaveChanges();
            }

        }
    }
}

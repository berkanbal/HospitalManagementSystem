using HospitalManagementSystem.Database;
using Microsoft.Identity.Client;
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
    public partial class PatientALF : Form
    {
        Helper.Helper helper;

        PALF_RandevuAl randevuAl;
        PALF_RandevuBilgileri randevuBilgileri;
        ALF_Information bilgilerim;
        public static string gidenpatiid;
        public Patient patient { get; set; }
            
        public PatientALF( Patient _patient)
        {
            InitializeComponent();
            this.patient = _patient;

        }


        private void PatientALF_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PatientALF_Load(object sender, EventArgs e)
        {
            helper = new Helper.Helper(panelPatientALF);
            randevuAl = new PALF_RandevuAl();
            helper.formGoster(randevuAl, randevuAl.Name);
            
            label2.Text=patient.identification;
            gidenpatiid =label2.Text;
            PALF_RandevuAl randevualform = new PALF_RandevuAl();

            label3.Text = $"{patient.name} {patient.surname}";
        }

        private void buttonPALF_RandevuAl_Click(object sender, EventArgs e)
        {
            helper = new Helper.Helper(panelPatientALF);
            randevuAl = new PALF_RandevuAl();
            helper.formGoster(randevuAl, randevuAl.Name);
        }

        private void buttonPALF_RandevuBilgileri_Click(object sender, EventArgs e)
        {
            helper = new Helper.Helper(panelPatientALF);
            randevuBilgileri = new PALF_RandevuBilgileri();
            helper.formGoster(randevuBilgileri, randevuBilgileri.Name);
        }

        private void buttonPALF_Bilgilerim_Click(object sender, EventArgs e)
        {
            helper = new Helper.Helper(panelPatientALF);
            bilgilerim = new ALF_Information(panelPatientALF, patient);
            helper.formGoster(bilgilerim,bilgilerim.Name);
        }
    }
}

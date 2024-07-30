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
    public partial class DoctorALF : Form
    {
        Helper.Helper helper;

        ALF_Information ALF_Information;
        DALF_RandevuGörüntüle dalf_randevuGörüntüle;
        public Doctor doctor { get; set; }
       
        public DoctorALF(Doctor doctor)
        {
            InitializeComponent();
            this.doctor = doctor;
           
        }
     

        private void buttonDALF_ViewAppointment_Click(object sender, EventArgs e)
        {
            helper = new Helper.Helper(panelDoctorALF);
            dalf_randevuGörüntüle = new DALF_RandevuGörüntüle();
            helper.formGoster(dalf_randevuGörüntüle, dalf_randevuGörüntüle.Name);
        }

        private void DoctorALF_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DoctorALF_Load(object sender, EventArgs e)
        {
            helper = new Helper.Helper(panelDoctorALF);
            ALF_Information = new ALF_Information(panelDoctorALF,doctor);
            helper.formGoster(ALF_Information, ALF_Information.Name);
            
            label1.Text = doctor.identification;
            label2.Text = $"{doctor.name} {doctor.surname}";


        }

        private void buttonDALF_İnformation_Click(object sender, EventArgs e)
        {
            helper = new Helper.Helper(panelDoctorALF);
            ALF_Information = new ALF_Information(panelDoctorALF,doctor);
            helper.formGoster(ALF_Information, ALF_Information.Name);
        }
    }
}

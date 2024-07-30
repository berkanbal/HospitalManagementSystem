using HospitalManagementSystem.Helper;
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
    public partial class AdminALF : Form
    {
        public string adminID { get; set; }
        public string adminName { get; set; }

        public string adminSurname { get; set; }

        Helper.Helper helper;

        AALF_SecretaryEdit aalf_secretary;
        AALF_DoctorEdit aalf_doctor;
        AALF_DoctorReviews aalf_doctorReviews;

        public AdminALF(string _adminID, string _adminName, string _adminSurname)
        {
            InitializeComponent();
            this.adminID = _adminID;
            this.adminName = _adminName;
            this.adminSurname = _adminSurname;
        }

        private void AdminALF_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonAALF_Secretary_Click(object sender, EventArgs e)
        {
            helper = new Helper.Helper(panelAdminALF);
            aalf_secretary = new AALF_SecretaryEdit();
            helper.formGoster(aalf_secretary, aalf_secretary.Name);
        }

        private void buttonAALF_DoctorEdit_Click(object sender, EventArgs e)
        {
            helper = new Helper.Helper(panelAdminALF);
            aalf_doctor = new AALF_DoctorEdit();
            helper.formGoster(aalf_doctor, aalf_doctor.Name);
        }

        private void buttonAALF_DoctorReview_Click(object sender, EventArgs e)
        {
            helper = new Helper.Helper(panelAdminALF);
            aalf_doctorReviews = new AALF_DoctorReviews();
            helper.formGoster(aalf_doctorReviews, aalf_doctorReviews.Name);
        }

        private void AdminALF_Load(object sender, EventArgs e)
        {
            labelAALF_AdminID.Text = adminID.ToString();
            labelAALF_AdminName.Text = adminName.ToString() + " " + adminSurname.ToString();
        }
    }
}

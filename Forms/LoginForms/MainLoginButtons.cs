using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagementSystem.Forms.LoginForms;
using HospitalManagementSystem;
using HospitalManagementSystem.Helper;

namespace HospitalManagementSystem.Forms
{
    public partial class MainLoginButtons : Form
    {
        Panel panel;
        LoginGUI loginGUI;

        PatientLoginGUI patientLoginGUI;
        DoctorLoginGUI doctorLoginGUI;
        SecretaryLoginGUI secretaryLoginGUI;
        AdminLoginGUI adminLoginGUI;

        public MainLoginButtons(Panel _panel)
        {
            InitializeComponent();
            this.panel = _panel;
        }
        public MainLoginButtons(Panel _panel, LoginGUI _loginGUI)
        {
            InitializeComponent();
            this.panel = _panel;
            this.loginGUI = _loginGUI;
        }

        private void rjBtnPatientLogin_Click(object sender, EventArgs e)
        {
            //PatientLoginGUI sayfasini panel uzerinde goster. Ve panel nesnesini ctor ile GUI Formuna gonder
            Helper.Helper helper = new Helper.Helper(panel);
            patientLoginGUI = new PatientLoginGUI(panel, loginGUI);
            helper.formGoster(patientLoginGUI, patientLoginGUI.Name);
        }

        private void rjBtnDoctorLogin_Click(object sender, EventArgs e)
        {
            //DoctorLoginGUI sayfasini panel uzerinde goster.
            Helper.Helper helper = new Helper.Helper(panel);
            doctorLoginGUI = new DoctorLoginGUI(panel, loginGUI);
            helper.formGoster(doctorLoginGUI, doctorLoginGUI.Name);
        }

        private void rjBtnSecretaryLogin_Click(object sender, EventArgs e)
        {
            //SecretaryLoginGUI sayfasini panel uzerinde goster.
            Helper.Helper helper = new Helper.Helper(panel);
            secretaryLoginGUI = new SecretaryLoginGUI(panel, loginGUI);
            helper.formGoster(secretaryLoginGUI, secretaryLoginGUI.Name);
        }

        private void rjBtnAdminLogin_Click(object sender, EventArgs e)
        {
            //AdminLoginGUI sayfasini panel uzerinde goster.
            Helper.Helper helper = new Helper.Helper(panel);
            adminLoginGUI = new AdminLoginGUI(panel, loginGUI);
            helper.formGoster(adminLoginGUI, adminLoginGUI.Name);
        }
    }
}

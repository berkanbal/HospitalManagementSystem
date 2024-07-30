using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagementSystem.Database;
using HospitalManagementSystem.Forms.AfterLoginForms;

namespace HospitalManagementSystem.Forms.LoginForms
{
    public partial class PatientLoginGUI : Form
    {
        Panel panel;
        LoginGUI LoginGUI;

        MainLoginButtons mainLoginButtons;
        PatientSignUpGUI patientSignUpGUI;
        Helper.Helper helper;
        public PatientLoginGUI(Panel _panel)
        {
            InitializeComponent();
            this.panel = _panel;
        }
        public PatientLoginGUI(Panel _panel, LoginGUI _loginGUI)
        {
            InitializeComponent();
            this.panel = _panel;
            this.LoginGUI = _loginGUI;
        }
        private void rjBtnPatientBackMain_Click(object sender, EventArgs e)
        {
            // MainLoginButtons'a geri don ve paneli ilet
            Helper.Helper helper = new Helper.Helper(panel);
            mainLoginButtons = new MainLoginButtons(panel, LoginGUI);
            helper.formGoster(mainLoginButtons, mainLoginButtons.Name);
        }

        private void rjBtnPatientSignUp_Click(object sender, EventArgs e)
        {
            // PatientSignUpGUI'a git ve paneli ilet
            Helper.Helper helper = new Helper.Helper(panel);
            patientSignUpGUI = new PatientSignUpGUI(panel, LoginGUI);
            helper.formGoster(patientSignUpGUI, patientSignUpGUI.Name);
        }

        private void rjBtnPatientSignIn_Click(object sender, EventArgs e)
        {
            bool tb_id = Helper.TextBoxValidation.IsTextBoxEmpty(textBoxPatientLoginId);
            bool tb_password = Helper.TextBoxValidation.IsTextBoxEmpty(textBoxPatientPassword);
            if (tb_id && tb_password)
            {
                Helper.PasswordHasher hasher = new Helper.PasswordHasher();
                string patientLoginID = textBoxPatientLoginId.Text;
                string patientPassword = textBoxPatientPassword.Text;
                bool passwordControl;
                using (var context = new HospitalDbContext())
                {
                    var user = context.PatientIDValidation(patientLoginID);
                    if (user != null)
                    {
                        passwordControl = hasher.VerifyPassword(patientPassword, user.password);
                        if (passwordControl)
                        {

                            PatientALF patientALF = new PatientALF(user);

                            patientALF.Show();
                            LoginGUI.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Sign Up!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Password or ID cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxPatientLoginId_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.TextBoxValidation.onlyNumber(sender, e, textBoxPatientLoginId);
        }
    }
}

using HospitalManagementSystem.Database;
using HospitalManagementSystem.Forms.AfterLoginForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.Forms.LoginForms
{
    public partial class DoctorLoginGUI : Form
    {
        Panel panel;

        Helper.Helper helper;
        LoginGUI loginGUI;

        MainLoginButtons loginButtons;
        public DoctorLoginGUI(Panel _panel)
        {
            InitializeComponent();
            this.panel = _panel;
        }
        public DoctorLoginGUI(Panel _panel, LoginGUI _loginGUI)
        {
            InitializeComponent();
            this.panel = _panel;
            this.loginGUI = _loginGUI;
        }

        private void rjBtnDoctorBackMain_Click(object sender, EventArgs e)
        {
            // MainLoginButtons'a geri don ve paneli ilet.
            Helper.Helper helper = new Helper.Helper(panel);
            loginButtons = new MainLoginButtons(panel, loginGUI);
            helper.formGoster(loginButtons, loginButtons.Name);
           
        }

        private void rjBtnDoctorSignIn_Click(object sender, EventArgs e)
        {
            bool tb_id = Helper.TextBoxValidation.IsTextBoxEmpty(textBoxDoctorLogiId);
            bool tb_password = Helper.TextBoxValidation.IsTextBoxEmpty(textboxDoctorPassword);

            if (tb_id && tb_password)
            {
                Helper.PasswordHasher hasher = new Helper.PasswordHasher();

                string doctorID = textBoxDoctorLogiId.Text;
                string doctorPassword = textboxDoctorPassword.Text;

                bool passwordControl;
                using (var context = new HospitalDbContext())
                {
                    var user = context.DoctorIDValidation(doctorID);
                    if (user != null)
                    {
                        passwordControl = hasher.VerifyPassword(doctorPassword, user.password);
                        if (passwordControl)
                        {
                            DoctorALF doctorALF = new DoctorALF(user);
                            doctorALF.Show();
                            loginGUI.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Password or ID cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxDoctorLogiId_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.TextBoxValidation.onlyNumber(sender, e, textBoxDoctorLogiId);
        }

        private void DoctorLoginGUI_Load(object sender, EventArgs e)
        {

        }
    }
}

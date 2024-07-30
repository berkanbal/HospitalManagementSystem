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
    public partial class AdminLoginGUI : Form
    {
        Panel panel;

        Helper.Helper helper;
        LoginGUI loginGUI;

        MainLoginButtons mainLoginButtons;
        public AdminLoginGUI(Panel _panel, LoginGUI _loginGUI)
        {
            InitializeComponent();
            this.panel = _panel;
            this.loginGUI = _loginGUI;
        }

        private void rjBtnAdminBackMain_Click(object sender, EventArgs e)
        {
            //MainLoginButtons Formuna don ve paneli ilet
            Helper.Helper helper = new Helper.Helper(panel);
            mainLoginButtons = new MainLoginButtons(panel, loginGUI);
            helper.formGoster(mainLoginButtons, mainLoginButtons.Name);
        }

        private void rjBtnAdminSignIn_Click(object sender, EventArgs e)
        {
            bool tb_id = Helper.TextBoxValidation.IsTextBoxEmpty(textBoxAdminLogiId);
            bool tb_password = Helper.TextBoxValidation.IsTextBoxEmpty(textboxAdminPassword);

            if (tb_id && tb_password)
            {
                Helper.PasswordHasher hasher = new Helper.PasswordHasher();

                string adminID = textBoxAdminLogiId.Text;
                string adminPassword = textboxAdminPassword.Text;

                bool passwordControl;
                using (var context = new HospitalDbContext())
                {
                    var user = context.AdminIDValidation(adminID);
                    if (user != null)
                    {
                        passwordControl = hasher.VerifyPassword(adminPassword, user.password);
                        if (passwordControl)
                        {
                            AdminALF adminALF = new AdminALF(user.identification,user.name, user.surname);
                            adminALF.Show();
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

        private void textBoxAdminLogiId_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.TextBoxValidation.onlyNumber(sender, e, textBoxAdminLogiId);
        }
    }
}

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
    public partial class SecretaryLoginGUI : Form
    {
        Panel panel;
        LoginGUI loginGUI;
        MainLoginButtons mainLoginButtons;
        public SecretaryLoginGUI(Panel _panel)
        {
            InitializeComponent();
            this.panel = _panel;
        }
        public SecretaryLoginGUI(Panel _panel, LoginGUI _loginGUI)
        {
            InitializeComponent();
            this.panel = _panel;
            this.loginGUI = _loginGUI;
        }
        private void rjBtnSecretaryBackMain_Click(object sender, EventArgs e)
        {
            // MainLoginButtons Formuna don ve paneli ilet
            Helper.Helper helper = new Helper.Helper(panel);
            mainLoginButtons = new MainLoginButtons(panel, loginGUI);
            helper.formGoster(mainLoginButtons, mainLoginButtons.Name);
        }

        private void rjBtnSecretarySignIn_Click(object sender, EventArgs e)
        {
            bool tb_id = Helper.TextBoxValidation.IsTextBoxEmpty(textBoxSecretaryLoginId);
            bool tb_password = Helper.TextBoxValidation.IsTextBoxEmpty(textboxSecretaryPasswordId);

            if (tb_id && tb_password)
            {
                Helper.PasswordHasher hasher = new Helper.PasswordHasher();

                string secretaryID = textBoxSecretaryLoginId.Text;
                string secretaryPassword = textboxSecretaryPasswordId.Text;

                bool passwordControl;
                using (var context = new HospitalDbContext())
                {
                    var user = context.SecretaryIDValidation(secretaryID);
                    if (user != null)
                    {
                        passwordControl = hasher.VerifyPassword(secretaryPassword, user.password);
                        if (passwordControl)
                        {
                            SecretaryALF secretaryALF = new SecretaryALF(user);
                            secretaryALF.Show();
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

        private void textBoxSecretaryLoginId_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.TextBoxValidation.onlyNumber(sender, e, textBoxSecretaryLoginId);
        }
    }
}

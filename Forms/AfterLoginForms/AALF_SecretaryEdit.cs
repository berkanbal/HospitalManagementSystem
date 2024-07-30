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

namespace HospitalManagementSystem.Forms.AfterLoginForms
{
    public partial class AALF_SecretaryEdit : Form
    {
        HospitalDbContext context;
        public string secretaryDB_ID { get; set; }
        public AALF_SecretaryEdit()
        {
            InitializeComponent();
            context = new HospitalDbContext();
        }

        private void buttonAALF_SecretarySave_Click(object sender, EventArgs e)
        {
            bool[] signUpControlArray = new bool[5];

            signUpControlArray[0] = Helper.TextBoxValidation.IsTextBoxEmpty(textboxAALF_SecretaryName);
            signUpControlArray[1] = Helper.TextBoxValidation.IsTextBoxEmpty(textboxAALF_SecretarySurname);
            signUpControlArray[2] = Helper.TextBoxValidation.IsTextBoxEmpty(textboxAALF_SecretaryId);
            signUpControlArray[3] = Helper.TextBoxValidation.IsTextBoxEmpty(textboxAALF_SecretaryPhone);
            signUpControlArray[4] = Helper.TextBoxValidation.IsTextBoxEmpty(textboxAALF_SecretaryPassword);

            bool result = true;

            foreach (bool value in signUpControlArray)
            {
                result = result && value;
            }

            if (result)
            {
                if (!(textboxAALF_SecretaryId.Text.Length < 11))
                {
                    Helper.PasswordHasher hasher = new Helper.PasswordHasher();
                    string hashedPassword = hasher.HashPassword(textboxAALF_SecretaryPassword.Text);

                    using (HospitalDbContext context = new HospitalDbContext())
                    {
                        Secretary newSecretary = new Secretary
                        {
                            name = textboxAALF_SecretaryName.Text,
                            surname = textboxAALF_SecretarySurname.Text,
                            identification = textboxAALF_SecretaryId.Text,
                            GSM_No = textboxAALF_SecretaryPhone.Text,
                            password = hashedPassword
                        };
                        context.Secretaries.Add(newSecretary);
                        context.SaveChanges();
                        MessageBox.Show("Database Registration successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Helper.Helper helper = new Helper.Helper();
                        helper.loadDataSecretaries(dataGridViewAALF_Secretary, context);
                    }
                }
                else
                {
                    MessageBox.Show("Identification number must be 11 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("All fields are required for registration.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textboxAALF_SecretaryId_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.TextBoxValidation.onlyNumber(sender, e, textboxAALF_SecretaryId);
        }

        private void textboxAALF_SecretaryPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.TextBoxValidation.onlyNumber(sender, e, textboxAALF_SecretaryPhone);
        }

        private void AALF_SecretaryEdit_Load(object sender, EventArgs e)
        {
            Helper.Helper helper = new Helper.Helper();
            helper.loadDataSecretaries(dataGridViewAALF_Secretary, context);

            dataGridViewAALF_Secretary.Columns["password"].ReadOnly = true;
        }

        private void dataGridViewAALF_Secretary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;
            if (selectedRowIndex >= 0 && selectedRowIndex < dataGridViewAALF_Secretary.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridViewAALF_Secretary.Rows[selectedRowIndex];

                string columnName = selectedRow.Cells["name"].Value.ToString();
                string columnSurname = selectedRow.Cells["surname"].Value.ToString();
                string columnID = selectedRow.Cells["identification"].Value.ToString();
                string columnPhone = selectedRow.Cells["GSM_No"].Value.ToString();
                string columnPassword = selectedRow.Cells["password"].Value.ToString();

                this.secretaryDB_ID = selectedRow.Cells["SecretaryId"].Value.ToString();

                textBoxAALF_SecretaryNameUp.Text = columnName;
                textBoxAALF_SecretarySurnameUp.Text = columnSurname;
                textBoxAALF_SecretaryIDUp.Text = columnID;
                textBoxAALF_SecretaryPhoneUp.Text = columnPhone;
                //textboxAALF_SecretaryPassword.Text = columnPassword;

                //textboxAALF_SecretaryPassword.ReadOnly = true;
            }
        }

        private void buttonAALF_SecretaryDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.secretaryDB_ID))
            {
                using (var context = new HospitalDbContext())
                {
                    context.deleteSecretaryByID(Convert.ToInt32(this.secretaryDB_ID));
                }
                Helper.Helper helper = new Helper.Helper();
                helper.loadDataSecretaries(dataGridViewAALF_Secretary, context);
            }
            else
            {

            }

        }

        private void buttonAALF_SecretaryUpdate_Click(object sender, EventArgs e)
        {
            using (var context = new HospitalDbContext())
            {
                context.updateSecretaryByID(Convert.ToInt32(this.secretaryDB_ID),
                    textBoxAALF_SecretaryNameUp.Text,
                    textBoxAALF_SecretarySurnameUp.Text,
                    textBoxAALF_SecretaryIDUp.Text,
                    textBoxAALF_SecretaryPhoneUp.Text
                    );
                context.SaveChanges();
                Helper.Helper helper = new Helper.Helper();
                helper.loadDataSecretaries(dataGridViewAALF_Secretary, context);
            }

        }

        private void dataGridViewAALF_Secretary_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewAALF_Secretary.Columns[e.ColumnIndex].Name == "password" && e.Value != null)
            {
                // Hücre değerini sansürle
                e.Value = new string('*', 5);
                e.FormattingApplied = true;
            }
        }

        private void dataGridViewAALF_Secretary_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var secretaryID = (int)dataGridViewAALF_Secretary.Rows[e.RowIndex].Cells["SecretaryId"].Value;
            var updateValue = dataGridViewAALF_Secretary.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
            var columnName = dataGridViewAALF_Secretary.Columns[e.ColumnIndex].Name;

            var context = new HospitalDbContext();
            var secretary = context.Secretaries.FirstOrDefault(p => p.SecretaryId == secretaryID);

            if (secretary != null)
            {
                switch (columnName)
                {
                    case "name":
                        secretary.name = updateValue;
                        break;
                    case "surname":
                        secretary.surname = updateValue;
                        break;
                    case "identification":
                        secretary.identification = updateValue;
                        break;
                    case "GSM_No":
                        secretary.GSM_No = updateValue;
                        break;
                }
                context.SaveChanges();

            }
        }

        private void rjButtonAALF_SecretaryClear_Click(object sender, EventArgs e)
        {
            textboxAALF_SecretaryId.Clear();
            textboxAALF_SecretaryName.Clear();
            textboxAALF_SecretarySurname.Clear();
            textboxAALF_SecretaryPhone.Clear();
            textboxAALF_SecretaryPassword.Clear();
        }

        private void rjButtonAALF_SecretaryClearUp_Click(object sender, EventArgs e)
        {
            textBoxAALF_SecretaryIDUp.Clear();
            textBoxAALF_SecretaryNameUp.Clear();
            textBoxAALF_SecretarySurnameUp.Clear();
            textBoxAALF_SecretaryPhoneUp.Clear();
        }

        private void textBoxAALF_SecretaryIDUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.TextBoxValidation.onlyNumber(sender, e, textBoxAALF_SecretaryIDUp);
        }

        private void textBoxAALF_SecretaryPhoneUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.TextBoxValidation.onlyNumber(sender, e, textBoxAALF_SecretaryPhoneUp);
        }
    }
}

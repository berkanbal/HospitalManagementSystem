namespace HospitalManagementSystem.Forms.AfterLoginForms
{
    partial class AALF_SecretaryEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelAALF_Secret = new Label();
            dataGridViewAALF_Secretary = new DataGridView();
            tabControlAALF_Secretary = new TabControl();
            tabPageAALF_SecretaryEdit = new TabPage();
            rjButtonAALF_SecretaryClear = new CustomTools.RJButton.RJButton();
            textboxAALF_SecretaryPassword = new TextBox();
            textboxAALF_SecretaryPhone = new TextBox();
            textboxAALF_SecretarySurname = new TextBox();
            textboxAALF_SecretaryName = new TextBox();
            textboxAALF_SecretaryId = new TextBox();
            buttonAALF_SecretarySave = new CustomTools.RJButton.RJButton();
            buttonAALF_SecretaryDelete = new CustomTools.RJButton.RJButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tabPageAALF_SecretaryUpdate = new TabPage();
            rjButtonAALF_SecretaryClearUp = new CustomTools.RJButton.RJButton();
            textBoxAALF_SecretaryPhoneUp = new TextBox();
            textBoxAALF_SecretarySurnameUp = new TextBox();
            textBoxAALF_SecretaryNameUp = new TextBox();
            textBoxAALF_SecretaryIDUp = new TextBox();
            buttonAALF_DoctorUpdate = new CustomTools.RJButton.RJButton();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAALF_Secretary).BeginInit();
            tabControlAALF_Secretary.SuspendLayout();
            tabPageAALF_SecretaryEdit.SuspendLayout();
            tabPageAALF_SecretaryUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // labelAALF_Secret
            // 
            labelAALF_Secret.AutoSize = true;
            labelAALF_Secret.Font = new Font("Yu Gothic UI Semibold", 13F);
            labelAALF_Secret.Location = new Point(31, 32);
            labelAALF_Secret.Name = "labelAALF_Secret";
            labelAALF_Secret.Size = new Size(105, 30);
            labelAALF_Secret.TabIndex = 32;
            labelAALF_Secret.Text = "Secretary";
            // 
            // dataGridViewAALF_Secretary
            // 
            dataGridViewAALF_Secretary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAALF_Secretary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAALF_Secretary.Location = new Point(487, 94);
            dataGridViewAALF_Secretary.Name = "dataGridViewAALF_Secretary";
            dataGridViewAALF_Secretary.RowHeadersWidth = 51;
            dataGridViewAALF_Secretary.Size = new Size(935, 417);
            dataGridViewAALF_Secretary.TabIndex = 56;
            dataGridViewAALF_Secretary.CellClick += dataGridViewAALF_Secretary_CellClick;
            dataGridViewAALF_Secretary.CellEndEdit += dataGridViewAALF_Secretary_CellEndEdit;
            dataGridViewAALF_Secretary.CellFormatting += dataGridViewAALF_Secretary_CellFormatting;
            // 
            // tabControlAALF_Secretary
            // 
            tabControlAALF_Secretary.Controls.Add(tabPageAALF_SecretaryEdit);
            tabControlAALF_Secretary.Controls.Add(tabPageAALF_SecretaryUpdate);
            tabControlAALF_Secretary.Location = new Point(31, 65);
            tabControlAALF_Secretary.Name = "tabControlAALF_Secretary";
            tabControlAALF_Secretary.SelectedIndex = 0;
            tabControlAALF_Secretary.Size = new Size(450, 446);
            tabControlAALF_Secretary.TabIndex = 82;
            // 
            // tabPageAALF_SecretaryEdit
            // 
            tabPageAALF_SecretaryEdit.Controls.Add(rjButtonAALF_SecretaryClear);
            tabPageAALF_SecretaryEdit.Controls.Add(textboxAALF_SecretaryPassword);
            tabPageAALF_SecretaryEdit.Controls.Add(textboxAALF_SecretaryPhone);
            tabPageAALF_SecretaryEdit.Controls.Add(textboxAALF_SecretarySurname);
            tabPageAALF_SecretaryEdit.Controls.Add(textboxAALF_SecretaryName);
            tabPageAALF_SecretaryEdit.Controls.Add(textboxAALF_SecretaryId);
            tabPageAALF_SecretaryEdit.Controls.Add(buttonAALF_SecretarySave);
            tabPageAALF_SecretaryEdit.Controls.Add(buttonAALF_SecretaryDelete);
            tabPageAALF_SecretaryEdit.Controls.Add(label1);
            tabPageAALF_SecretaryEdit.Controls.Add(label2);
            tabPageAALF_SecretaryEdit.Controls.Add(label3);
            tabPageAALF_SecretaryEdit.Controls.Add(label4);
            tabPageAALF_SecretaryEdit.Controls.Add(label5);
            tabPageAALF_SecretaryEdit.Location = new Point(4, 29);
            tabPageAALF_SecretaryEdit.Name = "tabPageAALF_SecretaryEdit";
            tabPageAALF_SecretaryEdit.Padding = new Padding(3);
            tabPageAALF_SecretaryEdit.Size = new Size(442, 413);
            tabPageAALF_SecretaryEdit.TabIndex = 0;
            tabPageAALF_SecretaryEdit.Text = "Secretary Edit";
            tabPageAALF_SecretaryEdit.UseVisualStyleBackColor = true;
            // 
            // rjButtonAALF_SecretaryClear
            // 
            rjButtonAALF_SecretaryClear.BackColor = Color.RosyBrown;
            rjButtonAALF_SecretaryClear.BackgroundColor = Color.RosyBrown;
            rjButtonAALF_SecretaryClear.BorderColor = Color.Salmon;
            rjButtonAALF_SecretaryClear.BorderRadius = 15;
            rjButtonAALF_SecretaryClear.BorderSize = 0;
            rjButtonAALF_SecretaryClear.FlatAppearance.BorderSize = 0;
            rjButtonAALF_SecretaryClear.FlatStyle = FlatStyle.Flat;
            rjButtonAALF_SecretaryClear.Font = new Font("Yu Gothic UI Semibold", 10F);
            rjButtonAALF_SecretaryClear.ForeColor = Color.White;
            rjButtonAALF_SecretaryClear.Location = new Point(9, 261);
            rjButtonAALF_SecretaryClear.Margin = new Padding(3, 4, 3, 4);
            rjButtonAALF_SecretaryClear.Name = "rjButtonAALF_SecretaryClear";
            rjButtonAALF_SecretaryClear.Size = new Size(153, 36);
            rjButtonAALF_SecretaryClear.TabIndex = 95;
            rjButtonAALF_SecretaryClear.Text = "Clear";
            rjButtonAALF_SecretaryClear.TextColor = Color.White;
            rjButtonAALF_SecretaryClear.UseVisualStyleBackColor = false;
            rjButtonAALF_SecretaryClear.Click += rjButtonAALF_SecretaryClear_Click;
            // 
            // textboxAALF_SecretaryPassword
            // 
            textboxAALF_SecretaryPassword.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textboxAALF_SecretaryPassword.Location = new Point(169, 207);
            textboxAALF_SecretaryPassword.Margin = new Padding(3, 4, 3, 4);
            textboxAALF_SecretaryPassword.Name = "textboxAALF_SecretaryPassword";
            textboxAALF_SecretaryPassword.PlaceholderText = "Password";
            textboxAALF_SecretaryPassword.Size = new Size(260, 29);
            textboxAALF_SecretaryPassword.TabIndex = 94;
            // 
            // textboxAALF_SecretaryPhone
            // 
            textboxAALF_SecretaryPhone.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textboxAALF_SecretaryPhone.Location = new Point(168, 158);
            textboxAALF_SecretaryPhone.Margin = new Padding(3, 4, 3, 4);
            textboxAALF_SecretaryPhone.Name = "textboxAALF_SecretaryPhone";
            textboxAALF_SecretaryPhone.PlaceholderText = "Phone Number";
            textboxAALF_SecretaryPhone.Size = new Size(260, 29);
            textboxAALF_SecretaryPhone.TabIndex = 93;
            textboxAALF_SecretaryPhone.KeyPress += textboxAALF_SecretaryPhone_KeyPress;
            // 
            // textboxAALF_SecretarySurname
            // 
            textboxAALF_SecretarySurname.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textboxAALF_SecretarySurname.Location = new Point(168, 55);
            textboxAALF_SecretarySurname.Margin = new Padding(3, 4, 3, 4);
            textboxAALF_SecretarySurname.Name = "textboxAALF_SecretarySurname";
            textboxAALF_SecretarySurname.PlaceholderText = "Surname";
            textboxAALF_SecretarySurname.Size = new Size(260, 29);
            textboxAALF_SecretarySurname.TabIndex = 92;
            // 
            // textboxAALF_SecretaryName
            // 
            textboxAALF_SecretaryName.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textboxAALF_SecretaryName.Location = new Point(168, 10);
            textboxAALF_SecretaryName.Margin = new Padding(3, 4, 3, 4);
            textboxAALF_SecretaryName.Name = "textboxAALF_SecretaryName";
            textboxAALF_SecretaryName.PlaceholderText = "Name";
            textboxAALF_SecretaryName.Size = new Size(260, 29);
            textboxAALF_SecretaryName.TabIndex = 91;
            // 
            // textboxAALF_SecretaryId
            // 
            textboxAALF_SecretaryId.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textboxAALF_SecretaryId.Location = new Point(169, 108);
            textboxAALF_SecretaryId.Margin = new Padding(3, 4, 3, 4);
            textboxAALF_SecretaryId.Name = "textboxAALF_SecretaryId";
            textboxAALF_SecretaryId.PlaceholderText = "ID";
            textboxAALF_SecretaryId.Size = new Size(260, 29);
            textboxAALF_SecretaryId.TabIndex = 90;
            textboxAALF_SecretaryId.KeyPress += textboxAALF_SecretaryId_KeyPress;
            // 
            // buttonAALF_SecretarySave
            // 
            buttonAALF_SecretarySave.BackColor = Color.Salmon;
            buttonAALF_SecretarySave.BackgroundColor = Color.Salmon;
            buttonAALF_SecretarySave.BorderColor = Color.Salmon;
            buttonAALF_SecretarySave.BorderRadius = 15;
            buttonAALF_SecretarySave.BorderSize = 0;
            buttonAALF_SecretarySave.FlatAppearance.BorderSize = 0;
            buttonAALF_SecretarySave.FlatStyle = FlatStyle.Flat;
            buttonAALF_SecretarySave.Font = new Font("Yu Gothic UI Semibold", 10F);
            buttonAALF_SecretarySave.ForeColor = Color.White;
            buttonAALF_SecretarySave.Location = new Point(168, 258);
            buttonAALF_SecretarySave.Margin = new Padding(3, 4, 3, 4);
            buttonAALF_SecretarySave.Name = "buttonAALF_SecretarySave";
            buttonAALF_SecretarySave.Size = new Size(260, 43);
            buttonAALF_SecretarySave.TabIndex = 89;
            buttonAALF_SecretarySave.Text = "Save";
            buttonAALF_SecretarySave.TextColor = Color.White;
            buttonAALF_SecretarySave.UseVisualStyleBackColor = false;
            buttonAALF_SecretarySave.Click += buttonAALF_SecretarySave_Click;
            // 
            // buttonAALF_SecretaryDelete
            // 
            buttonAALF_SecretaryDelete.BackColor = Color.Red;
            buttonAALF_SecretaryDelete.BackgroundColor = Color.Red;
            buttonAALF_SecretaryDelete.BorderColor = Color.Salmon;
            buttonAALF_SecretaryDelete.BorderRadius = 15;
            buttonAALF_SecretaryDelete.BorderSize = 0;
            buttonAALF_SecretaryDelete.FlatAppearance.BorderSize = 0;
            buttonAALF_SecretaryDelete.FlatStyle = FlatStyle.Flat;
            buttonAALF_SecretaryDelete.Font = new Font("Yu Gothic UI Semibold", 10F);
            buttonAALF_SecretaryDelete.ForeColor = Color.White;
            buttonAALF_SecretaryDelete.Location = new Point(168, 306);
            buttonAALF_SecretaryDelete.Margin = new Padding(3, 4, 3, 4);
            buttonAALF_SecretaryDelete.Name = "buttonAALF_SecretaryDelete";
            buttonAALF_SecretaryDelete.Size = new Size(261, 36);
            buttonAALF_SecretaryDelete.TabIndex = 88;
            buttonAALF_SecretaryDelete.Text = "Delete";
            buttonAALF_SecretaryDelete.TextColor = Color.White;
            buttonAALF_SecretaryDelete.UseVisualStyleBackColor = false;
            buttonAALF_SecretaryDelete.Click += buttonAALF_SecretaryDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 11F);
            label1.Location = new Point(4, 158);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 85;
            label1.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 11F);
            label2.Location = new Point(6, 108);
            label2.Name = "label2";
            label2.Size = new Size(157, 25);
            label2.TabIndex = 84;
            label2.Text = "Identification No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 11F);
            label3.Location = new Point(6, 10);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 83;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI Semibold", 11F);
            label4.Location = new Point(6, 208);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 82;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI Semibold", 11F);
            label5.Location = new Point(6, 56);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 81;
            label5.Text = "Surname";
            // 
            // tabPageAALF_SecretaryUpdate
            // 
            tabPageAALF_SecretaryUpdate.Controls.Add(rjButtonAALF_SecretaryClearUp);
            tabPageAALF_SecretaryUpdate.Controls.Add(textBoxAALF_SecretaryPhoneUp);
            tabPageAALF_SecretaryUpdate.Controls.Add(textBoxAALF_SecretarySurnameUp);
            tabPageAALF_SecretaryUpdate.Controls.Add(textBoxAALF_SecretaryNameUp);
            tabPageAALF_SecretaryUpdate.Controls.Add(textBoxAALF_SecretaryIDUp);
            tabPageAALF_SecretaryUpdate.Controls.Add(buttonAALF_DoctorUpdate);
            tabPageAALF_SecretaryUpdate.Controls.Add(label7);
            tabPageAALF_SecretaryUpdate.Controls.Add(label8);
            tabPageAALF_SecretaryUpdate.Controls.Add(label9);
            tabPageAALF_SecretaryUpdate.Controls.Add(label10);
            tabPageAALF_SecretaryUpdate.Location = new Point(4, 29);
            tabPageAALF_SecretaryUpdate.Name = "tabPageAALF_SecretaryUpdate";
            tabPageAALF_SecretaryUpdate.Padding = new Padding(3);
            tabPageAALF_SecretaryUpdate.Size = new Size(442, 413);
            tabPageAALF_SecretaryUpdate.TabIndex = 1;
            tabPageAALF_SecretaryUpdate.Text = "Secretary Update";
            tabPageAALF_SecretaryUpdate.UseVisualStyleBackColor = true;
            // 
            // rjButtonAALF_SecretaryClearUp
            // 
            rjButtonAALF_SecretaryClearUp.BackColor = Color.RosyBrown;
            rjButtonAALF_SecretaryClearUp.BackgroundColor = Color.RosyBrown;
            rjButtonAALF_SecretaryClearUp.BorderColor = Color.Salmon;
            rjButtonAALF_SecretaryClearUp.BorderRadius = 15;
            rjButtonAALF_SecretaryClearUp.BorderSize = 0;
            rjButtonAALF_SecretaryClearUp.FlatAppearance.BorderSize = 0;
            rjButtonAALF_SecretaryClearUp.FlatStyle = FlatStyle.Flat;
            rjButtonAALF_SecretaryClearUp.Font = new Font("Yu Gothic UI Semibold", 10F);
            rjButtonAALF_SecretaryClearUp.ForeColor = Color.White;
            rjButtonAALF_SecretaryClearUp.Location = new Point(10, 214);
            rjButtonAALF_SecretaryClearUp.Margin = new Padding(3, 4, 3, 4);
            rjButtonAALF_SecretaryClearUp.Name = "rjButtonAALF_SecretaryClearUp";
            rjButtonAALF_SecretaryClearUp.Size = new Size(153, 36);
            rjButtonAALF_SecretaryClearUp.TabIndex = 109;
            rjButtonAALF_SecretaryClearUp.Text = "Clear";
            rjButtonAALF_SecretaryClearUp.TextColor = Color.White;
            rjButtonAALF_SecretaryClearUp.UseVisualStyleBackColor = false;
            rjButtonAALF_SecretaryClearUp.Click += rjButtonAALF_SecretaryClearUp_Click;
            // 
            // textBoxAALF_SecretaryPhoneUp
            // 
            textBoxAALF_SecretaryPhoneUp.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textBoxAALF_SecretaryPhoneUp.Location = new Point(168, 158);
            textBoxAALF_SecretaryPhoneUp.Margin = new Padding(3, 4, 3, 4);
            textBoxAALF_SecretaryPhoneUp.Name = "textBoxAALF_SecretaryPhoneUp";
            textBoxAALF_SecretaryPhoneUp.PlaceholderText = "Phone Number";
            textBoxAALF_SecretaryPhoneUp.Size = new Size(260, 29);
            textBoxAALF_SecretaryPhoneUp.TabIndex = 108;
            textBoxAALF_SecretaryPhoneUp.KeyPress += textBoxAALF_SecretaryPhoneUp_KeyPress;
            // 
            // textBoxAALF_SecretarySurnameUp
            // 
            textBoxAALF_SecretarySurnameUp.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textBoxAALF_SecretarySurnameUp.Location = new Point(168, 55);
            textBoxAALF_SecretarySurnameUp.Margin = new Padding(3, 4, 3, 4);
            textBoxAALF_SecretarySurnameUp.Name = "textBoxAALF_SecretarySurnameUp";
            textBoxAALF_SecretarySurnameUp.PlaceholderText = "Surname";
            textBoxAALF_SecretarySurnameUp.Size = new Size(260, 29);
            textBoxAALF_SecretarySurnameUp.TabIndex = 107;
            // 
            // textBoxAALF_SecretaryNameUp
            // 
            textBoxAALF_SecretaryNameUp.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textBoxAALF_SecretaryNameUp.Location = new Point(168, 10);
            textBoxAALF_SecretaryNameUp.Margin = new Padding(3, 4, 3, 4);
            textBoxAALF_SecretaryNameUp.Name = "textBoxAALF_SecretaryNameUp";
            textBoxAALF_SecretaryNameUp.PlaceholderText = "Name";
            textBoxAALF_SecretaryNameUp.Size = new Size(260, 29);
            textBoxAALF_SecretaryNameUp.TabIndex = 106;
            // 
            // textBoxAALF_SecretaryIDUp
            // 
            textBoxAALF_SecretaryIDUp.Font = new Font("Yu Gothic UI Semibold", 9.5F);
            textBoxAALF_SecretaryIDUp.Location = new Point(169, 108);
            textBoxAALF_SecretaryIDUp.Margin = new Padding(3, 4, 3, 4);
            textBoxAALF_SecretaryIDUp.Name = "textBoxAALF_SecretaryIDUp";
            textBoxAALF_SecretaryIDUp.PlaceholderText = "ID";
            textBoxAALF_SecretaryIDUp.Size = new Size(260, 29);
            textBoxAALF_SecretaryIDUp.TabIndex = 105;
            textBoxAALF_SecretaryIDUp.KeyPress += textBoxAALF_SecretaryIDUp_KeyPress;
            // 
            // buttonAALF_DoctorUpdate
            // 
            buttonAALF_DoctorUpdate.BackColor = Color.SkyBlue;
            buttonAALF_DoctorUpdate.BackgroundColor = Color.SkyBlue;
            buttonAALF_DoctorUpdate.BorderColor = Color.Salmon;
            buttonAALF_DoctorUpdate.BorderRadius = 15;
            buttonAALF_DoctorUpdate.BorderSize = 0;
            buttonAALF_DoctorUpdate.FlatAppearance.BorderSize = 0;
            buttonAALF_DoctorUpdate.FlatStyle = FlatStyle.Flat;
            buttonAALF_DoctorUpdate.Font = new Font("Yu Gothic UI Semibold", 10F);
            buttonAALF_DoctorUpdate.ForeColor = Color.White;
            buttonAALF_DoctorUpdate.Location = new Point(169, 211);
            buttonAALF_DoctorUpdate.Margin = new Padding(3, 4, 3, 4);
            buttonAALF_DoctorUpdate.Name = "buttonAALF_DoctorUpdate";
            buttonAALF_DoctorUpdate.Size = new Size(259, 43);
            buttonAALF_DoctorUpdate.TabIndex = 102;
            buttonAALF_DoctorUpdate.Text = "Update";
            buttonAALF_DoctorUpdate.TextColor = Color.White;
            buttonAALF_DoctorUpdate.UseVisualStyleBackColor = false;
            buttonAALF_DoctorUpdate.Click += buttonAALF_SecretaryUpdate_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI Semibold", 11F);
            label7.Location = new Point(4, 158);
            label7.Name = "label7";
            label7.Size = new Size(66, 25);
            label7.TabIndex = 100;
            label7.Text = "Phone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic UI Semibold", 11F);
            label8.Location = new Point(6, 108);
            label8.Name = "label8";
            label8.Size = new Size(157, 25);
            label8.TabIndex = 99;
            label8.Text = "Identification No";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic UI Semibold", 11F);
            label9.Location = new Point(6, 10);
            label9.Name = "label9";
            label9.Size = new Size(64, 25);
            label9.TabIndex = 98;
            label9.Text = "Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Yu Gothic UI Semibold", 11F);
            label10.Location = new Point(6, 56);
            label10.Name = "label10";
            label10.Size = new Size(88, 25);
            label10.TabIndex = 96;
            label10.Text = "Surname";
            // 
            // AALF_SecretaryEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1448, 553);
            Controls.Add(tabControlAALF_Secretary);
            Controls.Add(dataGridViewAALF_Secretary);
            Controls.Add(labelAALF_Secret);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AALF_SecretaryEdit";
            Text = "AALF_SecretaryEdit";
            Load += AALF_SecretaryEdit_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAALF_Secretary).EndInit();
            tabControlAALF_Secretary.ResumeLayout(false);
            tabPageAALF_SecretaryEdit.ResumeLayout(false);
            tabPageAALF_SecretaryEdit.PerformLayout();
            tabPageAALF_SecretaryUpdate.ResumeLayout(false);
            tabPageAALF_SecretaryUpdate.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAALF_Secret;
        private DataGridView dataGridViewAALF_Secretary;
        private TabControl tabControlAALF_Secretary;
        private TabPage tabPageAALF_SecretaryEdit;
        private TextBox textboxAALF_SecretaryPassword;
        private TextBox textboxAALF_SecretaryPhone;
        private TextBox textboxAALF_SecretarySurname;
        private TextBox textboxAALF_SecretaryName;
        private TextBox textboxAALF_SecretaryId;
        private CustomTools.RJButton.RJButton buttonAALF_SecretarySave;
        private CustomTools.RJButton.RJButton buttonAALF_SecretaryDelete;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TabPage tabPageAALF_SecretaryUpdate;
        private TextBox textBoxAALF_SecretaryPhoneUp;
        private TextBox textBoxAALF_SecretarySurnameUp;
        private TextBox textBoxAALF_SecretaryNameUp;
        private TextBox textBoxAALF_SecretaryIDUp;
        private CustomTools.RJButton.RJButton buttonAALF_DoctorUpdate;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private CustomTools.RJButton.RJButton rjButtonAALF_SecretaryClear;
        private CustomTools.RJButton.RJButton rjButtonAALF_SecretaryClearUp;
    }
}
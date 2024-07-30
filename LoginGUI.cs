using HospitalManagementSystem;
using HospitalManagementSystem.Database;
using HospitalManagementSystem.Forms;
using HospitalManagementSystem.Forms.AfterLoginForms;
using HospitalManagementSystem.Forms.LoginForms;
using HospitalManagementSystem.Helper;

namespace HospitalManagementSystem
{
    public partial class LoginGUI : Form
    {
        Helper.Helper helper;
        public LoginGUI()
        {
            InitializeComponent();          
        }
        private void LoginGUI_Load(object sender, EventArgs e)
        {
            // Panelde Default MainLoginButtons ac
            helper = new Helper.Helper(panelFormController);
            MainLoginButtons mainLoginButtons = new MainLoginButtons(panelFormController, this);
            helper.formGoster(mainLoginButtons, mainLoginButtons.Name);
            
        }
    }
}

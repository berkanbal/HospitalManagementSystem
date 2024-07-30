using HospitalManagementSystem.Database;
using Microsoft.Data.SqlClient;
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
    public partial class SALF_Appointments : Form
    {
        HospitalDbContext context;
        public SALF_Appointments()
        {
            InitializeComponent();
            context = new HospitalDbContext();
        }

        private void SALF_Appointments_Load(object sender, EventArgs e)
        {
            Helper.Helper helper = new Helper.Helper();
            helper.loadDataDoctorsReviews(DataGridSALF_Appointments, context);
        }
    }
}

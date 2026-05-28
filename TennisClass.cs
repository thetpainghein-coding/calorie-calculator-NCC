using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ddocpTPH
{
    public partial class ProfileForm : Form
    {
        float totalcurCal;
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            
            int id = GlobalData._UserId;

            //to show all the data of all activities in datagridview
            DBClass db = new DBClass();
            dgvHistory.DataSource =  db.getHistory(id);
            dgvHistory.DataMember = "HistoryTable";

            lblName.Text = "Name: "+ GlobalData._Username;

            lblEmail.Text = "Email: "+ GlobalData._Email;

            lblTargetCalorie.Text = "Target Calorie: " + GlobalData._TargetCalorie;
            
            ActivityClass act = new ActivityClass();
            totalcurCal = (float)act.CurrentTotalCalories(id);
            lblTotalCurCal.Text = "Total Calorie Burnt: " + totalcurCal.ToString();
            

        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

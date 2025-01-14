using FinancialCrm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinancialCrm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void btnUserLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password=txtUserPassword.Text;

            var user = db.Users.Where(x=>x.UserName== username && x.Password== password).FirstOrDefault();

            if (user != null)
            {
                //MessageBox.Show("Giriş Yaptınız.");
                FrmDashboard frmDashboard = new FrmDashboard();
                frmDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız.");
            }
        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            FrmUsers frmUsers = new FrmUsers();
            frmUsers.Show();
            this.Hide();
        }
    }
}

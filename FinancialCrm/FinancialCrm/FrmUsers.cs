using FinancialCrm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmUsers : Form
    {
        public FrmUsers()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtUserPassword.Text;

            Users users = new Users();
            users.UserName = username;
            users.Password = password;
            db.Users.Add(users);
            db.SaveChanges();
            MessageBox.Show("Başarılı Bir Şekilde Sisteme Kayıt Oldunuz.", "Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }


    }
}

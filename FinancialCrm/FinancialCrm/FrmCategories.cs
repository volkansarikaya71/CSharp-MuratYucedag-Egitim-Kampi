using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Model;

namespace FinancialCrm
{
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            var values = db.TblCategories
            .Select(x => new
            {
                x.CategoryId,
                x.CategoryName
            }).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCategoryList_Click(object sender, EventArgs e)
        {
            var values = db.TblCategories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var removeValue = db.TblCategories.Find(id);
            db.TblCategories.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarılı Bir Şekilde Sisteme Silindi.", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.TblCategories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text;

            TblCategories categories = new TblCategories();
            categories.CategoryName = categoryName;
            db.TblCategories.Add(categories);
            db.SaveChanges();
            MessageBox.Show("Kategoriniz Başarılı Bir Şekilde Sisteme Eklendi.", "Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.TblCategories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text;
            int id = int.Parse(txtCategoryId.Text);

            var updateValue = db.TblCategories.Find(id);

            updateValue.CategoryName = categoryName;

            db.SaveChanges();
            MessageBox.Show("Kategori Başarılı Bir Şekilde Sisteme Güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.TblCategories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCategoryForm_Click(object sender, EventArgs e)
        {

        }

        private void btnSettingForm_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.ShowDialog();
            this.Hide();
        }

        private void btnBankTransactionsForm_Click(object sender, EventArgs e)
        {
            FrmBankTransactions frmBankTransactions = new FrmBankTransactions();
            frmBankTransactions.Show();
            this.Hide();
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.ShowDialog();
            this.Hide();
        }

        private void btnBillingForm_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.ShowDialog();
            this.Hide();
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.ShowDialog();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

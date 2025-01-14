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
using FinancialCrm.Model;
using System.Runtime.Remoting.Contexts;
namespace FinancialCrm
{
    public partial class FrmBankTransactions : Form
    {
        public FrmBankTransactions()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmBankTransactions_Load(object sender, EventArgs e)
        {
            #region Bütün Banka İşlemlerini Getir
            var values = db.BankProcesses
            .Select(x => new
            {
            x.BankProcessId,
            x.Description,
            x.ProcessDate,
            x.ProcessType,
            x.Amount,
            x.Banks.BankTitle
            }).ToList();
            dataGridView1.DataSource = values;
            #endregion

            #region Banka İsimlerini Getir
            var bankNameValues = db.Banks.ToList();
            cmbProcessBankId.DataSource = bankNameValues;
            cmbProcessBankId.DisplayMember = "BankTitle";
            cmbProcessBankId.ValueMember = "BankId";
            #endregion

        }

        private void btnProcessList_Click(object sender, EventArgs e)
        {
            var values = db.BankProcesses
            .Select(x => new
            {
                x.BankProcessId,
                x.Description,
                x.ProcessDate,
                x.ProcessType,
                x.Amount,
                x.Banks.BankTitle
            }).ToList();

            dataGridView1.DataSource = values;
        }

        private void btnRemoveProcess_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProcessId.Text);
            var removeValue = db.BankProcesses.Find(id);
            db.BankProcesses.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("İşleminiz Başarılı Bir Şekilde Sisteme Silindi.", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.BankProcesses
            .Select(x => new
            {
                x.BankProcessId,
                x.Description,
                x.ProcessDate,
                x.ProcessType,
                x.Amount,
                x.Banks.BankTitle
            }).ToList();

            dataGridView1.DataSource = values;
        }

        private void btnCreateProcess_Click(object sender, EventArgs e)
        {
            string processesDescription = txtProcessDescription.Text;
            DateTime processesDate=DateTime.Parse(txtProcessDate.Text);
            string processesType = txtProcessType.Text;
            decimal processesAmount = decimal.Parse(txtProcessAmount.Text);
            int processesBankId = int.Parse(cmbProcessBankId.SelectedValue.ToString());

            BankProcesses bankProcesses = new BankProcesses();
            bankProcesses.Description = processesDescription;
            bankProcesses.ProcessDate = processesDate;
            bankProcesses.ProcessType = processesType;
            bankProcesses.Amount = processesAmount;
            bankProcesses.BankId = processesBankId;
            db.BankProcesses.Add(bankProcesses);
            db.SaveChanges();
            MessageBox.Show("İşleminiz Başarılı Bir Şekilde Sisteme Eklendi.", "Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.BankProcesses
            .Select(x => new
            {
                x.BankProcessId,
                x.Description,
                x.ProcessDate,
                x.ProcessType,
                x.Amount,
                x.Banks.BankTitle
            }).ToList();

            dataGridView1.DataSource = values;
        }

        private void btnUpdateProcess_Click(object sender, EventArgs e)
        {
            string processesDescription = txtProcessDescription.Text;
            DateTime processesDate = DateTime.Parse(txtProcessDate.Text);
            string processesType = txtProcessType.Text;
            decimal processesAmount = decimal.Parse(txtProcessAmount.Text);
            int processesBankId = int.Parse(cmbProcessBankId.SelectedValue.ToString());
            int id = int.Parse(txtProcessId.Text);

            var updateValue = db.BankProcesses.Find(id);

            updateValue.Description = processesDescription;
            updateValue.ProcessDate = processesDate;
            updateValue.ProcessType = processesType;
            updateValue.Amount = processesAmount;
            updateValue.BankId = processesBankId;

            db.SaveChanges();
            MessageBox.Show("İşleminiz Başarılı Bir Şekilde Sisteme Güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.BankProcesses
            .Select(x => new
            {
                x.BankProcessId,
                x.Description,
                x.ProcessDate,
                x.ProcessType,
                x.Amount,
                x.Banks.BankTitle
            }).ToList();

            dataGridView1.DataSource = values;
        }

        private void btnCategoryForm_Click(object sender, EventArgs e)
        {
            FrmCategories frmCategories = new FrmCategories();
            frmCategories.Show();
            this.Hide();
        }

        private void btnSettingForm_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard(); 
            frmDashboard.Show();
            this.Hide();
        }

        private void btnBankTransactionsForm_Click(object sender, EventArgs e)
        {

        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
            this.Hide();
        }

        private void btnBillingForm_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
            this.Hide();
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

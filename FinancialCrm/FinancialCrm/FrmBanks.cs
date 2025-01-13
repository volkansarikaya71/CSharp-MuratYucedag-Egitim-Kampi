using FinancialCrm.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db=new FinancialCrmDbEntities();

        private void FrmBanks_Load(object sender, EventArgs e)
        {
            #region Banka Bakiyeleri
            var ziraatBankBalance =db.Banks.Where(x=>x.BankTitle == "Ziraat Bankası").Select(y=>y.BankBalance).FirstOrDefault();
            var vakifBankBalance = db.Banks.Where(x => x.BankTitle == "VakıfBank").Select(y => y.BankBalance).FirstOrDefault();
            var isBankBalance = db.Banks.Where(x => x.BankTitle == "İş Bankası").Select(y => y.BankBalance).FirstOrDefault();

            lblİsBankBalance.Text=isBankBalance.ToString()+ " ₺";
            lblVakıfBankBalance.Text= vakifBankBalance.ToString()+ " ₺";
            lblZiraatBankBalance.Text = ziraatBankBalance.ToString() + " ₺";
            #endregion

            #region Banka Hareketleri
            var bankProcess1=db.BankProcesses.OrderByDescending(x=>x.BankProcessId).Take(1).FirstOrDefault();
            lblBankProcess1.Text= bankProcess1.Description + " " +bankProcess1.Amount + " " + bankProcess1.ProcessDate?.ToString("dd/MM/yyyy");

            var bankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lblBankProcess2.Text = bankProcess2.Description + " " + bankProcess2.Amount + " " + bankProcess2.ProcessDate?.ToString("dd/MM/yyyy");

            var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblBankProcess3.Text = bankProcess3.Description + " " + bankProcess3.Amount + " " + bankProcess3.ProcessDate?.ToString("dd/MM/yyyy");

            var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            lblBankProcess4.Text = bankProcess4.Description + " " + bankProcess4.Amount + " " + bankProcess4.ProcessDate?.ToString("dd/MM/yyyy");

            var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lblBankProcess5.Text = bankProcess5.Description + " " + bankProcess5.Amount + " " + bankProcess5.ProcessDate?.ToString("dd/MM/yyyy");
            #endregion

        }


        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
            this.Hide();
        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBillingForm_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
            this.Hide();
        }

        private void btnCategoryForm_Click(object sender, EventArgs e)
        {
            FrmCategories frmCategories = new FrmCategories();
            frmCategories.Show();
            this.Hide();
        }

        private void btnBankTransactionsForm_Click(object sender, EventArgs e)
        {
            FrmBankTransactions frmBankTransactions = new FrmBankTransactions();
            frmBankTransactions.Show();
            this.Hide();
        }

        private void btnSettingForm_Click(object sender, EventArgs e)
        {

        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {

        }
    }
}

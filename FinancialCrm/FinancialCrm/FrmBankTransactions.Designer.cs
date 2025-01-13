namespace FinancialCrm
{
    partial class FrmBankTransactions
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnSettingForm = new System.Windows.Forms.Button();
            this.btnDashboardForm = new System.Windows.Forms.Button();
            this.btnBillForm = new System.Windows.Forms.Button();
            this.btnBillingForm = new System.Windows.Forms.Button();
            this.btnCategoryForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBankTransactionsForm = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbProcessBankId = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProcessAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateProcess = new System.Windows.Forms.Button();
            this.btnRemoveProcess = new System.Windows.Forms.Button();
            this.btnCreateProcess = new System.Windows.Forms.Button();
            this.btnProcessList = new System.Windows.Forms.Button();
            this.txtProcessType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProcessDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProcessDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProcessId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnLogOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(28, 366);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(148, 44);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Çıkış Yap";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnSettingForm
            // 
            this.btnSettingForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnSettingForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettingForm.ForeColor = System.Drawing.Color.White;
            this.btnSettingForm.Location = new System.Drawing.Point(28, 316);
            this.btnSettingForm.Name = "btnSettingForm";
            this.btnSettingForm.Size = new System.Drawing.Size(148, 44);
            this.btnSettingForm.TabIndex = 7;
            this.btnSettingForm.Text = "Ayarlar";
            this.btnSettingForm.UseVisualStyleBackColor = false;
            this.btnSettingForm.Click += new System.EventHandler(this.btnSettingForm_Click);
            // 
            // btnDashboardForm
            // 
            this.btnDashboardForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnDashboardForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboardForm.ForeColor = System.Drawing.Color.White;
            this.btnDashboardForm.Location = new System.Drawing.Point(28, 266);
            this.btnDashboardForm.Name = "btnDashboardForm";
            this.btnDashboardForm.Size = new System.Drawing.Size(148, 44);
            this.btnDashboardForm.TabIndex = 6;
            this.btnDashboardForm.Text = "Dashboard";
            this.btnDashboardForm.UseVisualStyleBackColor = false;
            this.btnDashboardForm.Click += new System.EventHandler(this.btnDashboardForm_Click);
            // 
            // btnBillForm
            // 
            this.btnBillForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnBillForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillForm.ForeColor = System.Drawing.Color.White;
            this.btnBillForm.Location = new System.Drawing.Point(28, 166);
            this.btnBillForm.Name = "btnBillForm";
            this.btnBillForm.Size = new System.Drawing.Size(148, 44);
            this.btnBillForm.TabIndex = 4;
            this.btnBillForm.Text = "Giderler";
            this.btnBillForm.UseVisualStyleBackColor = false;
            this.btnBillForm.Click += new System.EventHandler(this.btnBillForm_Click);
            // 
            // btnBillingForm
            // 
            this.btnBillingForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnBillingForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillingForm.ForeColor = System.Drawing.Color.White;
            this.btnBillingForm.Location = new System.Drawing.Point(28, 116);
            this.btnBillingForm.Name = "btnBillingForm";
            this.btnBillingForm.Size = new System.Drawing.Size(148, 44);
            this.btnBillingForm.TabIndex = 3;
            this.btnBillingForm.Text = "Faturalar";
            this.btnBillingForm.UseVisualStyleBackColor = false;
            this.btnBillingForm.Click += new System.EventHandler(this.btnBillingForm_Click);
            // 
            // btnCategoryForm
            // 
            this.btnCategoryForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnCategoryForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoryForm.ForeColor = System.Drawing.Color.White;
            this.btnCategoryForm.Location = new System.Drawing.Point(28, 16);
            this.btnCategoryForm.Name = "btnCategoryForm";
            this.btnCategoryForm.Size = new System.Drawing.Size(148, 44);
            this.btnCategoryForm.TabIndex = 1;
            this.btnCategoryForm.Text = "Kategoriler";
            this.btnCategoryForm.UseVisualStyleBackColor = false;
            this.btnCategoryForm.Click += new System.EventHandler(this.btnCategoryForm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnSettingForm);
            this.panel1.Controls.Add(this.btnDashboardForm);
            this.panel1.Controls.Add(this.btnBankTransactionsForm);
            this.panel1.Controls.Add(this.btnBillForm);
            this.panel1.Controls.Add(this.btnBillingForm);
            this.panel1.Controls.Add(this.btnBanksForm);
            this.panel1.Controls.Add(this.btnCategoryForm);
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 428);
            this.panel1.TabIndex = 16;
            // 
            // btnBankTransactionsForm
            // 
            this.btnBankTransactionsForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnBankTransactionsForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankTransactionsForm.ForeColor = System.Drawing.Color.White;
            this.btnBankTransactionsForm.Location = new System.Drawing.Point(28, 216);
            this.btnBankTransactionsForm.Name = "btnBankTransactionsForm";
            this.btnBankTransactionsForm.Size = new System.Drawing.Size(148, 44);
            this.btnBankTransactionsForm.TabIndex = 5;
            this.btnBankTransactionsForm.Text = "Banka Hareketleri";
            this.btnBankTransactionsForm.UseVisualStyleBackColor = false;
            this.btnBankTransactionsForm.Click += new System.EventHandler(this.btnBankTransactionsForm_Click);
            // 
            // btnBanksForm
            // 
            this.btnBanksForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnBanksForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanksForm.ForeColor = System.Drawing.Color.White;
            this.btnBanksForm.Location = new System.Drawing.Point(28, 66);
            this.btnBanksForm.Name = "btnBanksForm";
            this.btnBanksForm.Size = new System.Drawing.Size(148, 44);
            this.btnBanksForm.TabIndex = 2;
            this.btnBanksForm.Text = "Bankalar";
            this.btnBanksForm.UseVisualStyleBackColor = false;
            this.btnBanksForm.Click += new System.EventHandler(this.btnBanksForm_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(129)))), ((int)(((byte)(237)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(895, 65);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Banka Hareketleri Formu";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.cmbProcessBankId);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtProcessAmount);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnUpdateProcess);
            this.panel3.Controls.Add(this.btnRemoveProcess);
            this.panel3.Controls.Add(this.btnCreateProcess);
            this.panel3.Controls.Add(this.btnProcessList);
            this.panel3.Controls.Add(this.txtProcessType);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtProcessDate);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtProcessDescription);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtProcessId);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(209, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(681, 245);
            this.panel3.TabIndex = 18;
            // 
            // cmbProcessBankId
            // 
            this.cmbProcessBankId.BackColor = System.Drawing.Color.Khaki;
            this.cmbProcessBankId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbProcessBankId.FormattingEnabled = true;
            this.cmbProcessBankId.Location = new System.Drawing.Point(100, 170);
            this.cmbProcessBankId.Name = "cmbProcessBankId";
            this.cmbProcessBankId.Size = new System.Drawing.Size(574, 28);
            this.cmbProcessBankId.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(44, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Banka:";
            // 
            // txtProcessAmount
            // 
            this.txtProcessAmount.BackColor = System.Drawing.Color.Khaki;
            this.txtProcessAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProcessAmount.Location = new System.Drawing.Point(100, 138);
            this.txtProcessAmount.Name = "txtProcessAmount";
            this.txtProcessAmount.Size = new System.Drawing.Size(574, 27);
            this.txtProcessAmount.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(51, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tutar:";
            // 
            // btnUpdateProcess
            // 
            this.btnUpdateProcess.BackColor = System.Drawing.Color.Silver;
            this.btnUpdateProcess.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateProcess.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateProcess.Location = new System.Drawing.Point(522, 200);
            this.btnUpdateProcess.Name = "btnUpdateProcess";
            this.btnUpdateProcess.Size = new System.Drawing.Size(123, 41);
            this.btnUpdateProcess.TabIndex = 14;
            this.btnUpdateProcess.Text = "Güncelle";
            this.btnUpdateProcess.UseVisualStyleBackColor = false;
            this.btnUpdateProcess.Click += new System.EventHandler(this.btnUpdateProcess_Click);
            // 
            // btnRemoveProcess
            // 
            this.btnRemoveProcess.BackColor = System.Drawing.Color.Silver;
            this.btnRemoveProcess.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveProcess.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveProcess.Location = new System.Drawing.Point(393, 200);
            this.btnRemoveProcess.Name = "btnRemoveProcess";
            this.btnRemoveProcess.Size = new System.Drawing.Size(123, 41);
            this.btnRemoveProcess.TabIndex = 13;
            this.btnRemoveProcess.Text = "İşlem Sil";
            this.btnRemoveProcess.UseVisualStyleBackColor = false;
            this.btnRemoveProcess.Click += new System.EventHandler(this.btnRemoveProcess_Click);
            // 
            // btnCreateProcess
            // 
            this.btnCreateProcess.BackColor = System.Drawing.Color.Silver;
            this.btnCreateProcess.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateProcess.ForeColor = System.Drawing.Color.Black;
            this.btnCreateProcess.Location = new System.Drawing.Point(264, 200);
            this.btnCreateProcess.Name = "btnCreateProcess";
            this.btnCreateProcess.Size = new System.Drawing.Size(123, 41);
            this.btnCreateProcess.TabIndex = 12;
            this.btnCreateProcess.Text = "Yeni İşlem";
            this.btnCreateProcess.UseVisualStyleBackColor = false;
            this.btnCreateProcess.Click += new System.EventHandler(this.btnCreateProcess_Click);
            // 
            // btnProcessList
            // 
            this.btnProcessList.BackColor = System.Drawing.Color.Silver;
            this.btnProcessList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProcessList.ForeColor = System.Drawing.Color.Black;
            this.btnProcessList.Location = new System.Drawing.Point(135, 200);
            this.btnProcessList.Name = "btnProcessList";
            this.btnProcessList.Size = new System.Drawing.Size(123, 41);
            this.btnProcessList.TabIndex = 9;
            this.btnProcessList.Text = "İşlem Listesi";
            this.btnProcessList.UseVisualStyleBackColor = false;
            this.btnProcessList.Click += new System.EventHandler(this.btnProcessList_Click);
            // 
            // txtProcessType
            // 
            this.txtProcessType.BackColor = System.Drawing.Color.Khaki;
            this.txtProcessType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProcessType.Location = new System.Drawing.Point(100, 105);
            this.txtProcessType.Name = "txtProcessType";
            this.txtProcessType.Size = new System.Drawing.Size(574, 27);
            this.txtProcessType.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(7, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Havale Türü:";
            // 
            // txtProcessDate
            // 
            this.txtProcessDate.BackColor = System.Drawing.Color.Khaki;
            this.txtProcessDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProcessDate.Location = new System.Drawing.Point(100, 72);
            this.txtProcessDate.Name = "txtProcessDate";
            this.txtProcessDate.Size = new System.Drawing.Size(574, 27);
            this.txtProcessDate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(52, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tarih:";
            // 
            // txtProcessDescription
            // 
            this.txtProcessDescription.BackColor = System.Drawing.Color.Khaki;
            this.txtProcessDescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProcessDescription.Location = new System.Drawing.Point(100, 39);
            this.txtProcessDescription.Name = "txtProcessDescription";
            this.txtProcessDescription.Size = new System.Drawing.Size(574, 27);
            this.txtProcessDescription.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "İşlem İçeriği:";
            // 
            // txtProcessId
            // 
            this.txtProcessId.BackColor = System.Drawing.Color.Khaki;
            this.txtProcessId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProcessId.Location = new System.Drawing.Point(100, 6);
            this.txtProcessId.Name = "txtProcessId";
            this.txtProcessId.Size = new System.Drawing.Size(574, 27);
            this.txtProcessId.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(34, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "İşlem Id:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(209, 309);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(681, 182);
            this.panel4.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(681, 182);
            this.dataGridView1.TabIndex = 0;
            // 
            // FrmBankTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 491);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmBankTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBankTransactions";
            this.Load += new System.EventHandler(this.FrmBankTransactions_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnSettingForm;
        private System.Windows.Forms.Button btnDashboardForm;
        private System.Windows.Forms.Button btnBillForm;
        private System.Windows.Forms.Button btnBillingForm;
        private System.Windows.Forms.Button btnCategoryForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBankTransactionsForm;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUpdateProcess;
        private System.Windows.Forms.Button btnRemoveProcess;
        private System.Windows.Forms.Button btnCreateProcess;
        private System.Windows.Forms.Button btnProcessList;
        private System.Windows.Forms.TextBox txtProcessType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProcessDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProcessDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProcessId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProcessAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbProcessBankId;
    }
}
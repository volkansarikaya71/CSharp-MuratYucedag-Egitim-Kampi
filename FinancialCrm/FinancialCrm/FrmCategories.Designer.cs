namespace FinancialCrm
{
    partial class FrmCategories
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
            this.btnBankTransactionsForm = new System.Windows.Forms.Button();
            this.btnBillForm = new System.Windows.Forms.Button();
            this.btnBillingForm = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.btnCategoryForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.btnCreateCategory = new System.Windows.Forms.Button();
            this.btnCategoryList = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(190, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategori Formu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(210, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(681, 213);
            this.dataGridView1.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.btnUpdateCategory);
            this.panel3.Controls.Add(this.btnRemoveCategory);
            this.panel3.Controls.Add(this.btnCreateCategory);
            this.panel3.Controls.Add(this.btnCategoryList);
            this.panel3.Controls.Add(this.txtCategoryName);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtCategoryId);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(210, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(681, 213);
            this.panel3.TabIndex = 18;
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.BackColor = System.Drawing.Color.Silver;
            this.btnUpdateCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateCategory.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateCategory.Location = new System.Drawing.Point(510, 136);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(123, 41);
            this.btnUpdateCategory.TabIndex = 14;
            this.btnUpdateCategory.Text = "Güncelle";
            this.btnUpdateCategory.UseVisualStyleBackColor = false;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.BackColor = System.Drawing.Color.Silver;
            this.btnRemoveCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveCategory.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveCategory.Location = new System.Drawing.Point(381, 136);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(123, 41);
            this.btnRemoveCategory.TabIndex = 13;
            this.btnRemoveCategory.Text = "Kategori Sil";
            this.btnRemoveCategory.UseVisualStyleBackColor = false;
            this.btnRemoveCategory.Click += new System.EventHandler(this.btnRemoveCategory_Click);
            // 
            // btnCreateCategory
            // 
            this.btnCreateCategory.BackColor = System.Drawing.Color.Silver;
            this.btnCreateCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateCategory.ForeColor = System.Drawing.Color.Black;
            this.btnCreateCategory.Location = new System.Drawing.Point(252, 136);
            this.btnCreateCategory.Name = "btnCreateCategory";
            this.btnCreateCategory.Size = new System.Drawing.Size(123, 41);
            this.btnCreateCategory.TabIndex = 12;
            this.btnCreateCategory.Text = "Yeni Kategori";
            this.btnCreateCategory.UseVisualStyleBackColor = false;
            this.btnCreateCategory.Click += new System.EventHandler(this.btnCreateCategory_Click);
            // 
            // btnCategoryList
            // 
            this.btnCategoryList.BackColor = System.Drawing.Color.Silver;
            this.btnCategoryList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoryList.ForeColor = System.Drawing.Color.Black;
            this.btnCategoryList.Location = new System.Drawing.Point(123, 136);
            this.btnCategoryList.Name = "btnCategoryList";
            this.btnCategoryList.Size = new System.Drawing.Size(123, 41);
            this.btnCategoryList.TabIndex = 9;
            this.btnCategoryList.Text = "Kategori Listesi";
            this.btnCategoryList.UseVisualStyleBackColor = false;
            this.btnCategoryList.Click += new System.EventHandler(this.btnCategoryList_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.BackColor = System.Drawing.Color.Khaki;
            this.txtCategoryName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCategoryName.Location = new System.Drawing.Point(125, 85);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(553, 33);
            this.txtCategoryName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(5, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kategori Adı:";
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.BackColor = System.Drawing.Color.Khaki;
            this.txtCategoryId.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCategoryId.Location = new System.Drawing.Point(125, 46);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(553, 33);
            this.txtCategoryId.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategori Id:";
            // 
            // FrmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 491);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCategories";
            this.Load += new System.EventHandler(this.FrmCategories_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnSettingForm;
        private System.Windows.Forms.Button btnDashboardForm;
        private System.Windows.Forms.Button btnBankTransactionsForm;
        private System.Windows.Forms.Button btnBillForm;
        private System.Windows.Forms.Button btnBillingForm;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Button btnCategoryForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnRemoveCategory;
        private System.Windows.Forms.Button btnCreateCategory;
        private System.Windows.Forms.Button btnCategoryList;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.Label label2;
    }
}
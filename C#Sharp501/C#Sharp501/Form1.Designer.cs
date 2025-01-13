namespace C_Sharp501
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalProductCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMaxPriceProductName = new System.Windows.Forms.Label();
            this.lblDistinctCategoryCount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(23, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 78;
            this.label7.Text = "Kategori:";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductPrice.Location = new System.Drawing.Point(101, 104);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(267, 26);
            this.txtProductPrice.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 76;
            this.label4.Text = "Ürün Fiyat:";
            // 
            // txtProductStock
            // 
            this.txtProductStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductStock.Location = new System.Drawing.Point(101, 139);
            this.txtProductStock.Name = "txtProductStock";
            this.txtProductStock.Size = new System.Drawing.Size(267, 26);
            this.txtProductStock.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(10, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 74;
            this.label5.Text = "Ürün Stok:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.IndianRed;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(101, 347);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(267, 42);
            this.btnUpdate.TabIndex = 72;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(101, 299);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(267, 42);
            this.btnDelete.TabIndex = 71;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.IndianRed;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(101, 251);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(267, 42);
            this.btnAdd.TabIndex = 70;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.IndianRed;
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList.ForeColor = System.Drawing.SystemColors.Control;
            this.btnList.Location = new System.Drawing.Point(101, 203);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(267, 42);
            this.btnList.TabIndex = 69;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductName.Location = new System.Drawing.Point(101, 72);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(267, 26);
            this.txtProductName.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "Ürün Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(374, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(561, 349);
            this.dataGridView1.TabIndex = 66;
            // 
            // txtProductId
            // 
            this.txtProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductId.Location = new System.Drawing.Point(101, 40);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(267, 26);
            this.txtProductId.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 64;
            this.label1.Text = "Ürün ID:";
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCategory.Location = new System.Drawing.Point(101, 171);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(267, 26);
            this.txtCategory.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(53, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 84;
            this.label3.Text = "Toplam Kitap Sayısı:";
            // 
            // lblTotalProductCount
            // 
            this.lblTotalProductCount.AutoSize = true;
            this.lblTotalProductCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalProductCount.Location = new System.Drawing.Point(290, 491);
            this.lblTotalProductCount.Name = "lblTotalProductCount";
            this.lblTotalProductCount.Size = new System.Drawing.Size(18, 20);
            this.lblTotalProductCount.TabIndex = 85;
            this.lblTotalProductCount.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(53, 525);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 86;
            this.label6.Text = "En Pahalı Kitap";
            // 
            // lblMaxPriceProductName
            // 
            this.lblMaxPriceProductName.AutoSize = true;
            this.lblMaxPriceProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaxPriceProductName.Location = new System.Drawing.Point(290, 525);
            this.lblMaxPriceProductName.Name = "lblMaxPriceProductName";
            this.lblMaxPriceProductName.Size = new System.Drawing.Size(18, 20);
            this.lblMaxPriceProductName.TabIndex = 87;
            this.lblMaxPriceProductName.Text = "0";
            // 
            // lblDistinctCategoryCount
            // 
            this.lblDistinctCategoryCount.AutoSize = true;
            this.lblDistinctCategoryCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDistinctCategoryCount.Location = new System.Drawing.Point(290, 558);
            this.lblDistinctCategoryCount.Name = "lblDistinctCategoryCount";
            this.lblDistinctCategoryCount.Size = new System.Drawing.Size(18, 20);
            this.lblDistinctCategoryCount.TabIndex = 89;
            this.lblDistinctCategoryCount.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(53, 558);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 20);
            this.label9.TabIndex = 88;
            this.label9.Text = "Kategori Sayısı:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 727);
            this.Controls.Add(this.lblDistinctCategoryCount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblMaxPriceProductName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTotalProductCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProductStock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalProductCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMaxPriceProductName;
        private System.Windows.Forms.Label lblDistinctCategoryCount;
        private System.Windows.Forms.Label label9;
    }
}


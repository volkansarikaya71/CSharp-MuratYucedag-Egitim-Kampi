namespace C_SharpPostgreSQL
{
    partial class FrmEmployee
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
            this.txtEmployeeSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmployeeSalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEmployeeUpdate = new System.Windows.Forms.Button();
            this.btnEmployeeDelete = new System.Windows.Forms.Button();
            this.btnEmployeeCreate = new System.Windows.Forms.Button();
            this.btnEmployeeList = new System.Windows.Forms.Button();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEmployeeDepartment = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmployeeSurname
            // 
            this.txtEmployeeSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmployeeSurname.Location = new System.Drawing.Point(133, 107);
            this.txtEmployeeSurname.Name = "txtEmployeeSurname";
            this.txtEmployeeSurname.Size = new System.Drawing.Size(267, 26);
            this.txtEmployeeSurname.TabIndex = 132;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 131;
            this.label4.Text = "Pesonel SoyAdı:";
            // 
            // txtEmployeeSalary
            // 
            this.txtEmployeeSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmployeeSalary.Location = new System.Drawing.Point(133, 142);
            this.txtEmployeeSalary.Name = "txtEmployeeSalary";
            this.txtEmployeeSalary.Size = new System.Drawing.Size(267, 26);
            this.txtEmployeeSalary.TabIndex = 130;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(17, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 129;
            this.label5.Text = "Pesonel Maaş:";
            // 
            // btnEmployeeUpdate
            // 
            this.btnEmployeeUpdate.BackColor = System.Drawing.Color.IndianRed;
            this.btnEmployeeUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmployeeUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEmployeeUpdate.Location = new System.Drawing.Point(133, 354);
            this.btnEmployeeUpdate.Name = "btnEmployeeUpdate";
            this.btnEmployeeUpdate.Size = new System.Drawing.Size(267, 42);
            this.btnEmployeeUpdate.TabIndex = 128;
            this.btnEmployeeUpdate.Text = "Güncelle";
            this.btnEmployeeUpdate.UseVisualStyleBackColor = false;
            this.btnEmployeeUpdate.Click += new System.EventHandler(this.btnEmployeeUpdate_Click);
            // 
            // btnEmployeeDelete
            // 
            this.btnEmployeeDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnEmployeeDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmployeeDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEmployeeDelete.Location = new System.Drawing.Point(133, 306);
            this.btnEmployeeDelete.Name = "btnEmployeeDelete";
            this.btnEmployeeDelete.Size = new System.Drawing.Size(267, 42);
            this.btnEmployeeDelete.TabIndex = 127;
            this.btnEmployeeDelete.Text = "Sil";
            this.btnEmployeeDelete.UseVisualStyleBackColor = false;
            this.btnEmployeeDelete.Click += new System.EventHandler(this.btnEmployeeDelete_Click);
            // 
            // btnEmployeeCreate
            // 
            this.btnEmployeeCreate.BackColor = System.Drawing.Color.IndianRed;
            this.btnEmployeeCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmployeeCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEmployeeCreate.Location = new System.Drawing.Point(133, 258);
            this.btnEmployeeCreate.Name = "btnEmployeeCreate";
            this.btnEmployeeCreate.Size = new System.Drawing.Size(267, 42);
            this.btnEmployeeCreate.TabIndex = 126;
            this.btnEmployeeCreate.Text = "Ekle";
            this.btnEmployeeCreate.UseVisualStyleBackColor = false;
            this.btnEmployeeCreate.Click += new System.EventHandler(this.btnEmployeeCreate_Click);
            // 
            // btnEmployeeList
            // 
            this.btnEmployeeList.BackColor = System.Drawing.Color.IndianRed;
            this.btnEmployeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmployeeList.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEmployeeList.Location = new System.Drawing.Point(133, 210);
            this.btnEmployeeList.Name = "btnEmployeeList";
            this.btnEmployeeList.Size = new System.Drawing.Size(267, 42);
            this.btnEmployeeList.TabIndex = 125;
            this.btnEmployeeList.Text = "Listele";
            this.btnEmployeeList.UseVisualStyleBackColor = false;
            this.btnEmployeeList.Click += new System.EventHandler(this.btnEmployeeList_Click);
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmployeeName.Location = new System.Drawing.Point(133, 75);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(267, 26);
            this.txtEmployeeName.TabIndex = 124;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(33, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 123;
            this.label2.Text = "Pesonel Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(406, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(569, 365);
            this.dataGridView1.TabIndex = 122;
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmployeeId.Location = new System.Drawing.Point(133, 43);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(267, 26);
            this.txtEmployeeId.TabIndex = 121;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 120;
            this.label1.Text = "Pesonel ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(37, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 134;
            this.label3.Text = "Departman:";
            // 
            // cmbEmployeeDepartment
            // 
            this.cmbEmployeeDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbEmployeeDepartment.FormattingEnabled = true;
            this.cmbEmployeeDepartment.Location = new System.Drawing.Point(133, 176);
            this.cmbEmployeeDepartment.Name = "cmbEmployeeDepartment";
            this.cmbEmployeeDepartment.Size = new System.Drawing.Size(267, 28);
            this.cmbEmployeeDepartment.TabIndex = 135;
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 515);
            this.Controls.Add(this.cmbEmployeeDepartment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmployeeSurname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmployeeSalary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEmployeeUpdate);
            this.Controls.Add(this.btnEmployeeDelete);
            this.Controls.Add(this.btnEmployeeCreate);
            this.Controls.Add(this.btnEmployeeList);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtEmployeeId);
            this.Controls.Add(this.label1);
            this.Name = "FrmEmployee";
            this.Text = "FrmEmployee";
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEmployeeSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmployeeSalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEmployeeUpdate;
        private System.Windows.Forms.Button btnEmployeeDelete;
        private System.Windows.Forms.Button btnEmployeeCreate;
        private System.Windows.Forms.Button btnEmployeeList;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEmployeeDepartment;
    }
}
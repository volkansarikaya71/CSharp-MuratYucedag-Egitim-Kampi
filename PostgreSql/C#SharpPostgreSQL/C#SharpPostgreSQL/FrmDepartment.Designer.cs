namespace C_SharpPostgreSQL
{
    partial class FrmDepartment
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
            this.btnDepartmentUpdate = new System.Windows.Forms.Button();
            this.btnDepartmentDelete = new System.Windows.Forms.Button();
            this.btnDepartmentCreate = new System.Windows.Forms.Button();
            this.btnDepartmentList = new System.Windows.Forms.Button();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDepartmentId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDepartmentUpdate
            // 
            this.btnDepartmentUpdate.BackColor = System.Drawing.Color.IndianRed;
            this.btnDepartmentUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepartmentUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDepartmentUpdate.Location = new System.Drawing.Point(150, 260);
            this.btnDepartmentUpdate.Name = "btnDepartmentUpdate";
            this.btnDepartmentUpdate.Size = new System.Drawing.Size(267, 42);
            this.btnDepartmentUpdate.TabIndex = 128;
            this.btnDepartmentUpdate.Text = "Güncelle";
            this.btnDepartmentUpdate.UseVisualStyleBackColor = false;
            this.btnDepartmentUpdate.Click += new System.EventHandler(this.btnDepartmentUpdate_Click);
            // 
            // btnDepartmentDelete
            // 
            this.btnDepartmentDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDepartmentDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepartmentDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDepartmentDelete.Location = new System.Drawing.Point(150, 212);
            this.btnDepartmentDelete.Name = "btnDepartmentDelete";
            this.btnDepartmentDelete.Size = new System.Drawing.Size(267, 42);
            this.btnDepartmentDelete.TabIndex = 127;
            this.btnDepartmentDelete.Text = "Sil";
            this.btnDepartmentDelete.UseVisualStyleBackColor = false;
            this.btnDepartmentDelete.Click += new System.EventHandler(this.btnDepartmentDelete_Click);
            // 
            // btnDepartmentCreate
            // 
            this.btnDepartmentCreate.BackColor = System.Drawing.Color.IndianRed;
            this.btnDepartmentCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepartmentCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDepartmentCreate.Location = new System.Drawing.Point(150, 164);
            this.btnDepartmentCreate.Name = "btnDepartmentCreate";
            this.btnDepartmentCreate.Size = new System.Drawing.Size(267, 42);
            this.btnDepartmentCreate.TabIndex = 126;
            this.btnDepartmentCreate.Text = "Ekle";
            this.btnDepartmentCreate.UseVisualStyleBackColor = false;
            this.btnDepartmentCreate.Click += new System.EventHandler(this.btnDepartmentCreate_Click);
            // 
            // btnDepartmentList
            // 
            this.btnDepartmentList.BackColor = System.Drawing.Color.IndianRed;
            this.btnDepartmentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepartmentList.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDepartmentList.Location = new System.Drawing.Point(150, 116);
            this.btnDepartmentList.Name = "btnDepartmentList";
            this.btnDepartmentList.Size = new System.Drawing.Size(267, 42);
            this.btnDepartmentList.TabIndex = 125;
            this.btnDepartmentList.Text = "Listele";
            this.btnDepartmentList.UseVisualStyleBackColor = false;
            this.btnDepartmentList.Click += new System.EventHandler(this.btnDepartmentList_Click);
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDepartmentName.Location = new System.Drawing.Point(150, 84);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(267, 26);
            this.txtDepartmentName.TabIndex = 124;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 123;
            this.label2.Text = "Depatman Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(423, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(569, 250);
            this.dataGridView1.TabIndex = 122;
            // 
            // txtDepartmentId
            // 
            this.txtDepartmentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDepartmentId.Location = new System.Drawing.Point(150, 52);
            this.txtDepartmentId.Name = "txtDepartmentId";
            this.txtDepartmentId.Size = new System.Drawing.Size(267, 26);
            this.txtDepartmentId.TabIndex = 121;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 120;
            this.label1.Text = "Depatman ID:";
            // 
            // FrmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 331);
            this.Controls.Add(this.btnDepartmentUpdate);
            this.Controls.Add(this.btnDepartmentDelete);
            this.Controls.Add(this.btnDepartmentCreate);
            this.Controls.Add(this.btnDepartmentList);
            this.Controls.Add(this.txtDepartmentName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDepartmentId);
            this.Controls.Add(this.label1);
            this.Name = "FrmDepartment";
            this.Text = "FrmDepartment";
            this.Load += new System.EventHandler(this.FrmDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDepartmentUpdate;
        private System.Windows.Forms.Button btnDepartmentDelete;
        private System.Windows.Forms.Button btnDepartmentCreate;
        private System.Windows.Forms.Button btnDepartmentList;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDepartmentId;
        private System.Windows.Forms.Label label1;
    }
}
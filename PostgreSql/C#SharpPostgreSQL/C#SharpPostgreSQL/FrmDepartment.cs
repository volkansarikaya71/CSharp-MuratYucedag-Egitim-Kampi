using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_SharpPostgreSQL
{
    public partial class FrmDepartment : Form
    {
        public FrmDepartment()
        {
            InitializeComponent();
        }

        string connectionString = "Server=localhost;port=5432;Database=CustomerDb;user Id=postgres;Password=1";

        void DepartmentList()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From Departments";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void FrmDepartment_Load(object sender, EventArgs e)
        {
            DepartmentList();
        }

        private void btnDepartmentList_Click(object sender, EventArgs e)
        {
            DepartmentList();
        }

        private void btnDepartmentCreate_Click(object sender, EventArgs e)
        {
            string departmentsName = txtDepartmentName.Text;
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "insert into Departments (Departmentname) values (@departmentname)";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@departmentname", departmentsName);
            command.ExecuteNonQuery();
            MessageBox.Show("Ekleme İşlemi Başarılı");
            connection.Close();
            DepartmentList();
        }

        private void btnDepartmentDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtDepartmentId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Delete From Departments Where DepartmentId=@departmentId";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@departmentId", id);
            command.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Başarılı");
            connection.Close();
            DepartmentList();
        }

        private void btnDepartmentUpdate_Click(object sender, EventArgs e)
        {
            string departmentsName = txtDepartmentName.Text;
            int id = int.Parse(txtDepartmentId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Update Departments Set Departmentname=@departmentname Where DepartmentId=@departmentId";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@departmentname", departmentsName);
            command.Parameters.AddWithValue("@departmentId", id);
            command.ExecuteNonQuery();
            MessageBox.Show("Güncelleme İşlemi Başarılı");
            connection.Close();
            DepartmentList();
        }
    }
}

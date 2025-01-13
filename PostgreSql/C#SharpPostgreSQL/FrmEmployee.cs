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
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }
        string connectionString = "Server=localhost;port=5432;Database=CustomerDb;user Id=postgres;Password=1";

        void EmployeeList()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From Employees";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        void DepartmentList()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From Departments";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            cmbEmployeeDepartment.DisplayMember = "DepartmentName";
            cmbEmployeeDepartment.ValueMember = "DepartmentId";
            cmbEmployeeDepartment.DataSource = dataTable;
            connection.Close();
        }

        private void btnEmployeeList_Click(object sender, EventArgs e)
        {
            EmployeeList();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            EmployeeList();
            DepartmentList();
        }

        private void btnEmployeeCreate_Click(object sender, EventArgs e)
        {
            string employeeName = txtEmployeeName.Text;
            string employeeSurname = txtEmployeeSurname.Text;
            decimal employeeSalary = decimal.Parse(txtEmployeeSalary.Text);
            int departmentId = int.Parse(cmbEmployeeDepartment.SelectedValue.ToString());
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "insert into Employees (EmployeesName,EmployeesSurname,EmployeesSalary,DepartmentId) values (@employeesName,@employeesSurname,@employeesSalary,@departmentId)";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@employeesName", employeeName);
            command.Parameters.AddWithValue("@employeesSurname", employeeSurname);
            command.Parameters.AddWithValue("@employeesSalary", employeeSalary);
            command.Parameters.AddWithValue("@departmentId", departmentId);
            command.ExecuteNonQuery();
            MessageBox.Show("Ekleme İşlemi Başarılı");
            connection.Close();
            EmployeeList();
        }

        private void btnEmployeeDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtEmployeeId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Delete From Employees Where EmployeesId=@employeesId";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@employeesId", id);
            command.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Başarılı");
            connection.Close();
            EmployeeList();
        }

        private void btnEmployeeUpdate_Click(object sender, EventArgs e)
        {
            string employeeName = txtEmployeeName.Text;
            string employeeSurname = txtEmployeeSurname.Text;
            decimal employeeSalary = decimal.Parse(txtEmployeeSalary.Text);
            int departmentId = int.Parse(cmbEmployeeDepartment.SelectedValue.ToString());
            int employeeId=int.Parse(txtEmployeeId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Update Employees Set EmployeesName=@employeesName,EmployeesSurname=@employeesSurname,EmployeesSalary=@employeesSalary,DepartmentId=@departmentId Where EmployeesId=@employeesId";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@employeesName", employeeName);
            command.Parameters.AddWithValue("@employeesSurname", employeeSurname);
            command.Parameters.AddWithValue("@employeesSalary", employeeSalary);
            command.Parameters.AddWithValue("@departmentId", departmentId);
            command.Parameters.AddWithValue("@employeesId", employeeId);
            command.ExecuteNonQuery();
            MessageBox.Show("Ekleme İşlemi Başarılı");
            connection.Close();
            EmployeeList();
        }
    }
}

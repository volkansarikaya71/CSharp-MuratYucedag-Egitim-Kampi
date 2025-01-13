﻿using Npgsql;
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
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
        }

        string connectionString = "Server=localhost;port=5432;Database=CustomerDb;user Id=postgres;Password=1";

        void GetAllCustomers()
        {
            var connection=new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From Customers";
            var command=new NpgsqlCommand(query, connection);
            var adapter=new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }



        private void btnCustomerCreate_Click(object sender, EventArgs e)
        {
            string customerName=txtCustomerName.Text;
            string customerSurname = txtCustomerSurname.Text;
            string customerCity = txtCustomerCity.Text;
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "insert into Customers (CustomerName,CustomerSurname,CustomerCity) values (@customerName,@customerSurname,@customerCity)";
            var command= new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@customerName", customerName);
            command.Parameters.AddWithValue("@customerSurname", customerSurname);
            command.Parameters.AddWithValue("@customerCity", customerCity);
            command.ExecuteNonQuery();
            MessageBox.Show("Ekleme İşlemi Başarılı");
            connection.Close();
            GetAllCustomers();
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtCustomerId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Delete From Customers Where CustomerId=@customerId";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@customerId", id);
            command.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Başarılı");
            connection.Close();
            GetAllCustomers();
        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCustomerId.Text);
            string customerName = txtCustomerName.Text;
            string customerSurname = txtCustomerSurname.Text;
            string customerCity = txtCustomerCity.Text;
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Update Customers Set CustomerName=@customerName,CustomerSurname=@customerSurname,CustomerCity=@customerCity Where CustomerId=@customerId";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@customerName", customerName);
            command.Parameters.AddWithValue("@customerSurname", customerSurname);
            command.Parameters.AddWithValue("@customerCity", customerCity);
            command.Parameters.AddWithValue("@customerId", id);
            command.ExecuteNonQuery();
            MessageBox.Show("Güncelleme İşlemi Başarılı");
            connection.Close();
            GetAllCustomers();
        }

        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            GetAllCustomers();
        }

    }
}

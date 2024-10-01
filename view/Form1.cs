using Employees.controller;
using Employees.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        // Memanggil Class
        Connection connection  = new Connection(); // memanggil Class Connection
        EmployeeModel employee = new EmployeeModel(); // memanggil Class EmployeeModel

        // Method untuk menampilkan data
        public void Show() 
        {
            // Menampilkan data dari database ke DataGridView
            DataTable.DataSource = connection.ShowData("SELECT * FROM employees");

            // Mengubah Nama Column
            DataTable.Columns[0].HeaderText = "#";
            DataTable.Columns[1].HeaderText = "ID Card";
            DataTable.Columns[2].HeaderText = "Name";
            DataTable.Columns[3].HeaderText = "Position";
            DataTable.Columns[4].HeaderText = "Address";
            DataTable.Columns[5].HeaderText = "Email";
            DataTable.Columns[6].HeaderText = "Phone";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Memangil Method Show
            Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            // Validation input
            if (Name.Text == "" || IDCard.Text == "" || Position.SelectedIndex == -1 || Address.Text == "" || Email.Text == "" || Phone.Text == "")
            {
                MessageBox.Show("Please fill in the form", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            // Memanggil Class EmployeeController
            EmployeeController ec = new EmployeeController();
            
            employee.Id_card      = IDCard.Text;
            employee.Name         = Name.Text;
            employee.Position     = Position.Text;
            employee.Address      = Address.Text;
            employee.Email        = Email.Text;
            employee.Phone_number = Phone.Text;

            // Memanggil Method Insert
            ec.Insert(employee);

            // Buat agar form input kosong setelah di submit
            IDCard.Text            = "";
            Name.Text              = "";
            Position.SelectedIndex = -1;
            Address.Text           = "";
            Email.Text             = "";
            Phone.Text             = "";

            // Memanggil Method Show
            Show();
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

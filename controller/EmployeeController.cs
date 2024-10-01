using Employees.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees.controller
{
    internal class EmployeeController
    {
       // Memanggil Connection
       Connection db = new Connection();


        // Method Insert Data
        public bool Insert(EmployeeModel employee)
        {
            Boolean status = false;
            try {
                db.OpenConnection();
                db.ExecuteQuery("INSERT INTO employees (id_card, name, position, address, email, phone_number) " +
                    "VALUES ('" + employee.Id_card + "', '" + employee.Name + "', '" + employee.Position + "', '" + employee.Address + "', '" + employee.Email + "', '" + employee.Phone_number + "')");
             
                status = true;

                MessageBox.Show("Data has been saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.ClosedConnection();
            } catch(Exception e) {
                MessageBox.Show(e.Message, "Internal Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return status;
        }
    }
}

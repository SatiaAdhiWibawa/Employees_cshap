using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.model
{
    internal class EmployeeModel
    {
        // Deklarasi variabel private untuk menyimpan informasi employees
        // Variabel-variabel ini bersifat private sehingga hanya bisa diakses
        // melalui properti (getter dan setter) yang didefinisikan di bawah.
        string id_card, name, position, address, email, phone_number;


        // Konstruktor default tanpa parameter
        public EmployeeModel()
        {
        }


        // Overloaded Constructor
        // Konstruktor overload yang menerima parameter untuk menginisialisasi properti employees
        public EmployeeModel(string id_card, string name, string position, string address, string email, string phone_number)
        {
            // Inisialisasi properti dengan nilai dari parameter yang diterima
            this.Id_card      = id_card;
            this.Name         = name;
            this.Position     = position;
            this.Address      = address;
            this.Email        = email;
            this.Phone_number = phone_number;
        }


        // Properti untuk getter dan setter
        public string Id_card { get => id_card; set => id_card = value; }
        public string Name { get => name; set => name = value; }
        public string Position { get => position; set => position = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public string Phone_number { get => phone_number; set => phone_number = value; }
    }
}

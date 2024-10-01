using MySql.Data.MySqlClient; // Mengimpor package MySql
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class Connection
    {
        // koneksi ke database menggunakan connection string
        string serverAddress = "Server=localhost;Database=latihan_csharp;Uid=root;Pwd=;";

        // Deklarasi objek MySqlConnection yang digunakan untuk membuka dan menutup koneksi
        MySqlConnection con;


        // Metode untuk membuka koneksi ke database //
        public void OpenConnection()
        {
            con = new MySqlConnection(serverAddress);
            con.Open();
        }



        // Metode untuk menutup koneksi ke database
        public void ClosedConnection() 
        {
            con.Close();
        }



        // Metode untuk mengeksekusi query tanpa hasil (biasanya untuk INSERT, UPDATE, DELETE)
        public void ExecuteQuery(string query)
        {
            // Membuat MySqlCommand untuk mengeksekusi query
            MySqlCommand command = new MySqlCommand(query, con);

            command.ExecuteNonQuery();
        }



        // Metode untuk menampilkan data dari database Untuk SELECT
        public object ShowData(string query)
        {
            // Menggunakan MySqlDataAdapter untuk mengeksekusi query dan mengambil data
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, serverAddress);
            // Membuat DataSet untuk menyimpan data yang diambil
            DataSet ds = new DataSet();

            // Mengisi DataSet dengan hasil query
            adapter.Fill(ds);
            // Mengambil data dari tabel pertama yang dihasilkan dan mengembalikannya
            object datas = ds.Tables[0];
            return datas;
        }
    }
}

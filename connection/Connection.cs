using MySql.Data.MySqlClient;
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
        
        // deklarasi objek koneksi, MySqlCommand, dan MySqlDataReader
        MySqlConnection con;


        public void OpenConnection()
        {
            // buka koneksi database
            con = new MySqlConnection(serverAddress);
            con.Open();
        }


        public void ClosedConnection() 
        {
            con.Close();
        }

        public void ExecuteQuery(string query)
        {
            MySqlCommand command = new MySqlCommand(query, con);
            command.ExecuteNonQuery();
        }


        public object ShowData(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, serverAddress);
            DataSet ds = new DataSet();

            adapter.Fill(ds);
            object datas = ds.Tables[0];
            return datas;
        }
    }
}

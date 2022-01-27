using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace deneme11
{
    class Program
    {
    
        static void Main(string[] args)
        {
            Program program = new Program();
            program.baseconnetion();

            //DataTable table = new DataTable();
          //  string ConString = @"Data Source=.;Initial Catalog=VatanComputerDB;User ID=emresen;Password=1234;";
            //SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=VatanComputerDB;User ID=emresen;Password=1234;");
            //string querystring = "select * from Category";
            //con.Open();
            SqlCommand cmd = new SqlCommand("select * from Category", new SqlConnection(@"Data Source=.;Initial Catalog=VatanComputerDB;User ID=emresen;Password=1234;"));
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            //reader.Fill(table);


            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());

            }
            cmd.Connection.Close();



            //  Console.WriteLine(table.);
            core d = new core();
            d.ExecuteDataTableSqlDA();
           


        }
        public void Getdb()
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=VatanComputerDB;User ID=emresen;Password=1234;"))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select * from Category";

                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
            }

        }


        public void baseconnetion()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=VatanComputerDB;User ID=emresen;Password=1234;");
            SqlCommand command = new SqlCommand("select * from Category", conn);
            conn.Open();
            List<string> data = command.ExecuteReader().HasRows();
           
            conn.Close();

        }
    }
}

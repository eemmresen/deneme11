using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace deneme11
{
    class Program
    {
    
        static void Main(string[] args)
        {
            string a ;
            using (SqlCommand cmd = new SqlCommand("select max(id) from Category", new SqlConnection(@"Data Source=.;Initial Catalog=VatanComputerDB;User ID=emresen;Password=1234;")))
            {
              
                cmd.Connection.Open();

             var c = cmd.ExecuteScalar();
                a = c.ToString();
               
                cmd.Connection.Close();
            }
            Console.WriteLine(a);


           // StringBuilder sbAmout = new StringBuilder();
           // sbAmout.AppendFormat("INSERT INTO Category(Name,Description) VALUES('{0}','{1}')", "emre", "sen");
           // Console.WriteLine(sbAmout);

           // deneme1 d = new deneme1();
           // d.AddData("INSERT INTO Category(Name,Description) VALUES('T-shirt 3','aaa')");
           //  Console.WriteLine("----------------------------");
           //DataTable Product = d.GetData("select * from Product");


           // foreach (DataRow dtRow in Product.Rows)
           // {
           //     // On all tables' columns
           //     foreach (DataColumn dc in Product.Columns)
           //     {
           //         var field1 = dtRow[dc].ToString();
           //         Console.WriteLine(dc.ColumnName + "-->" + field1);
           //     }
           // }

            //core d = new core();
            //IHesap h = new core();
            //h.metotlar();
            //d.metotlar();
            //d.ExecuteDataTableSqlDA();
            //Program program = new Program();
            //program.baseconnetion();

            //DataTable table = new DataTable();
            //  string ConString = @"Data Source=.;Initial Catalog=VatanComputerDB;User ID=emresen;Password=1234;";
            //SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=VatanComputerDB;User ID=emresen;Password=1234;");
            //string querystring = "select * from Category";
            //con.Open();
            //SqlCommand cmd = new SqlCommand("select * from Category", new SqlConnection(@"Data Source=.;Initial Catalog=VatanComputerDB;User ID=emresen;Password=1234;"));
            //cmd.Connection.Open();
            //SqlDataReader reader = cmd.ExecuteReader();

            ////reader.Fill(table);


            //while (reader.Read())
            //{
            //    Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());

            //}
            //cmd.Connection.Close();



            //  Console.WriteLine(table.);




        }
        //public void Getdb()
        //{
        //    DataTable table = new DataTable();
        //    using (SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=VatanComputerDB;User ID=emresen;Password=1234;"))
        //    {
        //        SqlCommand command = new SqlCommand();
        //        command.Connection = connection;
        //        command.CommandType = System.Data.CommandType.Text;
        //        command.CommandText = "select * from Category";

        //        connection.Open();
        //        SqlDataAdapter adapter = new SqlDataAdapter(command);
        //        adapter.Fill(table);
        //    }

        //}


        //public void baseconnetion()
        //{
        //    SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=VatanComputerDB;User ID=emresen;Password=1234;");
        //    SqlCommand command = new SqlCommand("select * from Category", conn);
        //    conn.Open();
        //    bool data = command.ExecuteReader().HasRows;
           
        //    conn.Close();


        //}
    }
}

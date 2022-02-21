using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace deneme11
{
    class deneme1
    {
        public DataTable GetData(string query)
        {

          DataTable dataTable = new DataTable();


            using (SqlCommand cmd = new SqlCommand(query, new SqlConnection(@"Data Source=.;Initial Catalog=VatanComputerDB;User ID=emresen;Password=1234;")))
            {
                cmd.Connection.Open();


                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dataTable);

                cmd.Connection.Close();
            }
            return dataTable;

        }

        public void AddData(string query)
        {

            using (SqlCommand cmd = new SqlCommand(query, new SqlConnection(@"Data Source=.;Initial Catalog=VatanComputerDB;User ID=emresen;Password=1234;")))
            {
                cmd.Connection.Open();

                cmd.ExecuteNonQuery();

                cmd.Connection.Close();
            }
        }
    }

   
}

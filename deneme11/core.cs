using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace deneme11
{
    class core
    {
      //public void coretry()
      //  {
      //      string connection = @"Data Source=.;Initial Catalog=VatanComputerDB;User ID=emresen;Password=1234;";
      //      string sql = "Select * From Inventory";
      //      SqlCommand myCommand = new SqlCommand(sql, connection);
            
      //      //opening connection and executing the query
      //      connection.open;
      //      command.ExecuteNonQuery();
      //      connection.Close();
      //  }

        public  DataTable ExecuteDataTableSqlDA()
        {
            using (var connection = new SqlConnection(@"Data Source=.;Initial Catalog=VatanComputerDB;User ID=emresen;Password=1234;"))
            {
                // Do work here 
                DataTable dt = new DataTable();
                System.Data.SqlClient.SqlDataAdapter da = new SqlDataAdapter("select * from Category ", connection);
                da.Fill(dt);
                return dt;
            }
            //Bu db bağlantısı ado net ile yapılmıştır
          //Deneme yaptım
        }
    }


}

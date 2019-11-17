using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
  public class DBHelper
    {
         private static string str = "server=(local);integrated security= true;database=HotelManage2";
      
      public static DataTable Query(string sql) {
          SqlConnection conn = new SqlConnection(str);
          SqlCommand comm = new SqlCommand(sql, conn);
          SqlDataAdapter da = new SqlDataAdapter(comm);
          DataTable dt = new DataTable();
          da.Fill(dt);
          conn.Close();
          return dt;
  
      }

      public static int Modify(string sql) {
          SqlConnection conn = new SqlConnection(str);
          conn.Open();
          SqlCommand comm = new SqlCommand(sql, conn);
          int res = comm.ExecuteNonQuery();
          conn.Close();
          return res;
  
      }
    }
}

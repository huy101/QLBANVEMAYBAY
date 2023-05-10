
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
//using System.Configuration;

namespace HoVuQuocTrung
{
 	 public  class Connection
	 {//chan
	
         public  SqlConnection cn;
         string connnectionString = "Data Source=.;Initial Catalog=QuanLyBanVeMayBay;Integrated Security=True";
         //  private  string strconnection = // ConfigurationManager.ConnectionStrings["ConnectionStrings"].ToString();
	     public  Connection()
	      {
              cn = new SqlConnection(connnectionString);
             
	      }
	    //  Truyền câu truy vấn mới vào nếu có
         public Connection(string s)	
          { 	 
               cn = new SqlConnection(s); 	 
          }	 
          // hàm mở kết nối
          public void KetNoi()	 
          { 	       
              if (cn.State == ConnectionState.Closed) 	
              cn.Open();	
          }
	      // Hàm đóng kết nối
          public void DongKetNoi()
	       {
	          if (cn.State == ConnectionState.Open)
	          cn.Close();
            }
         // Hàm thực thi câu lệnh sql
          public int ExecuteNonQuery(string strQuery)
          {
              int CS = -1;
              try
              {
                  int result = 0;
                  if (this.cn.State == ConnectionState.Closed)
                  {
                      this.cn.Open();
                  }
                  result = new SqlCommand { Connection = this.cn, CommandType = CommandType.Text, CommandText = strQuery }.ExecuteNonQuery();
                  this.cn.Close();
                  CS = result;
              }
              catch 
              {
                  // throw ex;
                  return -1;
              }
              return CS;
          }
         // Hàm thực thi sql trả về bàng dữ liêu
          public DataTable ExecuteData(string strQuery)
	      {
             try
             {
                 KetNoi();
                 SqlDataAdapter adapter = new SqlDataAdapter(strQuery, cn);
                 DataSet dataSet = new DataSet();
                 adapter.Fill(dataSet);
                 DongKetNoi();
                 return dataSet.Tables[0];
              }
             catch { return null; }
         }
         // Hàm Thực thi  trả về đối tượng

          public object ExecuteScalar(string sql)
          {
              object CS= null;
              try
              {
                  object result = 0;
                  KetNoi();	 
                  result = new SqlCommand { Connection = this.cn, CommandType = CommandType.Text, CommandText = sql }.ExecuteScalar();
                  DongKetNoi();
                  CS = result;
              }
              catch
              {
                  return null;
          
              }
              return CS;
          }
          public static string Encrypt_md5(string p)
          {
             
              MD5CryptoServiceProvider mdcsp = new MD5CryptoServiceProvider();
              byte[] b = System.Text.Encoding.UTF8.GetBytes(p);
              b = mdcsp.ComputeHash(b);
              StringBuilder s = new StringBuilder();
              foreach (byte by in b)
              {
                  s.Append(by.ToString("x2").ToLower());
              }
              return s.ToString();
          }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace taotrangweb
{
    public class LopKetNoi
    {
        SqlConnection con;
        private void ketnoi()
        {

            string sqlCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\baitapkttmdt\taotrangwep\taotrangweb\taotrangweb\App_Data\banhang.mdf;Integrated Security=True";
            con = new SqlConnection(sqlCon);
            con.Open();
        }
        private void dongketnoi()
        {
            if(con.State==ConnectionState.Open)
            con.Close();
        }
        public DataTable docdulieu(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                ketnoi();
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dt);

          
            }
            catch
            {
                dt = null;
            }
            finally
            {
                dongketnoi();
            }
           
            return dt;

        }

        public int CapNhat(string sql)
        {
            int ketqua = 0;
            try
            {
                ketnoi();
                SqlCommand cmd = new SqlCommand(sql, con);
                ketqua = cmd.ExecuteNonQuery();


            }
            catch
            {
              
            }
            finally
            {
                dongketnoi();
            }

            return ketqua;

        }
        
           
           
           
        }
   
    }

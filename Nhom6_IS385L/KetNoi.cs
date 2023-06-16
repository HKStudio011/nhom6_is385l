using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Nhom6_IS385L
{
    public class KetNoi
    {
        string path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\QLBH.mdf;Integrated Security=True";
        SqlConnection con ;
        private void TaoKetNoi()
        {
            con = new SqlConnection(path);
            con.Open();
        }
        private void DongKetNoi()
        {
            if(con.State==ConnectionState.Open)
                con.Close();
        }
        public DataTable LayDuLieu(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                TaoKetNoi();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query,con);
                sqlDataAdapter.Fill(dt);
            }
            catch (Exception ex) 
            {
                dt = null;
            }
            finally
            {
                DongKetNoi();
            }
            return dt;
        }
    }
}
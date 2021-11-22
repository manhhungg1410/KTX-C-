using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKTX
{
    class DataHelper
    {
        string sqlConnect = "Data Source=MANHHUNG\\SQLEXPRESS;Initial Catalog=QLKTXSV;Integrated Security=True";
        SqlConnection sql_conn = null;

        public void OpenConnect()
        {
            sql_conn = new SqlConnection(sqlConnect);
            if (sql_conn.State != ConnectionState.Open)
            {
                sql_conn.Open();
            }
        }

        public void CloseConnect()
        {
            if (sql_conn.State != ConnectionState.Closed)
            {
                sql_conn.Close();
                sql_conn.Dispose();
            }
        }

        // Thực thi câu lệnh sql
        public void ExecuteQuery(string sql)
        {
            try
            {
                OpenConnect();
                SqlCommand command = new SqlCommand();
                command.Connection = sql_conn;
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CloseConnect();
                command.Dispose();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }       
        }

        public DataTable getTable(string sql)
        {
            try
            {
                DataTable dta = new DataTable();
                OpenConnect();
                SqlDataAdapter res = new SqlDataAdapter(sql, sqlConnect);
                res.Fill(dta);
                res.Dispose();
                CloseConnect();
                return dta;
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.Message);
            }
        }
    }
}

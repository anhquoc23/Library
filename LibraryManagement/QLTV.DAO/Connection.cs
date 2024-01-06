using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLTV.DAO
{
    public class Connection
    {
        private static SqlConnection conn;
        public Connection() 
        {
            conn = new SqlConnection("Server = DELL; Database = Library; Integrated Security = true");
        }

        public SqlConnection Connect()
        {
            return conn;
        }

        public DataTable ReaderData(String sql, SqlConnection conn)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            SqlDataReader readdata = cmd.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(readdata);
            return data;
        }
    }
}

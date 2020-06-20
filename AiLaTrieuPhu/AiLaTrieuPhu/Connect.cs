using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace AiLaTrieuPhu
{
    class Connect
    {
        private SqlConnection sc;
        private SqlDataAdapter dataAp;
        private DataTable dataTable;
        public static string connectStr = @"Data Source=.;Initial Catalog=AiLaTrieuPhu;Integrated Security=True";
        public Connect()
        {
            sc = new SqlConnection(connectStr);
            sc.Open();
            sc.Close();
        }
        public DataTable GetDataTable(string sql)
        {
            dataAp = new SqlDataAdapter(sql, sc);
            dataTable = new DataTable();
            dataAp.Fill(dataTable);
            return dataTable;
        }
    }
}

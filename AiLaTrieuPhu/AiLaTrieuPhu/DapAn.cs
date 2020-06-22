using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AiLaTrieuPhu
{
    public class DapAn
    {
        public int count { set; get; }
        public string macauhoi { set; get; }
        public string trangthai { set; get; }
        public DataTable LayDapAn()
        {
            Connect connect = new Connect();
            DataTable tablecauhoi = new DataTable();
            string sql = string.Format("Select * from DapAnDe where MaCauHoi='{0}'", macauhoi);
            tablecauhoi = connect.GetDataTable(sql);
            return tablecauhoi;
        }
    }
}

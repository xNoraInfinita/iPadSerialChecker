using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace iPadSerialChecker
{
    class serialreader
    {
        private string connectionstring = "Server=192.168.10.250;Database=AssetInventory; User ID=registration; Password=ldke93vje2!o45;Connection Timeout=500;";
        SqlDataReader sdr;
        

        public serialreader()
        {
            SqlConnection con = new SqlConnection(this.connectionstring);
            con.Open();
            SqlTransaction strans = con.BeginTransaction();
            SqlCommand scmd = con.CreateCommand();

            scmd.Transaction = strans;
            scmd.CommandType = CommandType.Text;
            scmd.CommandText = "Select * from dbo.AssetTable";
            sdr = scmd.ExecuteReader();
            
        }
        public string getnextserialnumber()
        {
            sdr.Read();
            return sdr["SerialNumber"].ToString();
        }
    }
}

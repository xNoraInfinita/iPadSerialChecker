using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows;
namespace iPadSerialChecker
{
    class serialreader
    {
        private string connectionstring = "Server=192.168.10.250;Database=AssetInventory; User ID=registration; Password=ldke93vje2!o45;Connection Timeout=500;";
        private int Iter = 0;
        string[] serialarray;
        List<string> Serials = new List<string>();
        public serialreader()
        {
            SqlConnection con = new SqlConnection(this.connectionstring);
            con.Open();
            SqlTransaction strans = con.BeginTransaction();
            SqlCommand scmd = con.CreateCommand();

            scmd.Transaction = strans;
            scmd.CommandType = CommandType.Text;
            scmd.CommandText = "Select * from dbo.AssetTable where AssetType like '%ipad%'";
            SqlDataReader sdr = scmd.ExecuteReader();
            while (sdr.Read())
            {
                Serials.Add(sdr["SerialNumber"].ToString());
            }
            con.Close();
            sdr.Close();
            serialarray = new string[Serials.Count];
            serialarray = Serials.ToArray();
        }
        public string getnextserialnumber()
        {
            string temp = serialarray[Iter];
            Iter++;
            return temp;
        }
    }
}


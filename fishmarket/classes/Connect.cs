using System;//
using System.Collections.Generic;//
using System.Linq;//
using System.Text;//
using System.Threading.Tasks;
using System.Data;//
using System.Windows.Forms;//
using System.Data.OleDb;//
using System.IO;
using System.ComponentModel;//
using System.Drawing;//


namespace fishmarket.classes
{
    class Context
    {
        public static OleDbConnection baseConnect = new OleDbConnection(Properties.Settings.Default.conString);
    }
    class Connect
    {
        public static DataTable GetTable(OleDbConnection myConnection, string cmdText)
        {
            OleDbCommand comm = myConnection.CreateCommand();
            DataTable dt = new DataTable();

            comm.CommandType = CommandType.Text;
            comm.CommandText = cmdText;

            try
            {
                comm.Connection.Open();
                dt.Load(comm.ExecuteReader());
            }
            finally
            {
                comm.Connection.Close();
            }
            return dt;
        }
    }
}

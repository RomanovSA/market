using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace fishmarket.classes
{
    class DataSotrud
    {
        private static DataTable dtMain = null;

        public static void Load()
        {
            dtMain = Connect.GetTable(Context.baseConnect, String.Format("SELECT * FROM Сотрудники"));
        }
        public static DataTable DBOperation()
        {
            return dtMain;
        }

        public static void Delete(string order)
        {
            dtMain = Connect.GetTable(Context.baseConnect, String.Format("DELETE FROM Клиенты WHERE [Код сотрудника] = '{0}%'", order));
        }
    }
}

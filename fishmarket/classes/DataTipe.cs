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
    class DataTipe
    {
        private static DataTable dtMain = null;

        public static void Load()
        {
            dtMain = Connect.GetTable(Context.baseConnect, String.Format("SELECT * FROM Типы"));
        }
        public static DataTable DBOperation()
        {
            return dtMain;
        }

        public static void Delete(string tipe)
        {
            dtMain = Connect.GetTable(Context.baseConnect, String.Format("DELETE FROM Типы WHERE [Код типа] = '{0}%'", tipe));
        }

        public static void Insert(string category, string opisan)
        {
            dtMain = Connect.GetTable(Context.baseConnect, String.Format("INSERT INTO Типы ([Категория], [Описание]) VALUES ('{0}', '{1}')", category, opisan));
        }

        public static void Update(string category, string opisan)
        {
            dtMain = Connect.GetTable(Context.baseConnect, String.Format("UPDATE Типы SET ([Категория] = '{0}', [Описание] = '{1}')", category, opisan));
        }
    }
}

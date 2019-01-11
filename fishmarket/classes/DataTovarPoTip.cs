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
    class DataTovarPoTip
    {
        private static DataTable dtMain = null;

        public static void Load()
        {
            dtMain = Connect.GetTable(Context.baseConnect, String.Format("SELECT Типы.Категория, Товары.Производитель, " +
                "Товары.Наименование, Товары.[На складе] FROM Типы " +
                "INNER JOIN Товары ON Типы.[Код типа] = Товары.[Код типа] ORDER BY Типы.Категория, " +
                "Товары.Производитель"));
        }
        public static DataTable DBOperation()
        {
            return dtMain;
        }
    }
}

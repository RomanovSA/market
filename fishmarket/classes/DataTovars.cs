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
    class DataTovars
    {
        private static DataTable dtMain = null;

        public static void Load()
        {
            dtMain = Connect.GetTable(Context.baseConnect, String.Format("SELECT Товары.[Код товара], " +
                "Товары.Производитель, Товары.Наименование, Товары.[Страна изготовления], Товары.[Код поставщика], " +
                "Товары.Животное, Товары.[Код типа], Товары.Цена, Товары.[Годен до], Товары.[На складе], " +
                "Товары.Ожидается FROM Товары"));
        }
        public static DataTable DBOperation()
        {
            return dtMain;
        }
    }
}

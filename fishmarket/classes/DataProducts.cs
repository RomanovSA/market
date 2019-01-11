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
    class DataProducts
    {
        private static DataTable dtMain = null;

        public static void Load()
        {
            dtMain = Connect.GetTable(Context.baseConnect, String.Format("SELECT * FROM Товары"));
        }
        public static DataTable DBOperation()
        {
            return dtMain;
        }

        public static void Delete(string prod)
        {
            dtMain = Connect.GetTable(Context.baseConnect, String.Format("DELETE FROM Товары WHERE [Код товара] = '{0}%'", prod));
        }

        public static void Insert(string Manufacturer, string Name, string Country, string Supplier, string Animal, string Type, string Price, string Valid, string stock, string Expected)
        {
            dtMain = Connect.GetTable(Context.baseConnect, String.Format("INSERT INTO Товары ([Производитель], [Наименование], [Страна изготовления], [Код поставщика], [Животное], [Код типа], [Цена], [Годен до], [На складе], [Ожидается]) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')", Manufacturer, Name, Country, Supplier, Animal, Type, Price, Valid, stock, Expected));
        }

        public static void Update(string Manufacturer, string Name, string Country, string Supplier, string Animal, string Type, string Price, string Valid, string stock, string Expected)
        {
            dtMain = Connect.GetTable(Context.baseConnect, String.Format("UPDATE Товары SET ([Производитель] = '{0}', [Наименование] = '{1}', [Страна изготовления] = '{2}', [Код поставщика] = '{3}', [Животное] = '{4}', [Код типа] = '{5}', [Цена] = '{6}', [Годен до] = '{7}', [На складе] = '{8}', [Ожидается] = '{9}')", Manufacturer, Name, Country, Supplier, Animal, Type, Price, Valid, stock, Expected));
        }
    }
}

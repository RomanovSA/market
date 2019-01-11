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
    class DataSuppliers
    {
        private static DataTable dtMain = null;

        public static void Load()
        {
            dtMain = Connect.GetTable(Context.baseConnect, String.Format("SELECT * FROM Поставщики"));
        }
        public static DataTable DBOperation()
        {
            return dtMain;
        }

        public static void Delete(string sup)
        {
            dtMain = Connect.GetTable(Context.baseConnect, String.Format("DELETE FROM Поставщики WHERE [Код поставщика] = '{0}%'", sup));
        }

        public static void Insert(string name, string region, string city, string adres, string tel, string email)
        {
            dtMain = Connect.GetTable(Context.baseConnect, String.Format("INSERT INTO Поставщики ([Название], [Область], [Город], [Адрес], [Телефон], [Электронная почта]) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", name, region, city, adres, tel, email));
        }

        public static void Update(string name, string region, string city, string adres, string tel, string email)
        {
            dtMain = Connect.GetTable(Context.baseConnect, String.Format("UPDATE Поставщики SET ([Название] = '{0}', [Область] = '{1}', [Город] = '{2}', [Адрес] = '{3}', [Телефон] = '{4}', [Электронная почта] = '{5}')", name, region, city, adres, tel, email));
        }
    }
}

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
    class DataClient
    {
        private static DataTable dtMain = null;

        public static void Load()
        {
            dtMain = Connect.GetTable(Context.baseConnect, String.Format("SELECT * FROM Клиенты"));
        }
        public static DataTable DBOperation()
        {
            return dtMain;
        }

        public static void Delete(string order)
        {
            dtMain = Connect.GetTable(Context.baseConnect, String.Format("DELETE FROM Клиенты WHERE [Код клиента] = '{0}%'", order));
        }

        //public static void Insert(string customer, string map, string employee, string courier, string accommodation, string purpose, string execution)
        //{
        //    dtMain = Connect.GetTable(Context.baseConnect, String.Format("INSERT INTO Заказы ([ФИО], [Дата рождения], [Номер бонусной карты], [Город], [Улица], [Дом], [Телефон]) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", customer, map, employee, courier, accommodation, purpose, execution));
        //}

        //public static void Update(string customer, string map, string employee, string courier, string accommodation, string purpose, string execution)
        //{
        //    dtMain = Connect.GetTable(Context.baseConnect, String.Format("UPDATE Заказы SET ([ФИО] = '{0}', [Дата рождения] = '{1}', [Номер бонусной карты] = '{2}', [Город] = '{3}', [Улица] = '{4}', [Дом] = '{5}', [Телефон] = '{6}')", customer, map, employee, courier, accommodation, purpose, execution));
        //}
    }
}

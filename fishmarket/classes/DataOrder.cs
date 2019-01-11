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
    class DataOrder
    {
        private static DataTable dtMain = null;

        public static void Load()
        {
            dtMain = Connect.GetTable(Context.baseConnect, String.Format("SELECT * FROM Заказы"));
        }
        public static DataTable DBOperation()
        {
            return dtMain;
        }

        public static void Delete(string order)
        {
            dtMain = Connect.GetTable(Context.baseConnect, String.Format("DELETE FROM Заказы WHERE [Код заказа] = '{0}%'", order));
        }

        public static void Insert(string customer, string map, string employee, string courier, string accommodation, string purpose, string execution)
        {
            dtMain = Connect.GetTable(Context.baseConnect, String.Format("INSERT INTO Заказы ([Код клиента], [Номер карты], [Код сотрудника], [Код курьера], [Дата размещения], [Дата назначения], [Дата исполнения]) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", customer, map, employee, courier, accommodation, purpose, execution));
        }

        public static void Update(string customer, string map, string employee, string courier, string accommodation, string purpose, string execution)
        {
            dtMain = Connect.GetTable(Context.baseConnect, String.Format("UPDATE Заказы SET ([Код клиента] = '{0}', [Номер карты] = '{1}', [Код сотрудника] = '{2}', [Код курьера] = '{3}', [Дата размещения] = '{4}', [Дата назначения] = '{5}', [Дата исполнения] = '{6}')", customer, map, employee, courier, accommodation, purpose, execution));
        }
    }
}

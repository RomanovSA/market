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
    class DatabtProdPoCl
    {
        private static DataTable dtMain = null;

        public static void Load()
        {
            dtMain = Connect.GetTable(Context.baseConnect, String.Format("SELECT Клиенты.ФИО, Count(Заказы.[Код заказа]) AS [Count-Код заказа], " +
                "Avg(Заказано.Всего) AS [Avg-Всего], Sum(Заказано.Всего) AS [Sum-Всего] FROM Клиенты " +
                "INNER JOIN(Заказы INNER JOIN Заказано ON Заказы.[Код заказа] = Заказано.[Код заказа]) ON Клиенты.[Код клиента] = Заказы.[Код клиента] " +
                "GROUP BY Клиенты.ФИО ORDER BY Sum(Заказано.Всего) DESC"));
        }
        public static DataTable DBOperation()
        {
            return dtMain;
        }
    }
}

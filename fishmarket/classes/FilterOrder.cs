using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fishmarket.classes
{
    class FilterOrder
    {
        public string Customer { get; set; }
        public string Manufacturer { get; set; }
        public string Courier { get; set; }

        public string getBindingText()
        {
            string filter = "(([Код заказа] is not null)";
            if (Customer != String.Empty)
            {
                filter += " and ([Код клиента] like '%" + Customer + "%')";
            }
            if (Manufacturer != String.Empty)
            {
                filter += " and ([Код сотрудника] like '%" + Manufacturer + "%')";
            }
            if (Courier != String.Empty)
            {
                filter += " and ([Код курьера] like '%" + Courier + "%')";
            }
            filter += ")";

            return filter;
        }
    }
}

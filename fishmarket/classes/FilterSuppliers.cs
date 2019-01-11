using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fishmarket.classes
{
    class FilterSuppliers
    {
        public string Region { get; set; }
        public string City { get; set; }

        public string getBindingText()
        {
            string filter = "(([Код поставщика] is not null)";
            if (Region != String.Empty)
            {
                filter += " and ([Область] like '%" + Region + "%')";
            }
            if (City != String.Empty)
            {
                filter += " and ([Город] like '%" + City + "%')";
            }
            filter += ")";

            return filter;
        }
    }
}

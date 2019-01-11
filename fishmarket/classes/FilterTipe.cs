using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fishmarket.classes
{
    class FilterTipe
    {
        public string Category { get; set; }
        public string Opisan { get; set; }

        public string getBindingText()
        {
            string filter = "(([Код типа] is not null)";
            if (Category != String.Empty)
            {
                filter += " and ([Категория] like '%" + Category + "%')";
            }
            if (Opisan != String.Empty)
            {
                filter += " and ([Описание] like '%" + Opisan + "%')";
            }
            filter += ")";

            return filter;
        }
    }
}

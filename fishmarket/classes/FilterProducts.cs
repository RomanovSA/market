using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fishmarket.classes
{
    class FilterProducts
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Animal { get; set; }

        public string getBindingText()
        {
            string filter = "(([Код товара] is not null)";
            if (Manufacturer != String.Empty)
            {
                filter += " and ([Производитель] like '%" + Manufacturer + "%')";
            }
            if (Name != String.Empty)
            {
                filter += " and ([Наименование] like '%" + Name + "%')";
            }
            if(Country != String.Empty)
            {
                filter += " and ([Страна изготовления] like '%" + Country + "%')";
            }
            if(Animal != String.Empty)
            {
                filter += " and ([Животное] like '%" + Animal + "%')";
            }
            filter += ")";

            return filter;
        }
    }
}

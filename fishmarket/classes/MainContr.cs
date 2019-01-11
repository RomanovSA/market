using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fishmarket.classes
{
    class MainContr
    {
        public static void TipeForm()
        {
            TipeForm tipeform = new TipeForm();
            tipeform.OpenForm();
            tipeform.ShowDialog();
        }
        public static void ProductForm()
        {
            ProductsForm productsform = new ProductsForm();
            productsform.OpenForm();
            productsform.ShowDialog();
        }
        public static void OrdersForm()
        {
            OrderForm orderform = new OrderForm();
            orderform.OpenForm();
            orderform.ShowDialog();
        }
        public static void ProvidersForm()
        {
            SuppliersForm suppliersform = new SuppliersForm();
            suppliersform.OpenForm();
            suppliersform.ShowDialog();
        }
        public static void RequestForm()
        {
            RequestForm requestform = new RequestForm();
            requestform.ShowDialog();
        }
    }
}

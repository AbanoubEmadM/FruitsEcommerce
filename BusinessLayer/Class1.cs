using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsProduct
    {
        public static DataTable GetAllProducts()
        {
            return clsDataAccessLayer.GetAllProducts();
        }
        public static DataTable GetProductsWithCategory(string Category)
        {
            return clsDataAccessLayer.GetProductsWithCategory(Category);
        }

    }
}

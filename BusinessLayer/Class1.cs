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
        public static bool AddToCart(int UserID, int ProductID)
        {
            return clsDataAccessLayer.AddToCart(UserID, ProductID);
        }
        public static bool RemoveFromCart(int UserID, int ProductID)
        {
            return clsDataAccessLayer.RemoveFromCart(UserID, ProductID);
        }

        public static DataTable GetDataInCart(int UserID)
        {
            return clsDataAccessLayer.GetDataInCart(UserID);

        }
    }
}

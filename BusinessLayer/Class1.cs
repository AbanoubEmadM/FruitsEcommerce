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
        public static bool RemoveFromWishlist(int UserID, int ProductID)
        {
            return clsDataAccessLayer.RemoveFromWishlist(UserID, ProductID);
        }

        public static DataTable GetDataInCart(int UserID)
        {
            return clsDataAccessLayer.GetDataInCart(UserID);
        }
        public static DataTable GetDataInWishlist(int UserID)
        {
            return clsDataAccessLayer.GetDataInWishlist(UserID);
        }

        public static bool Login(string Email, string Password)
        {
            return clsDataAccessLayer.Login(Email, Password);
        }
        public static int GetUserID(string Email, string Password)
        {
            return clsDataAccessLayer.GetUserID(Email, Password);
        }
        public static string GetUserName(string Email, string Password)
        {
            return clsDataAccessLayer.GetUserName(Email, Password);
        }

    }
}

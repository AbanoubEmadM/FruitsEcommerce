using ContactsDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace DataAccessLayer
{
    public class clsDataAccessLayer
    {
        public static DataTable GetAllProducts()
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT * FROM Products";
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query,connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Handle exception
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }
        public static DataTable GetProductsWithCategory(string Category)
        {
            DataTable dataTable = new DataTable();

            string query = $"SELECT * FROM Products WHERE CategoryID = (SELECT ID FROM Categories WHERE Name = @Category)";

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            
            SqlCommand command = new SqlCommand(query, connection);
            
            command.Parameters.AddWithValue("@Category", Category);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Handle exception
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }
        public static bool AddToCart(int UserID, int ProductID)
        {
            bool isAdded = false;

            string query = "INSERT INTO AddedToCart(UserID, ProductID) VALUES (@UserID, @ProductID)";
            
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@ProductID", ProductID);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    isAdded = true;
                }
                else
                {
                    isAdded = false;
                }
            }
            catch (Exception ex)
            {
                isAdded = false;
            }
            finally
            {
                connection.Close();
            }
            return isAdded;
        }
        public static DataTable GetDataInCart(int UserID)
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT Products.Name, Products.ImagePath, Products.Price, Products.ID FROM Users INNER JOIN AddedToCart ON Users.ID = AddedToCart.UserID INNER JOIN Products ON AddedToCart.ProductID = Products.ID Where Users.ID = @UserID";
            
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Handle exception
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dataTable;

        }
        public static DataTable GetDataInWishlist(int UserID)
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT Products.Name, Products.ImagePath, Products.Price FROM Users INNER JOIN AddedToWishlist ON Users.ID = AddedToWishlist.UserID \r\nINNER JOIN Products ON AddedToWishlist.ProductID = Products.ID\r\n Where Users.ID = @UserID";

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Handle exception
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dataTable;

        }
        public static bool RemoveFromCart(int UserID, int ProductID)
        {
            bool isRemoved = false;

            string query = "Delete From AddedToCart Where AddedToCart.UserID = @UserID And AddedToCart.ProductID = @ProductID";

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@ProductID", ProductID);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    isRemoved = true;
                }
                else
                {
                    isRemoved = false;
                }
            }
            catch (Exception ex)
            {
                isRemoved = false;
            }
            finally
            {
                connection.Close();
            }
            return isRemoved;

        }
        public static bool Login(string Email, string Password)
        {
            bool isLogged = false;

            string query = "Select Name From Users Where Email = @Email And Password = @Password";

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    isLogged = true;
                }
                else
                {
                    isLogged = false;
                }
            }
            catch (Exception ex)
            {
                isLogged = false;
            }
            finally
            {
                connection.Close();
            }
            return isLogged;
        }
        public static int GetUserID(string Email, string Password)
        {
            int ID = -1;

            string query = "Select ID From Users Where Email = @Email And Password = @Password";

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    ID = Convert.ToInt32(result);
                }
                else
                {
                    ID = -1;
                }
            }
            catch (Exception ex)
            {
                ID = -1;
            }
            finally
            {
                connection.Close();
            }
            return ID;
        }
        public static string GetUserName(string Email, string Password)
        {
            string Name = String.Empty;

            string query = "Select Name From Users Where Email = @Email And Password = @Password";

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    Name = result.ToString();
                }
                else
                {
                    Name = String.Empty;
                }
            }
            catch (Exception ex)
            {
                Name = String.Empty;
            }
            finally
            {
                connection.Close();
            }
            return Name;
        }

    }
}

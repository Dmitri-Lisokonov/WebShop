using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WebShop.Models;

namespace WebShop.Data
{
    class MSSQLContextProduct : IProductContext
    {
        public MSSQLContextProduct()
        {

        }
        public Product SearchByProductName(string productName)
        {

            Product result = new Product();

            using (SqlConnection connection = DatabaseConnection.OpenConnection())
            {
                string query = "SELECT * FROM Product WHERE ProductName = @ProductName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductName", productName);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();

                        result = new Product(Convert.ToInt32(reader["ProductID"]), reader["ProductName"].ToString(), reader["Discription"].ToString(), Convert.ToInt32(reader["SerialNumber"]), reader["Sizing"].ToString(), reader["ColorWay"].ToString(), reader["categoryName"].ToString(), reader["BrandName"].ToString(), Convert.ToInt32(reader["Price"]));
                    }
                }
            }
            return result;
        }

        public List<Product> GetAll()
        {
            List<Product> result = new List<Product>();
            using (SqlConnection connection = DatabaseConnection.OpenConnection())
            {
                string query = "SELECT * FROM Product ORDER BY ProductName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new Product(Convert.ToInt32(reader["ProductID"]), reader["ProductName"].ToString(), reader["Discription"].ToString(), Convert.ToInt32(reader["SerialNumber"]), reader["Sizing"].ToString(), reader["ColorWay"].ToString(), reader["categoryName"].ToString(), reader["BrandName"].ToString(), Convert.ToInt32(reader["Price"])));
                        }
                    }
                }
            }
            return result;
        }

        public Product GetProduct(int ProductId)
        {
            Product result = new Product();

            using (SqlConnection connection = DatabaseConnection.OpenConnection())
            {
                string query = "SELECT * FROM Product WHERE ProductID = @ProductID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductID", ProductId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();

                        result = new Product(Convert.ToInt32(reader["ProductID"]), reader["ProductName"].ToString(), reader["Discription"].ToString(), Convert.ToInt32(reader["SerialNumber"]), reader["Sizing"].ToString(), reader["ColorWay"].ToString(), reader["categoryName"].ToString(), reader["BrandName"].ToString(), Convert.ToInt32(reader["Price"]));
                    }
                }
            }
            return result;
        }

        public bool Insert(Product Product)
        {
            bool result = false;

            using (SqlConnection connection = DatabaseConnection.OpenConnection())
            {
                string query = "INSERT INTO Customer (Username, Password, CstreetNumber, Cstreet, CCity, CPostalCode, CCountry, PaymentMethod) VALUES (@Username, @Password, @CstreetNumber, @Cstreet, @CCity, @CPostalCode, @CCountry, @PaymentMethod)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@ProductName", Product.productName);
                    command.Parameters.AddWithValue("@Discription", Product.discription);
                    command.Parameters.AddWithValue("@SerialNumber", Product.serialNumber);
                    command.Parameters.AddWithValue("@Sizing", Product.sizing);
                    command.Parameters.AddWithValue("@ColorWay", Product.colorway);
                    command.Parameters.AddWithValue("@Brand", Product.brandName);
                    command.Parameters.AddWithValue("@Price", Product.price);
                    command.Parameters.AddWithValue("@CategoryName", Product.categoryName);

                    if (command.ExecuteNonQuery() == 1)
                    {
                        result = true;
                    }
                }
            }
            return result;
        }

        public bool Delete(Product product)
        {
            bool result = false;

            using (SqlConnection connection = DatabaseConnection.OpenConnection())
            {
                string query = "DELETE FROM Product WHERE ProductID = @ProductID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", product.productId);

                    if (command.ExecuteNonQuery() == 1)
                    {
                        result = true;
                    }
                }
            }
            return result;
        }

        public bool Update(Product Product)
        {
            bool result = false;

            using (SqlConnection connection = DatabaseConnection.OpenConnection())
            {
                string query = "UPDATE Customer SET Username = @Username, Password = @Password, CstreetNumber = @CstreetNumber, Cstreet = @Cstreet, CCity = @CCity, CpostalCode = @CPostalCode, CCountry = @CCountry, PaymentMethod = @PaymentMethod WHERE CustomerID = @CustomerID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductName", Product.productName);
                    command.Parameters.AddWithValue("@Discription", Product.discription);
                    command.Parameters.AddWithValue("@SerialNumber", Product.serialNumber);
                    command.Parameters.AddWithValue("@Sizing", Product.sizing);
                    command.Parameters.AddWithValue("@ColorWay", Product.colorway);
                    command.Parameters.AddWithValue("@Brand", Product.brandName);
                    command.Parameters.AddWithValue("@Price", Product.price);
                    command.Parameters.AddWithValue("@CategoryName", Product.categoryName);

                    if (command.ExecuteNonQuery() == 1)
                    {
                        result = true;
                    }
                }
            }
            return result;
        }
    }
}

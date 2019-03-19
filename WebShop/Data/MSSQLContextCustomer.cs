using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WebShop.Models;

namespace WebShop.Data
{
    class MSSQLcontextCustomer : ICustomerContext
    {
        public MSSQLcontextCustomer()
        {
            
        }
        public Customer Login(string username)
        {

            Customer result = new Customer();

            using (SqlConnection connection = DatabaseConnection.OpenConnection())
            {
                string query = "SELECT * FROM Customer WHERE Username = @Username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();

                        result = new Customer(Convert.ToInt32(reader["CustomerID"]), reader["Username"].ToString(), reader["Password"].ToString(), Convert.ToInt32(reader["CstreetNumber"]), reader["Cstreet"].ToString(), reader["CCity"].ToString(), reader["CPostalCode"].ToString(), reader["CCountry"].ToString(), reader["PaymentMethod"].ToString());
                    }
                }
            }
                return result;
        }

        public List<Customer> GetAll()
        {
            List<Customer> result = new List<Customer>();
            using (SqlConnection connection = DatabaseConnection.OpenConnection())
            {
                string query = "SELECT * FROM Customer ORDER BY username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new Customer(Convert.ToInt32(reader["CustomerID"]), reader["Username"].ToString(), reader["Password"].ToString(), Convert.ToInt32(reader["CstreetNumber"]), reader["Cstreet"].ToString(), reader["CCity"].ToString(), reader["CPostalCode"].ToString(), reader["CCountry"].ToString(), reader["PaymentMethod"].ToString()));
                        }
                    }
                }
            }
            return result;
        }

        public Customer Get(int CustomerID)
        {
            Customer result = new Customer();

            using (SqlConnection connection = DatabaseConnection.OpenConnection())
            {
                string query = "SELECT * FROM Customer WHERE CustomerID = @CustomerID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", CustomerID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();

                       result = new Customer(Convert.ToInt32(reader["CustomerID"]), reader["Username"].ToString(), reader["Password"].ToString(), Convert.ToInt32(reader["CstreetNumber"]), reader["Cstreet"].ToString(), reader["CCity"].ToString(), reader["CPostalCode"].ToString(), reader["CCountry"].ToString(), reader["PaymentMethod"].ToString());
                    }
                }
            }
            return result;
        }

        public bool Insert(Customer customer)
        {
            bool result = false;

            using (SqlConnection connection = DatabaseConnection.OpenConnection())
            {
                string query = "INSERT INTO Customer (Username, Password, CstreetNumber, Cstreet, CCity, CPostalCode, CCountry, PaymentMethod) VALUES (@Username, @Password, @CstreetNumber, @Cstreet, @CCity, @CPostalCode, @CCountry, @PaymentMethod)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    command.Parameters.AddWithValue("@Username", customer.username );
                    command.Parameters.AddWithValue("@Password", customer.password);
                    command.Parameters.AddWithValue("@CstreetNumber", customer.streetNumber);
                    command.Parameters.AddWithValue("@Cstreet", customer.streetName);
                    command.Parameters.AddWithValue("@CCity", customer.city);
                    command.Parameters.AddWithValue("@CPostalCode", customer.postalCode);
                    command.Parameters.AddWithValue("@CCountry", customer.country);
                    command.Parameters.AddWithValue("@PaymentMethod", customer.paymentMethod);            

                    if (command.ExecuteNonQuery() == 1)
                    {
                        result = true;
                    }
                }
            }
            return result;
        }

        public bool Delete(Customer customer)
        {
            bool result = false;

            using (SqlConnection connection = DatabaseConnection.OpenConnection())
            {
                string query = "DELETE FROM Customer WHERE CustomerID = @CustomerID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customer.customerId);

                    if (command.ExecuteNonQuery() == 1)
                    {
                        result = true;
                    }
                }
            }
            return result;
        }

        public bool Update(Customer customer)
        {
            bool result = false;

            using (SqlConnection connection = DatabaseConnection.OpenConnection())
            {
                string query = "UPDATE Customer SET Username = @Username, Password = @Password, CstreetNumber = @CstreetNumber, Cstreet = @Cstreet, CCity = @CCity, CpostalCode = @CPostalCode, CCountry = @CCountry, PaymentMethod = @PaymentMethod WHERE CustomerID = @CustomerID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", customer.username);
                    command.Parameters.AddWithValue("@Password", customer.password);
                    command.Parameters.AddWithValue("@CstreetNumber", customer.streetNumber);
                    command.Parameters.AddWithValue("@Cstreet", customer.streetName);
                    command.Parameters.AddWithValue("@CCity", customer.city);
                    command.Parameters.AddWithValue("@CpostalCode", customer.postalCode);
                    command.Parameters.AddWithValue("@CCountry", customer.country);
                    command.Parameters.AddWithValue("@PaymentMethod", customer.paymentMethod);

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

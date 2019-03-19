using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WebShop.Models;

namespace WebShop.Data
{
    class MSSQLcontextAccount : IAccountContext
    {
        public MSSQLcontextAccount()
        {
            
        }
        public Account searchByUserName(string username)
        {

            Account result = new Account();

            using (SqlConnection connection = DatabaseConnection.OpenConnection())
            {
                string query = "SELECT * FROM Customer WHERE Username = @Username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();

                        result = new Account(Convert.ToInt32(reader["CustomerID"]), reader["Username"].ToString(), reader["Password"].ToString(), Convert.ToInt32(reader["CstreetNumber"]), reader["Cstreet"].ToString(), reader["CCity"].ToString(), reader["CPostalCode"].ToString(), reader["CCountry"].ToString(), reader["PaymentMethod"].ToString());
                    }
                }
            }
                return result;
        }

        public List<Account> GetAll()
        {
            List<Account> result = new List<Account>();
            using (SqlConnection connection = DatabaseConnection.OpenConnection())
            {
                string query = "SELECT * FROM Customer ORDER BY username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new Account(Convert.ToInt32(reader["CustomerID"]), reader["Username"].ToString(), reader["Password"].ToString(), Convert.ToInt32(reader["CstreetNumber"]), reader["Cstreet"].ToString(), reader["CCity"].ToString(), reader["CPostalCode"].ToString(), reader["CCountry"].ToString(), reader["PaymentMethod"].ToString()));
                        }
                    }
                }
            }
            return result;
        }

        public Account GetCustomer(int CustomerID)
        {
            Account result = new Account();

            using (SqlConnection connection = DatabaseConnection.OpenConnection())
            {
                string query = "SELECT * FROM Customer WHERE CustomerID = @CustomerID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", CustomerID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();

                       result = new Account(Convert.ToInt32(reader["CustomerID"]), reader["Username"].ToString(), reader["Password"].ToString(), Convert.ToInt32(reader["CstreetNumber"]), reader["Cstreet"].ToString(), reader["CCity"].ToString(), reader["CPostalCode"].ToString(), reader["CCountry"].ToString(), reader["PaymentMethod"].ToString());
                    }
                }
            }
            return result;
        }

        public bool Insert(Account account)
        {
            bool result = false;

            using (SqlConnection connection = DatabaseConnection.OpenConnection())
            {
                string query = "INSERT INTO Customer (Username, Password, CstreetNumber, Cstreet, CCity, CPostalCode, CCountry, PaymentMethod) VALUES (@Username, @Password, @CstreetNumber, @Cstreet, @CCity, @CPostalCode, @CCountry, @PaymentMethod)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    command.Parameters.AddWithValue("@Username", account.username );
                    command.Parameters.AddWithValue("@Password", account.password);
                    command.Parameters.AddWithValue("@CstreetNumber", account.streetNumber);
                    command.Parameters.AddWithValue("@Cstreet", account.streetName);
                    command.Parameters.AddWithValue("@CCity", account.city);
                    command.Parameters.AddWithValue("@CPostalCode", account.postalCode);
                    command.Parameters.AddWithValue("@CCountry", account.country);
                    command.Parameters.AddWithValue("@PaymentMethod", account.paymentMethod);            

                    if (command.ExecuteNonQuery() == 1)
                    {
                        result = true;
                    }
                }
            }
            return result;
        }

        public bool Delete(Account customer)
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

        public bool Update(Account account)
        {
            bool result = false;

            using (SqlConnection connection = DatabaseConnection.OpenConnection())
            {
                string query = "UPDATE Customer SET Username = @Username, Password = @Password, CstreetNumber = @CstreetNumber, Cstreet = @Cstreet, CCity = @CCity, CpostalCode = @CPostalCode, CCountry = @CCountry, PaymentMethod = @PaymentMethod WHERE CustomerID = @CustomerID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", account.username);
                    command.Parameters.AddWithValue("@Password", account.password);
                    command.Parameters.AddWithValue("@CstreetNumber", account.streetNumber);
                    command.Parameters.AddWithValue("@Cstreet", account.streetName);
                    command.Parameters.AddWithValue("@CCity", account.city);
                    command.Parameters.AddWithValue("@CpostalCode", account.postalCode);
                    command.Parameters.AddWithValue("@CCountry", account.country);
                    command.Parameters.AddWithValue("@PaymentMethod", account.paymentMethod);

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

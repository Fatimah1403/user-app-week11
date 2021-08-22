using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;
// using ManagementApp.DataStorage;




namespace ManagementApp.DataStorage
{
    public class ADO
    {
        private const string ConnectionString = @"Data Source=  DESKTOP-MB66D5H;Initial Catalog=WomenTechsters;Integrated Security=True";

        public async Task<bool> InsertIntoCustomerActions(string firstName, string lastName, string email, string password, string otherName)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString: ConnectionString);
                await connection.OpenAsync();
                string query = $"INSERT INTO CustomerActions VALUES ('{firstName}', '{lastName}', '{email}', '{otherName}')";

                SqlCommand command = new SqlCommand(query, connection);
                var rows = await command.ExecuteNonQueryAsync();
                await connection.CloseAsync();

                return rows > 0;
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
            


        }
        public async Task<bool> UpdateCustomerActions(string firstName, string lastName, string email, string password, string otherName)
        {
            try
            {
                var connection = CreateConnection();
                await connection.OpenAsync();

                string query = "UPDATE CustomerActions SET LastName = @lastaName, FirstName = @firstName,  WHERE Id = @Id";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.Add("LastName", SqlDbType.VarChar).Value = lastName;
                command.Parameters.Add("FirstName", SqlDbType.VarChar).Value = firstName;
                command.Parameters.Add("Id", SqlDbType.Int).Value = 4;

                var rows = await command.ExecuteNonQueryAsync();

                return rows > 0;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            
        }
        public async Task<List<Customers>> ReadFromDatabase()
        {
            try
            {
                var connection = CreateConnection();
                await connection.OpenAsync();

                string query = "SELECT * FROM CustomerActions";

                SqlCommand command = new SqlCommand(query, connection);

                var reader = await command.ExecuteReaderAsync();

                List<Customers> customer = new List<Customers>();

                while (reader.Read())
                {
                    var Customers = new Customers
                    {
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        Email = reader["Email"].ToString(),
                        Password = reader["Password"].ToString(),
                        Id = Convert.ToInt32(reader["Id"])
                    };

                    //  Customers.Add(customer);

                }

                return customer;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
           

        }

        public async Task<bool> InsertUsingtoredProcedures(string firstName, string lastName, string email, string password, string otherName)
        {
            try
            {
                var connection = CreateConnection();
                await connection.OpenAsync();

                string query = "INSERTINTOCUSTOMERACTIONS";

                SqlCommand command = new SqlCommand(query, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.Add("FirstName", SqlDbType.VarChar).Value = firstName;
                command.Parameters.Add("LastName", SqlDbType.VarChar).Value = lastName;
                command.Parameters.Add("Password", SqlDbType.VarChar).Value = password;

                var rows = await command.ExecuteNonQueryAsync();

                return rows > 0; 
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
           
        }
        private SqlConnection CreateConnection()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            return connection;
        }








    }

}
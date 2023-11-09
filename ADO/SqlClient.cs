using Microsoft.Data.SqlClient;
using System.Data;

namespace ADO
{
    public class SqlClient
    {
        public static string ConnectionStringBuilderWorking(string connectionString)
        {
            SqlConnectionStringBuilder builder = new(connectionString);
            if (!builder.TrustServerCertificate)
            {
                builder.TrustServerCertificate = true;
            }
            return builder.ToString();
        }

        public static async Task<bool> TestConnectionAsync(string connectionString)
        {
            connectionString = ConnectionStringBuilderWorking(connectionString);

            using SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                await sqlConnection.OpenAsync().ConfigureAwait(false);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static async Task<DataSet> GetDataSetCoreAsync(string connectionString, string query)
        {
            connectionString = ConnectionStringBuilderWorking(connectionString);
            using SqlConnection connection = new SqlConnection(connectionString);

            using SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = query;
            
            using SqlDataAdapter adapter = new SqlDataAdapter(command);
            using DataSet dataSet = new DataSet();
            try
            {
                await connection.OpenAsync().ConfigureAwait(false);
                adapter.Fill(dataSet);
                return dataSet;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// Add "TrustServerCertificate=True;" in Connection String because Microsoft.Data.SqlClient need this =))
        /// <br/>
        /// Add thêm "Encrypt=True;" cho xịn
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="query"></param>
        /// <returns></returns>
        public static async Task<DataTable> GetDataAsync(string connectionString, string query)
        {
            DataSet dataSet = await GetDataSetCoreAsync(connectionString, query).ConfigureAwait(false);
            if (dataSet!=null && dataSet.Tables.Count > 0)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return new DataTable();
            }
        }
    }
}
namespace ADO
{
    public class OracleClient
    {
        public static async Task<bool> TestConnectionAsync(string connectionString)
        {
            using Oracle.ManagedDataAccess.Client.OracleConnection connection = new(connectionString);
            try
            {
                await connection.OpenAsync().ConfigureAwait(false);
                return true;
            }
            catch
            {

            }
            return false;
        }

        public static async Task<bool> TestConnectionAsync(string IP, string port, string DBname, string username, string password)
        {
            Oracle.ManagedDataAccess.Client.OracleConnectionStringBuilder builder = new();
            builder.DataSource = $"{IP}:{port}/{DBname}";
            builder.UserID = username;
            builder.Password = password;

            string connectionString = builder.ConnectionString;

            return await TestConnectionAsync(connectionString).ConfigureAwait(false);

        }

        public static async Task<DataTable> GetDataTableAsync(string connectionString, string query)
        {
            DataTable dataTable = new();
            using Oracle.ManagedDataAccess.Client.OracleConnection connection = new(connectionString);
            using Oracle.ManagedDataAccess.Client.OracleDataAdapter adapter = new(query, connectionString);
            try
            {
                await connection.OpenAsync().ConfigureAwait(false);
                adapter.Fill(dataTable);
                return dataTable;
            }
            catch
            {

            }
            return dataTable;
        }
    }
}

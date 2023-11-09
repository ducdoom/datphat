namespace ADO.Database
{
    public static class Funcs
    {
        public static List<string> GetDatabaseNames(DBProvider.Provider dBProvider, string connectionString)
        {
            List<string> databaseNames = new List<string>();
            DataTable dt = new();

            switch (dBProvider)
            {
                case DBProvider.Provider.SQLServer:
                    databaseNames = GetSQLDatabaseName(connectionString);
                    break;
                case DBProvider.Provider.OracleServer:

                    break;
            }


            return databaseNames;
        }

        private static List<string> GetSQLDatabaseName(string connectionString)
        {
            List<string> output = new List<string>();
            using Microsoft.Data.SqlClient.SqlConnection connection = new(connectionString);
            using Microsoft.Data.SqlClient.SqlCommand command = new("select name from sys.databases order by name", connection);

            connection.Open();

            using Microsoft.Data.SqlClient.SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                output.Add(sqlDataReader.GetString(0));
            }

            return output;
        }
    }
}

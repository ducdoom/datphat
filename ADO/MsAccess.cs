using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace ADO
{
    public class MsAccess
    {
        public static async Task ExecuteQueryAccessFileAsync(string fileName, string query)
        {
            using OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;" +
                                            $"Data Source={fileName};" +
                                            $"Persist Security Info=False;";
            using OleDbCommand command = new OleDbCommand();
            command.CommandText = query;
            command.Connection = connection;
            await connection.OpenAsync().ConfigureAwait(false);
            await command.ExecuteNonQueryAsync().ConfigureAwait(false);
        }
    }
}

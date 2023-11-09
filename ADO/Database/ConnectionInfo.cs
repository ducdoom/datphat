namespace ADO.Database
{
    public class ConnectionInfo
    {
        private DBProvider.Provider? _provider = DBProvider.Provider.SQLServer;


        public ADO.Database.DBProvider.Provider? Provider { get => _provider; set => _provider = value; }
        public string? Zone { get; set; }
        public string? IP { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Database { get; set; }
        public string? ConnectionString
        {
            get
            {
                return BuildConnectionString((DBProvider.Provider)_provider);
            }
        }

        private string BuildConnectionString(ADO.Database.DBProvider.Provider provider)
        {
            string output = string.Empty;
            switch (provider)
            {
                case DBProvider.Provider.SQLServer:
                    Microsoft.Data.SqlClient.SqlConnectionStringBuilder buider = new();
                    buider.DataSource = IP;
                    buider.UserID = Username;
                    buider.Password = Password;
                    buider.InitialCatalog = Database;
                    output = ADO.SqlClient.ConnectionStringBuilderWorking(buider.ConnectionString);
                    break;

                case DBProvider.Provider.OracleServer:
                    break;
            }

            return output;
        }


    }
}

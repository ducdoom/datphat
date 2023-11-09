using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace AccountingDP.Services
{
    public static class VietseaService
    {
        //Scaffold-DbContext "Data Source=192.168.0.50:1522/TBNETERP;User Id=TBNETERP;Password=TBNETERP" Oracle.EntityFrameworkCore -OutputDir EF/Models/VietseaModel -Table DMKHACHHANG


        //private static EF.Models.VietseaModel.ModelContext vietseaContext = new();

        public static async Task<List<Models.XNTDto>> getNXT(DateTime dateTime)
        {
            string? connectionString = ConfigurationManager.AppSettings["OracleConnectionString"];
            using Oracle.ManagedDataAccess.Client.OracleConnection connection = new(connectionString);
            string sql = "select * from XNT_11112032 where TONDAUKYSL >0";
            var list = await connection.QueryAsync<Models.XNTDto>(sql).ConfigureAwait(false);
            List<Models.XNTDto> result = list.OrderBy(x => x.Tondaukysl).ToList();
            return result;

        }
    }
}

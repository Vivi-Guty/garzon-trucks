using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Entities
{
    public class DataServiceFactory
    {
        private readonly string connectionString;

        public DataServiceFactory(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentNullException(nameof(connectionString));
            }
            this.connectionString = connectionString;
        }

        public InsurancesDataService CreateDataService()
        {
            return new InsurancesDataService(connectionString, "System.Data.SqlClient");
        }
    }
}

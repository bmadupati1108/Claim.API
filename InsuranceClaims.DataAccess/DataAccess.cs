using CsvHelper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceClaims.DataAccess
{
    public class DataAccess : IDataAccess
    {
        private IConfiguration _configuration;

        public DataAccess(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<IEnumerable<T>> Get<T>()
        {
            IEnumerable<T> records;
            using (var reader = new StreamReader(_configuration[typeof(T).Name]))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                records = await Task.Run(() => csv.GetRecords<T>().ToList());

            }
            return records;
        }
    }
}

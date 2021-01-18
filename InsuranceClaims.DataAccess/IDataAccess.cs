using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceClaims.DataAccess
{
    public interface IDataAccess
    {
        Task<IEnumerable<T>> Get<T>();
    }
}

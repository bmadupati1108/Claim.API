using InsuranceClaims.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceClaims.DataAccess
{
    public interface IClaimRepository
    {
        Task<IEnumerable<Claim>> GetClaimsTillDate(DateTime dateTime);
    }
}

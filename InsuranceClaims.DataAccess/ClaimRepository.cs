using InsuranceClaims.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceClaims.DataAccess
{
    public class ClaimRepository : IClaimRepository
    {
        private IDataAccess _dataAccess;

        public ClaimRepository(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public async Task<IEnumerable<Claim>> GetClaimsTillDate(DateTime dateTime)
        {
            var claims = await _dataAccess.Get<Claim>();
            return claims.Where(x => x.ClaimDate <= dateTime);
        }
    }
}

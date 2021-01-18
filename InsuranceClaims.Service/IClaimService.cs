using InsuranceClaims.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceClaims.Service
{
    public interface IClaimService
    {
        Task<IEnumerable<MemberClaims>> GetMemberClaims(DateTime dateTime);
    }
}

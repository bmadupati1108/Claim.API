using InsuranceClaims.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceClaims.DataAccess
{
    public interface IMemberRepository
    {
        Task<IEnumerable<Member>> GetMembers();
    }
}

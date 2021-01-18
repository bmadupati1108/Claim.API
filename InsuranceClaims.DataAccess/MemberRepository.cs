using InsuranceClaims.Common;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace InsuranceClaims.DataAccess
{
    public class MemberRepository:IMemberRepository
    {
        private IDataAccess _dataAccess;

        public MemberRepository(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public async Task<IEnumerable<Member>> GetMembers()
        {
            return await _dataAccess.Get<Member>();
        }
    }
}

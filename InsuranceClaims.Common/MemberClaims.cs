using System;
using System.Collections.Generic;
using System.Text;

namespace InsuranceClaims.Common
{
    public class MemberClaims:Member
    {
        public List<ClaimBase> Claims
        {
            get; set;
        }
    }
}

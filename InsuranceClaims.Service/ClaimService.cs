using InsuranceClaims.Common;
using InsuranceClaims.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceClaims.Service
{
    public class ClaimService : IClaimService
    {
        private IMemberRepository _memberRepository;
        private IClaimRepository _claimRepository;

        public ClaimService(IMemberRepository memberRepository,IClaimRepository claimRepository)
        {
            _memberRepository = memberRepository;
            _claimRepository = claimRepository;
        }
        public  async  Task<IEnumerable<MemberClaims>> GetMemberClaims(DateTime dateTime)
        {
            var claims = await _claimRepository.GetClaimsTillDate(dateTime);
            var members = await _memberRepository.GetMembers();
            return from m in members.ToList()
                   join c in claims.ToList()
                   on m.MemberID equals c.MemberID
                   select new { m, c } into j
                   group new { j } by new { j.m.FirstName, j.m.LastName, j.m.EnrollmentDate, j.c.MemberID } into membergroup
                   select new MemberClaims
                   {
                       MemberID = membergroup.Key.MemberID,
                       FirstName = membergroup.Key.FirstName,
                       LastName = membergroup.Key.LastName,
                       EnrollmentDate = membergroup.Key.EnrollmentDate,
                       Claims = membergroup.Select(y => new ClaimBase { ClaimAmount = y.j.c.ClaimAmount, ClaimDate = y.j.c.ClaimDate }).ToList()
                   };
          
        }
    }
}

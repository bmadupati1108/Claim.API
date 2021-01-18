using System;

namespace InsuranceClaims.Common
{
    public class ClaimBase
    {
        public DateTime ClaimDate { get; set; }
        public decimal ClaimAmount { get; set; }
    }
}

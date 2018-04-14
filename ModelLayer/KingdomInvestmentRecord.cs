using System;

namespace ModelLayer
{
    public class KingdomInvestmentRecord
    {
        public int Id { get; set; }
        public long MemberId { get; set; }
        public decimal AmountReceived { get; set; }
        public DateTime DateOfPayment { get; set; }
        public string Description { get; set; }

    }
}
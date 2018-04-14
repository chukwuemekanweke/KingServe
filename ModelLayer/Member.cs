using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelLayer
{
    public class Member
    {
        public long Id { get; set; }
        [Required]
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string EmailAddress { get; set; }
        public string EmailAddress2 { get; set; }
        public long? MVPId { get; set; }
        public long? FamilyId { get; set; }

        public ICollection<Family> Families { get; set; }
        public ICollection<CellCenter> CellCenters { get; set; }
        public ICollection<KingdomInvestmentRecord> KingdomInvestmentRecords { get; set; }

    }
}

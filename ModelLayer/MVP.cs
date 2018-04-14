using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelLayer
{
    public class MVP
    {
        public long Id { get; set; }
        [Required]
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string ResidentialAddress { get; set; }
        [Required]
        public int NationalityId { get; set; }
        [Required]
        public int StateId { get; set; }
        public string LocalGovernmentArea { get; set; }
    }
}

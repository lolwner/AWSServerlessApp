using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AWSAPP.Entities.Entities
{
    [Table("Clients")]
    public class Client : BaseEntity
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string PostAddress { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        public bool HasFlag { get; set; }
        public string FlagNote { get; set; }
        public DateTime? FlagDate { get; set; }
        public string FacebookId { get; set; }
    }
}

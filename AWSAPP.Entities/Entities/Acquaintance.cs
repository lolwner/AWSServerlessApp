using AWSAPP.Shared.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AWSAPP.Entities.Entities
{
    [Table("Acquaintances")]
    public class Acquaintance : BaseEntity
    {
        [Required]
        public long ClientId { get; set; }
        [ForeignKey("ClientId")]
        public Client Client { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public RelationTypeView RelationType { get; set; }

        public string RelationNote { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}

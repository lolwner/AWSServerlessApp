using System;
using System.ComponentModel.DataAnnotations;

namespace AWSAPP.Entities.Entities
{
    public class BaseEntity
    {
        [Required]
        public long Id { get; set; }

        public DateTime CreationDate { get; set; }

        public BaseEntity()
        {
            CreationDate = DateTime.Now;
        }
    }
}

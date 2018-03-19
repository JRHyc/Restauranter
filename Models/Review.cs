using System;
using System.ComponentModel.DataAnnotations;
namespace Restauranter.Models
{
    public abstract class BaseEntity { }
    public class Review : BaseEntity
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MinLength(2, ErrorMessage="Name must contain at least two letters")]
        public string Name { get; set; }

        [Required]
        [MinLength(2, ErrorMessage="Restaurant name must be at least two letters")]
        public string Restaurant_Name { get; set; }

        [Required]
        [MinLength(5)]
        public string Content { get; set; }

        public int Rating { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [PastDate(ErrorMessage="Date cannot be in the past")]
        public DateTime Date { get; set; }

        // public System.DateTime Created_at {get;set;}
        // public System.DateTime Updated_at {get;set;}
        
    }
}

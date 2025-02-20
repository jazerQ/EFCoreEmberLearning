using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreEmber.Model
{
    public class Player
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(50)]
        [Required]
        public string Username { get; set; } = string.Empty;
        [MaxLength(50)]
        [Required]
        public string Name { get; set; } = string.Empty;
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        public Guid AddressId { get; set; } 
        [ForeignKey("AddressId")]
        public Address? Address { get; set; }

    }
}

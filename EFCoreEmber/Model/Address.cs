using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreEmber.Model
{
    public class Address
    {
        [Key]
        public Guid AddressId { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string City { get; set; } = string.Empty;
        [StringLength(50, MinimumLength = 3)]
        public string Region { get; set; } = string.Empty;
        [StringLength(50, MinimumLength = 3)]
        public string Street { get; set; } = string.Empty;
    }
}

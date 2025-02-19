using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreEmber.Model
{
    public class Player
    {
        public Guid Id { get; set; }
        [MaxLength(50)]
        public string Username { get; set; } = string.Empty;
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

    }
}

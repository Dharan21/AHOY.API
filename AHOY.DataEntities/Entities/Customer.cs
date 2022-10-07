using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOY.DataEntities.Entities
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150)]
        public string Email { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        [MaxLength(500)]
        public string Address { get; set; } = string.Empty;
        [MaxLength(50)]
        public string City { get; set; } = string.Empty;
        [MaxLength(50)]
        public string State { get; set; } = string.Empty;
        [MaxLength(10)]
        public string Pincode { get; set; } = string.Empty;
        public ICollection<Booking>? Bookings { get; set; }
    }
}

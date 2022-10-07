using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOY.DataEntities.Entities
{
    public class HotelRoom
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Hotel")]
        public int HotelId { get; set; }
        public int Quantity { get; set; } = 0;
        public string Description { get; set; } = string.Empty;
        public decimal PricePerDay { get; set; }
        [ForeignKey("HotelId")]
        public Hotel? Hotel { get; set; }
        public ICollection<Booking>? Bookings { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOY.BusinessEntities
{
    public class HotelRoomViewModel
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public int Quantity { get; set; } = 0;
        public string Description { get; set; } = string.Empty;
        public decimal PricePerDay { get; set; }
        public IEnumerable<BookingViewModel>? Bookings { get; set; }
    }
}

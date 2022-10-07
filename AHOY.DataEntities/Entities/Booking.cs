using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOY.DataEntities.Entities
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("HotelRoom")]
        public int RoomId { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        [ForeignKey("RoomId")]
        public HotelRoom? HotelRoom { get; set; }
        [ForeignKey("CustomerId")]
        public Customer? Customer { get; set; }
    }
}

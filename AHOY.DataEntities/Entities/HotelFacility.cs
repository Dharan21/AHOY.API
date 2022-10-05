using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOY.DataEntities.Entities
{
    public class HotelFacility
    {
        public HotelFacility()
        {
            Hotels = Enumerable.Empty<Hotel>().ToArray();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Hotel")]
        public int HotelId { get; set; }
        [Required]
        [ForeignKey("FacilityMaster")]
        public int FacilityId { get; set; }
        [ForeignKey("HotelId")]
        public Hotel? Hotel { get; set; }
        [ForeignKey("FacelityId")]
        public FacilityMaster? Facility { get; set; }
        public ICollection<Hotel> Hotels { get; set; }
    }
}

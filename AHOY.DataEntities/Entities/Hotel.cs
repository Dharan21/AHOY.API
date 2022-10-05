using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOY.DataEntities.Entities
{
    public class Hotel
    {
        public Hotel()
        {
            HotelImages = Enumerable.Empty<HotelImage>().ToArray();
            HotelFacilities = Enumerable.Empty<HotelFacility>().ToArray();
        }

        [Key]
        public int Id { get; set; }
        public byte? Ratings { get; set; }
        [MaxLength(200)]
        public string Address { get; set; } = string.Empty;
        [MaxLength(50)]
        public string City { get; set; } = string.Empty;
        [MaxLength(50)]
        public string State { get; set; } = string.Empty;
        [MaxLength(10)]
        public string Pincode { get; set; } = string.Empty;
        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;
        public decimal PricePerNight { get; set; }
        public bool IsRecomended { get; set; } = false;
        public bool IsPopular { get; set; } = false;
        public bool IsTopRated { get; set; } = false;
        public ICollection<HotelImage> HotelImages { get; set; }
        public ICollection<HotelFacility> HotelFacilities { get; set; }
    }
}

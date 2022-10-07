using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOY.BusinessEntities
{
    public class HotelViewModel
    {
        public int Id { get; set; }
        public byte? Ratings { get; set; }
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Pincode { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsRecomended { get; set; } = false;
        public bool IsPopular { get; set; } = false;
        public bool IsTopRated { get; set; } = false;
        public IEnumerable<HotelImageViewModel>? HotelImages { get; set; }
        public IEnumerable<HotelFacilityViewModel>? HotelFacilities { get; set; }
        public IEnumerable<HotelRoomViewModel>? HotelRooms { get; set; }
    }
}

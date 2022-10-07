using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOY.DataEntities.Entities
{
    public class FacilityMaster
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<HotelFacility>? HotelFacilities { get; set; }
    }
}

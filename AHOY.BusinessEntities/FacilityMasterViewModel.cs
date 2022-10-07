using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOY.BusinessEntities
{
    public class FacilityMasterViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public IEnumerable<HotelFacilityViewModel>? HotelFacilities { get; set; }
    }
}

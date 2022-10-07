using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOY.BusinessEntities
{
    public class HotelImageViewModel
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
    }
}

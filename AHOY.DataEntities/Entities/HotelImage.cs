﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOY.DataEntities.Entities
{
    public class HotelImage
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Hotel")]
        public int HotelId { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        [ForeignKey("HotelId")]
        public Hotel? Hotel { get; set; }
    }
}

﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicVilla_ClassLibrary.Models.Dto
{
    public class VillaCreateDTO
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public string? Details { get; set; }
        [Required]
        public double Rate { get; set; }
        public int Occupancy { get; set; }
        public int Sqft { get; set; }
        public string? ImageUrl { get; set; }
        public IFormFile? Image { get; set; }
        public string? Amenity { get; set; }
    }
}

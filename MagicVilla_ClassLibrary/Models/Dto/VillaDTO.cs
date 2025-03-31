using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicVilla_ClassLibrary.Models.Dto
{
    public class VillaDTO
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3), MaxLength(30)]
        public string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicVilla_ClassLibrary.Models.Dto
{
    public class TokenDTO
    {
        public LocalUser User { get; set; }
        public string Token { get; set; }
    }
}

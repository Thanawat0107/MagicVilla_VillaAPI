using MagicVilla_ClassLibrary.Models.Dto;
using MagicVilla_VillaAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<VillaDTO>> GetVillas()
        {
            return Ok(VillaStore.villaList);
        }


        [HttpGet("{id:int}")]
        public ActionResult<VillaDTO> GetVilla(int id)
        {
            if (id == 0) return BadRequest();
 
            var villa = VillaStore.villaList.FirstOrDefault(u => u.Id == id);

            return villa == null ? NotFound() : Ok(villa);
        }
    }   
}

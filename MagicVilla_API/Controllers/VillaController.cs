using MagicVilla_API.Datos;
using MagicVilla_API.Modelos;
using MagicVilla_API.Modelos.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<VillaDto> GetVillas() {
            return VillaStore.VillaList;
        }

        [HttpGet("id:int")]
        public VillaDto GetVilla(int id)
        {
            return VillaStore.VillaList.FirstOrDefault(v => v.Id == id);
        }

    }
}

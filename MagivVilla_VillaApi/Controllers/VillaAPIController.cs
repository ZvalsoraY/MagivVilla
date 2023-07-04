using MagivVilla_VillaApi.Data;
using MagivVilla_VillaApi.Models;
using MagivVilla_VillaApi.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace MagivVilla_VillaApi.Controllers
{
    [Route("api/VillaAPI")]
    //[Route("api/[controller]")]
    [ApiController]
    public class VillaAPIController :ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas()
        {
            return VillaStore.villaList;
        }
        [HttpGet("id:int")]
        public VillaDTO GetVillas(int id)
        {
            return VillaStore.villaList.FirstOrDefault(u => u.Id == id);
        }

    }
}

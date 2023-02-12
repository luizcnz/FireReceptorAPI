using FireReceptorAPI.Features.Dispositivos;
using FireReceptorAPI.Interfaces.Ubicaciones;
using FireReceptorAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FireReceptorAPI.Features.Ubicaciones
{
    [Route("api/[controller]")]
    [ApiController]
    public class UbicacionesController : ControllerBase
    {
        private readonly IUbicacionesAppService ubicacionesAppService;

        public UbicacionesController(IUbicacionesAppService ubicacionesAppService)
        {
            this.ubicacionesAppService = ubicacionesAppService;
        }

        [HttpGet("/api/Ubicaciones")]
        public async Task<IActionResult> GetDevices()
        {

            return Ok(await this.ubicacionesAppService.obtenerUbicaciones());
        }

        [HttpPost("/api/Ubicaciones")]
        public async Task<IActionResult> Post([FromBody] CrearUbicacion ubicacion)
        {
            return Ok(await ubicacionesAppService.crearUbicacion(ubicacion));
        }

        [HttpPost("/api/Ubicaciones/Actualizar")]
        public async Task<IActionResult> UpdateUbication([FromBody] ActualizarUbicacion ubicacion)
        {
            return Ok(await ubicacionesAppService.actualizarUbicacion(ubicacion));
        }

    }
}

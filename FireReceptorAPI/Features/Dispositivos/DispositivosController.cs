using FireReceptorAPI.Interfaces.Dispositivos;
using FireReceptorAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FireReceptorAPI.Features.Dispositivos
{
    [Route("api/[controller]")]
    [ApiController]
    public class DispositivosController : ControllerBase
    {
        private readonly IDispositivosAppService dispositivosAppService;
        public DispositivosController(IDispositivosAppService dispositivosAppService)
        {
            this.dispositivosAppService = dispositivosAppService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CrearDispositivo dispositivo)
        {
            return Ok(await dispositivosAppService.crearDispositivo(dispositivo));
        }

        [HttpGet("/api/Dispositivos")]
        public async Task<IActionResult> GetDevices()
        {

            return Ok(await this.dispositivosAppService.obtenerDispositivos());
        }
    }
}

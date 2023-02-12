using FireReceptorAPI.Interfaces.Alertas;
using FireReceptorAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FireReceptorAPI.Features.Alertas
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlertasController : ControllerBase
    {
        private readonly IAlertasAppService alertaAppService;
        public AlertasController(IAlertasAppService alertasAppService)
        {
            this.alertaAppService = alertasAppService;     
        }


        [HttpGet("/api/Alertas")]
        public async Task<IActionResult> GetAllAlerts()
        {

            return Ok(await this.alertaAppService.ObtenerAlertas());
        }

        [HttpGet("/api/Alertas/Id/{AlertId}")]
        public async Task<IActionResult> GetAlertById(int AlertId)
        {

            return Ok(await this.alertaAppService.ObtenerAlertaPorId(AlertId));
        }

        [HttpGet("/api/Alertas/Activas")]
        public async Task<IActionResult> GetAlertByState()
        {

            return Ok(await this.alertaAppService.ObtenerAlertasPorEstado());
        }

        [HttpGet("/api/Alertas/DeviceId/{DispositivoId}")]
        public async Task<IActionResult> GetAlertByDevice(int DispositivoId)
        {

            return Ok(await this.alertaAppService.ObtenerAlertaPorDispositivo(DispositivoId));
        }

        [HttpPost("/api/Alertas")]
        public async Task<IActionResult> Post([FromBody] CrearAlerta alerta)
        {
            return Ok(await alertaAppService.crearAlerta(alerta));
        }

        [HttpPost("/api/Alertas/Apagar")]
        public async Task<IActionResult> TurnOff([FromBody] ApagarAlerta turnOff)
        {
            return Ok(await alertaAppService.apagarAlerta(turnOff));
        }
    }
}

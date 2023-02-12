using FireReceptorAPI.Interfaces.Alertas;
using FireReceptorAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace FireReceptorAPI.Features.Alertas
{
    public class AlertasAppService : IAlertasAppService
    {
        private readonly IAlertasRepository alertasRepository;

        public AlertasAppService(IAlertasRepository alertaRepository)
        {
            this.alertasRepository = alertaRepository;
        }
        public async Task<IEnumerable<AlertasDto>> crearAlerta(CrearAlerta crearAlerta)
        {
            IEnumerable<AlertasDto> createAlert = await alertasRepository.CreateAlert(crearAlerta);
            return createAlert;
        }
        public async Task<IEnumerable<AlertasDto>> ObtenerAlertas()
        {
            var allAlerts = await alertasRepository.GetAllAlertas();

            return allAlerts;
        }
        public async Task<IEnumerable<AlertasDto>> ObtenerAlertaPorId(int AlertaId)
        {
            IEnumerable<AlertasDto> AlertById = await alertasRepository.GetAlertasById(AlertaId);

            return AlertById;
        }
        public async Task<IEnumerable<AlertasDto>> ObtenerAlertasPorEstado()
        {
            var activeAlerts = await alertasRepository.GetAlertasByState();

            return activeAlerts;
        }
        public async Task<IEnumerable<AlertasDto>> apagarAlerta(ApagarAlerta turnOff)
        {
            IEnumerable<AlertasDto> shutDownAlert = await alertasRepository.turnOffAlert(turnOff);
            return shutDownAlert;
        }
        public async Task<IEnumerable<AlertasDto>> ObtenerAlertaPorDispositivo(int DispositivoId)
        {
            IEnumerable<AlertasDto> AlertByDevice = await alertasRepository.GetAlertasByDeviceId(DispositivoId);

            return AlertByDevice;
        }
    }

}


    
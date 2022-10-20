using FireReceptorAPI.Models;

namespace FireReceptorAPI.Interfaces.Alertas
{
    public interface IAlertasAppService
    {
        Task<IEnumerable<AlertasDto>> crearAlerta(CrearAlerta alerta);
        Task<IEnumerable<AlertasDto>> ObtenerAlertas();
        Task<IEnumerable<AlertasDto>> ObtenerAlertaPorId(int RespuestaId);
        Task<IEnumerable<AlertasDto>> ObtenerAlertasPorEstado();
        Task<IEnumerable<AlertasDto>> apagarAlerta(ApagarAlerta turnOff);
        Task<IEnumerable<AlertasDto>> ObtenerAlertaPorDispositivo(int DispositivoId);
    }
}

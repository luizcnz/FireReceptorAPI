using FireReceptorAPI.Models;

namespace FireReceptorAPI.Interfaces.Alertas
{
    public interface IAlertasRepository
    {
        Task<IEnumerable<AlertasDto>> CreateAlert(CrearAlerta crearAlerta);
        Task<IEnumerable<AlertasDto>> GetAllAlertas();
        Task<IEnumerable<AlertasDto>> GetAlertasById(int AlertaId);
        Task<IEnumerable<AlertasDto>> GetAlertasByState();
        Task<IEnumerable<AlertasDto>> turnOffAlert(ApagarAlerta apagarAlerta);
        Task<IEnumerable<AlertasDto>> GetAlertasByDeviceId(int DeviceId);
    }
}

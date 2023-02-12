using FireReceptorAPI.Models;

namespace FireReceptorAPI.Interfaces.Dispositivos
{
    public interface IDispositivosAppService
    {
        Task<IEnumerable<DispositivosDto>> crearDispositivo(CrearDispositivo crearDispositivo);
        Task<IEnumerable<DispositivosDto>> actualizarDispositivo(ActualizarDispositivo actDispositivo);
        Task<IEnumerable<DispositivosDto>> obtenerDispositivos();
        Task<IEnumerable<DispositivosDto>> obtenerDispositivosPorId(int DispositivoId);
    }
}

using FireReceptorAPI.Models;

namespace FireReceptorAPI.Interfaces.Dispositivos
{
    public interface IDispositivosRepository
    {
        Task<IEnumerable<DispositivosDto>> CreateDispositivos(CrearDispositivo creardispositivo);
        Task<IEnumerable<DispositivosDto>> GetAllDevices();
        Task<IEnumerable<DispositivosDto>> GetDevicesById(int DispositivoId);
    }
}

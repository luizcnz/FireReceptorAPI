using FireReceptorAPI.Models;

namespace FireReceptorAPI.Interfaces.Dispositivos
{
    public interface IDispositivosRepository
    {
        Task<IEnumerable<DispositivosDto>> CreateDevice(CrearDispositivo creardispositivo);
        Task<IEnumerable<DispositivosDto>> UpdateDevice(ActualizarDispositivo actdispositivo);
        Task<IEnumerable<DispositivosDto>> GetAllDevices();
        Task<IEnumerable<DispositivosDto>> GetDevicesById(int DispositivoId);
    }
}

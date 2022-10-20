using FireReceptorAPI.Interfaces.Dispositivos;
using FireReceptorAPI.Models;


namespace FireReceptorAPI.Features.Dispositivos
{
    public class DispositivosAppService : IDispositivosAppService
    {
        private readonly IDispositivosRepository dispositivosRepository;
        public DispositivosAppService(IDispositivosRepository dispositivosRepository)
        {
            this.dispositivosRepository = dispositivosRepository;
        }

        public async Task<IEnumerable<DispositivosDto>> crearDispositivo(CrearDispositivo crearDispositivo)
        {
            IEnumerable<DispositivosDto> createDispositivo = await dispositivosRepository.CreateDispositivos(crearDispositivo);
            return createDispositivo;
        }

        public async Task<IEnumerable<DispositivosDto>> obtenerDispositivos()
        {
            IEnumerable<DispositivosDto> getDispositivo = await dispositivosRepository.GetAllDevices();
            return getDispositivo;
        }

        public async Task<IEnumerable<DispositivosDto>> obtenerDispositivosPorId(int DispositivoId)
        {
            IEnumerable<DispositivosDto> getDispositivoPorId = await dispositivosRepository.GetDevicesById(DispositivoId);
            return getDispositivoPorId;
        }
    }
}
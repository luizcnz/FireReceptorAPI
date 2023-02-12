using FireReceptorAPI.Interfaces.Dispositivos;
using FireReceptorAPI.Interfaces.Ubicaciones;
using FireReceptorAPI.Models;
using FireReceptorAPI.Repositories;

namespace FireReceptorAPI.Features.Ubicaciones
{
    public class UbicacionesAppService: IUbicacionesAppService
    {
        private readonly IUbicacionesRepository ubicacionesRepository;
        public UbicacionesAppService(IUbicacionesRepository ubicacionesRepository)
        {
            this.ubicacionesRepository = ubicacionesRepository;
        }

        public async Task<IEnumerable<UbicacionDto>> obtenerUbicaciones()
        {
            IEnumerable<UbicacionDto> getUbicaciones = await ubicacionesRepository.GetAllUbications();
            return getUbicaciones;
        }

        public async Task<IEnumerable<UbicacionDto>> crearUbicacion(CrearUbicacion crearUbicacion)
        {
            IEnumerable<UbicacionDto> createUbicacion = await ubicacionesRepository.CreateUbication(crearUbicacion);
            return createUbicacion;
        }

        public async Task<IEnumerable<UbicacionDto>> actualizarUbicacion(ActualizarUbicacion actualizarUbicacion)
        {
            IEnumerable<UbicacionDto> updateUbicacion = await ubicacionesRepository.UpdateUbication(actualizarUbicacion);
            return updateUbicacion;
        }
    }
}

using FireReceptorAPI.Models;

namespace FireReceptorAPI.Interfaces.Ubicaciones
{
    public interface IUbicacionesAppService
    {
        Task<IEnumerable<UbicacionDto>> obtenerUbicaciones();
        Task<IEnumerable<UbicacionDto>> crearUbicacion(CrearUbicacion crearUbicacion);
        Task<IEnumerable<UbicacionDto>> actualizarUbicacion(ActualizarUbicacion actualizarUbicacion);
    }
}

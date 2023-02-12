using FireReceptorAPI.Models;

namespace FireReceptorAPI.Interfaces.Ubicaciones
{
    public interface IUbicacionesRepository
    {
        Task<IEnumerable<UbicacionDto>> GetAllUbications();
        Task<IEnumerable<UbicacionDto>> CreateUbication(CrearUbicacion crearUbicacion);
        Task<IEnumerable<UbicacionDto>> UpdateUbication(ActualizarUbicacion actualizarUbicacion);
    }
}

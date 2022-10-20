using FireReceptorAPI.Models;

namespace FireReceptorAPI.Interfaces.Respuestas
{
    public interface IRespuestasAppService
    {
        Task<Response> crearRespuesta(CrearRespuesta crearRespuesta);
    }
}

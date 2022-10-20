using FireReceptorAPI.Models;

namespace FireReceptorAPI.Interfaces.Respuestas
{
    public interface IRespuestasRepository
    {
        Task<IEnumerable<CrearRespuesta>> CreateRespuesta(CrearRespuesta crearRespuesta);
        Task<IEnumerable<RespuestasDto>> GetAllResponses();
        Task<IEnumerable<RespuestasDto>> GetResponsesById(int RespuestaId);
    }
}

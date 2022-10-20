using FireReceptorAPI.Interfaces.Dispositivos;
using FireReceptorAPI.Interfaces.Respuestas;
using FireReceptorAPI.Models;
using FireReceptorAPI.Repositories;

namespace FireReceptorAPI.Features.Respuestas
{
    public class RespuestaAppService : IRespuestasAppService
    {
        private readonly IRespuestasRepository respuestasRepository;
        public RespuestaAppService(IRespuestasRepository respuestasRepository)
        {
            this.respuestasRepository = respuestasRepository;
        }


        public async Task<Response> crearRespuesta(CrearRespuesta crearRespuesta)
        {
            IEnumerable<CrearRespuesta> createRespuesta = await respuestasRepository.CreateRespuesta(crearRespuesta);
            return new Response
            {
                Data = createRespuesta
            };
        }
    }
}

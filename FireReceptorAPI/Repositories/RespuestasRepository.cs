using AutoMapper;
using FireReceptorAPI.Interfaces.Alertas;
using FireReceptorAPI.Interfaces.Respuestas;
using FireReceptorAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FireReceptorAPI.Repositories
{
    public class RespuestasRepository:IRespuestasRepository
    {
        private readonly FireContext fireContext;
        private readonly IMapper mapper;
        public RespuestasRepository(FireContext fireContext, IMapper mapper)
        {
            this.fireContext = fireContext;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<CrearRespuesta>> CreateRespuesta(CrearRespuesta crearRespuesta)
        {
            string procedureName = "dbo.CreateRespuesta";
            var result = await fireContext.Respuestas
                .FromSqlRaw("exec {0} @Descripcion = {1}, @Adjunto = {2}, @Fechacreado = {3}, @Estado = 1, @Prioridad = {4},  @Subcategoria = {5}, @UsuarioSolicitante = {6} "
                , procedureName
                , crearRespuesta.UsuarioId
                , crearRespuesta.DispositivoId
                , crearRespuesta.FechaRespuesta)
                .ToListAsync();
            fireContext.SaveChanges();

            return mapper.Map<IEnumerable<CrearRespuesta>>(result);

        }
        public async Task<IEnumerable<RespuestasDto>> GetAllResponses()
        {
            string procedureName = "dbo.GetResponses";
            var result = await fireContext.Dispositivos.FromSqlRaw("exec {0}", procedureName).ToListAsync();
            if (result.Count == 0)
            {
                return null;
            }
            return mapper.Map<IEnumerable<RespuestasDto>>(result);
        }

        public async Task<IEnumerable<RespuestasDto>> GetResponsesById(int RespuestaId)
        {
            string procedureName = "dbo.GetAlertsById";
            var result = await fireContext.Dispositivos.FromSqlRaw("exec {0} @Id = {1}", procedureName, RespuestaId).ToListAsync();
            if (result.Count == 0)
            {
                return null;
            }
            return mapper.Map<IEnumerable<RespuestasDto>>(result);
        }
    }
}

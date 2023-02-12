using AutoMapper;
using FireReceptorAPI.Interfaces.Ubicaciones;
using FireReceptorAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FireReceptorAPI.Repositories
{
    public class UbicacionesRepository : IUbicacionesRepository
    {
        private readonly FireContext fireContext;
        private readonly IMapper mapper;
        public UbicacionesRepository(FireContext fireContext, IMapper mapper)
        {
            this.fireContext = fireContext;
            this.mapper = mapper;
        }


        public async Task<IEnumerable<UbicacionDto>> GetAllUbications()
        {
            string procedureName = "dbo.GetAllUbications";
            var result = await fireContext.Ubicaciones.FromSqlRaw("exec {0}", procedureName).ToListAsync();
            if (result.Count == 0)
            {
                return null;
            }
            return mapper.Map<IEnumerable<UbicacionDto>>(result);
        }
        public async Task<IEnumerable<UbicacionDto>> CreateUbication(CrearUbicacion crearUbicacion)
        {
            string procedureName = "dbo.CreateUbication";
            var result = await fireContext.Ubicaciones
                .FromSqlRaw("exec {0} @ubicacion = {1}"
                , procedureName
                , crearUbicacion.ubicacion)
                .ToListAsync();
            fireContext.SaveChanges();
            return mapper.Map<IEnumerable<UbicacionDto>>(result);
        }

        public async Task<IEnumerable<UbicacionDto>> UpdateUbication(ActualizarUbicacion actualizarUbicacion)
        {
            string procedureName = "dbo.UpdateUbication";
            var result = await fireContext.Ubicaciones
                .FromSqlRaw("exec {0} @ubicacionId = {1}, @ubicacion = {2}, @ubicacionEstado = {3}"
                , procedureName
                , actualizarUbicacion.id
                , actualizarUbicacion.ubicacion
                , actualizarUbicacion.estado)
                .ToListAsync();
            fireContext.SaveChanges();
            return mapper.Map<IEnumerable<UbicacionDto>>(result);
        }
    }
}

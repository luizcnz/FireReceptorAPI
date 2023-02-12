using AutoMapper;
using FireReceptorAPI.Interfaces.Dispositivos;
using FireReceptorAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FireReceptorAPI.Repositories
{
    public class DispositivosRepository : IDispositivosRepository
    {
        private readonly FireContext fireContext;
        private readonly IMapper mapper;
        public DispositivosRepository(FireContext fireContext, IMapper mapper)
        {
            this.fireContext = fireContext;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<DispositivosDto>> CreateDevice(CrearDispositivo creardispositivo)
        {
            string procedureName = "dbo.CreateDevice";
            var result = await fireContext.Dispositivos
                .FromSqlRaw("exec {0} @codigo = {1}, @ubicacionID = {2}, @estado = {3}"
                , procedureName
                , creardispositivo.codigo
                , creardispositivo.ubicacion_id
                , creardispositivo.estado)
                .ToListAsync();
            fireContext.SaveChanges();
            return mapper.Map<IEnumerable<DispositivosDto>>(result);
        }

        public async Task<IEnumerable<DispositivosDto>> UpdateDevice(ActualizarDispositivo actdispositivo)
        {
            string procedureName = "dbo.UpdateDevice";
            var result = await fireContext.Dispositivos
                .FromSqlRaw("exec {0} @dispositivoId = {1}, @codDispositivo = {2}, @idUbicacion = {3}, @estadoDispositivo = {4}"
                , procedureName
                , actdispositivo.Id
                , actdispositivo.codigo
                , actdispositivo.ubicacion_id
                , actdispositivo.estado)
                .ToListAsync();
            fireContext.SaveChanges();
            return mapper.Map<IEnumerable<DispositivosDto>>(result);
        }

        public async Task<IEnumerable<DispositivosDto>> GetAllDevices()
        {
            string procedureName = "dbo.GetAllDevices";
            var result = await fireContext.Dispositivos.FromSqlRaw("exec {0}", procedureName).ToListAsync();
            if (result.Count == 0)
            {
                return null;
            }
            return mapper.Map<IEnumerable<DispositivosDto>>(result);
        }

        public async Task<IEnumerable<DispositivosDto>> GetDevicesById(int DispositivoId)
        {
            string procedureName = "dbo.GetAlertsById";
            var result = await fireContext.Dispositivos.FromSqlRaw("exec {0} @id = {1}", procedureName, DispositivoId).ToListAsync();
            if (result.Count == 0)
            {
                return null;
            }
            return mapper.Map<IEnumerable<DispositivosDto>>(result);
        }
    }
}

using FireReceptorAPI.Models;
using FireReceptorAPI.Interfaces.Alertas;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace FireReceptorAPI.Repositories
{
    public class AlertaRepository : IAlertasRepository
    {
        private readonly FireContext fireContext;
        private readonly IMapper mapper;
        public AlertaRepository(FireContext fireContext, IMapper mapper)
        {
            this.fireContext = fireContext;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<AlertasDto>> CreateAlert(CrearAlerta crearAlerta)
        {
            string procedureName = "dbo.CreateAlerta";
            var result = await fireContext.Alertas
                .FromSqlRaw("exec {0} @Dispositivo = {1}, @Fuego = {2}, @Humo = {3}, @Calor = {4}, @Temperatura = {5},  @Creado = {6}"
                , procedureName
                , crearAlerta.dispositivo_id
                , crearAlerta.alerta_fuego
                , crearAlerta.alerta_humo
                , crearAlerta.alerta_calor
                , crearAlerta.temperatura
                , crearAlerta.fecha_creacion)
                .ToListAsync();
            fireContext.SaveChanges();
            return mapper.Map<IEnumerable<AlertasDto>>(result);

        }

        public async Task<IEnumerable<AlertasDto>> GetAllAlertas()
        {
            string procedureName = "dbo.GetAllAlertas";
            var result = await fireContext.Alertas.FromSqlRaw("exec {0}", procedureName).ToListAsync();
            if (result.Count == 0)
            {
                return null;
            }
            return mapper.Map<IEnumerable<AlertasDto>>(result);
        }

        public async Task<IEnumerable<AlertasDto>> GetAlertasById(int AlertaId)
        {
            string procedureName = "dbo.GetAlertasById";
            var result = await fireContext.Alertas.FromSqlRaw("exec {0} @alertaId = {1}", procedureName, AlertaId).ToListAsync();
            if (result.Count == 0)
            {
                return null;
            }
            return mapper.Map<IEnumerable<AlertasDto>>(result);
        }

        public async Task<IEnumerable<AlertasDto>> GetAlertasByState()
        {
            string procedureName = "dbo.GetAlertasByState";
            var result = await fireContext.Alertas.FromSqlRaw("exec {0}", procedureName).ToListAsync();
            if (result.Count == 0)
            {
                return null;
            }
            return mapper.Map<IEnumerable<AlertasDto>>(result);
        }

        public async Task<IEnumerable<AlertasDto>> turnOffAlert(ApagarAlerta apagarAlerta)
        {
            string procedureName = "dbo.TurnOffAlert";
            var result = await fireContext.Alertas
                .FromSqlRaw("exec {0} @id = {1}, @respuesta = {2}"
                , procedureName
                , apagarAlerta.id
                ,apagarAlerta.fecha_respuesta)
                .ToListAsync();
            fireContext.SaveChanges();
            return mapper.Map<IEnumerable<AlertasDto>>(result);
        }
        public async Task<IEnumerable<AlertasDto>> GetAlertasByDeviceId(int DeviceId)
        {
            string procedureName = "dbo.GetAlertasByDeviceId";
            var result = await fireContext.Alertas.FromSqlRaw("exec {0} @DeviceId = {1}", procedureName, DeviceId).ToListAsync();
            if (result.Count == 0)
            {
                return null;
            }

            return mapper.Map<IEnumerable<AlertasDto>>(result);
        }
    }
}

using AutoMapper;
using FireReceptorAPI.Models;
using FireReceptorAPI.Models.Entities;

namespace FireReceptorAPI.Automapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AlertasModel, AlertasDto>();
            CreateMap<DispositivosModel, DispositivosDto>();
            CreateMap<UbicacionModel, UbicacionDto>();
        }
    }
}

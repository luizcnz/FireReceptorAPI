using FireReceptorAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FireReceptorAPI.Repositories
{
    public class FireContext : DbContext
    {
        public FireContext(DbContextOptions<FireContext> options)
            : base(options)
        {
        }

        public DbSet<AlertasModel> Alertas { get; set; } = null!;
        public DbSet<DispositivosModel> Dispositivos { get; set; } = null!;
        public DbSet<UbicacionModel> Ubicaciones { get; set; } = null!;
        
    }
}

namespace FireReceptorAPI.Models.Entities
{
    public class RespuestasModel
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int DispositivoId { get; set; }
        public DateTime FechaRespuesta { get; set; }
    }
}

namespace FireReceptorAPI.Models
{
    public class RespuestasDto
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int DispositivoId { get; set; }
        public DateTime FechaRespuesta { get; set; }
    }
    public class CrearRespuesta
    {
        public int UsuarioId { get; set; }
        public int DispositivoId { get; set; }
        public DateTime FechaRespuesta { get; set; }
    }
}

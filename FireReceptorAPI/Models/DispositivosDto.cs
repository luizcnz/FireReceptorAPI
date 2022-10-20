namespace FireReceptorAPI.Models
{
    public class DispositivosDto
    {
        public int Id { get; set; }
        public string codigo { get; set; }
        public string ubicacion { get; set; }
        public bool estado { get; set; }
    }

    public class CrearDispositivo
    {
        public string codigo { get; set; }
        public int ubicacion_id { get; set; }
        public bool estado { get; set; }
    }
}

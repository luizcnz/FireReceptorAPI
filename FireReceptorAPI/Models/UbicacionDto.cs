namespace FireReceptorAPI.Models
{
    public class UbicacionDto
    {
        public int id { get; set; }
        public string ubicacion { get; set; }
        public bool estado { get; set; }
    }

    public class CrearUbicacion
    {
        public string ubicacion { get; set; }
        public bool estado { get; set; }
    }

    public class ActualizarUbicacion
    {
        public int id { get; set; }
        public string ubicacion { get; set; }
        public bool estado { get; set; }
    }
}

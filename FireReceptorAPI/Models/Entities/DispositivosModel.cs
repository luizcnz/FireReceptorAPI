namespace FireReceptorAPI.Models.Entities
{
    public class DispositivosModel
    {
        public int Id { get; set; }
        public string codigo { get; set; }
        public int ubicacion_id { get; set; }
        public string ubicacion { get; set; }
        public bool estado { get; set; }
    }
}

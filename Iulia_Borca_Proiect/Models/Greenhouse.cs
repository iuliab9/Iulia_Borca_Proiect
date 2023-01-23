namespace Iulia_Borca_Proiect.Models
{
    public class Greenhouse
    {
        public int ID { get; set; }
        public string GreenhouseName { get; set; }

        public ICollection<Flower>? Flowers { get; set; }
    }
}

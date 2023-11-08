using System.Reflection.Metadata.Ecma335;

namespace FuarProjesi.Models.Entities
{
    public class Place : BaseEntity
    {
        public string PlaceName { get; set; }
        public string Adress {  get; set; }
        public bool Garage { get; set; }
        //Relational Properties
        public virtual ICollection<Flat> Flats { get; set; }
    }
}

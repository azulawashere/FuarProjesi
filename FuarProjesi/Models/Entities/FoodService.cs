namespace FuarProjesi.Models.Entities
{
    public class FoodService : BaseEntity
    {
        public string ServiceName { get; set; }
        public int ServicePrice { get; set; }

        //Relational Property
        public virtual ICollection<Package> Packages { get; set; }
    }
}

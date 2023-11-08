namespace FuarProjesi.Models.Entities
{
    public class Package : BaseEntity
    {
        public decimal UnitPrice { get; set; }
        public int CategoryID { get; set; }
        public int FoodServiceID { get; set; }
        //Relational Property
        public virtual Category Category { get; set; }
        public virtual FoodService FoodService { get; set; }
        public virtual ICollection<PackageHostess> PackageHostesses { get; set; }
    }
}

namespace FuarProjesi.Models.Entities
{
    public class Package : BaseEntity
    {
        public decimal UnitPrice { get; set; }
        public int CategoryID { get; set; }
        public int? FoodServiceID { get; set; }
        public int AppUserID { get; set; }
        public bool Garage { get; set; }
        public int? PrepTime { get; set; }  //Sorulacak!! Paket süresini, daire sayısı ya da m2 büyüklüğü belirleyecek.
        //Relational Property
        public virtual Category Category { get; set; }
        public virtual FoodService FoodService { get; set; }
        public virtual ICollection<PackageHostess> PackageHostesses { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}

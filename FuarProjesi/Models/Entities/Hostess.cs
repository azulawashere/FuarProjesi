namespace FuarProjesi.Models.Entities
{
    public class Hostess : BaseEntity
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public short Age { get; set; }
        public string Languages { get; set; }

        //Relational Property
        public virtual ICollection<PackageHostess> PackageHostesses { get; set; }
    }
}

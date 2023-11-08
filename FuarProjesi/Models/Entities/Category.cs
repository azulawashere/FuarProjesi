using System.Reflection.Metadata.Ecma335;

namespace FuarProjesi.Models.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        //Relational Properties
        public virtual ICollection<Package> Packages { get; set; }
    }
}

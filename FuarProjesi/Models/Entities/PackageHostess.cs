using System.Reflection.Metadata.Ecma335;

namespace FuarProjesi.Models.Entities
{
    public class PackageHostess : BaseEntity
    {
        public int PackageID { get; set; }
        public int HostessID { get; set; }
        //Relational Property
        public virtual Package Package { get; set; }
        public virtual Hostess Hostess { get; set; }
    }
}

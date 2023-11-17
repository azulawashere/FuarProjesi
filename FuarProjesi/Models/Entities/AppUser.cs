using FuarProjesi.Models.Enums;
using FuarProjesi.Models.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace FuarProjesi.Models.Entities
{
    public class AppUser :IdentityUser<int>,  IEntity
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
  

        public bool Admin { get; set; }
        //Relational Properties
        public virtual ICollection<AppUserRole> UserRoles { get; set; }
        public virtual AppUserProfile Profile { get; set; }
        public virtual ICollection<Package> Packages { get; set; }
       
    }
}

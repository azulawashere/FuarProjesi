namespace FuarProjesi.Models.Entities
{
    public class AppUserProfile : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }

        //Relational Properties
        public virtual AppUser AppUser { get; set; }
    }
}

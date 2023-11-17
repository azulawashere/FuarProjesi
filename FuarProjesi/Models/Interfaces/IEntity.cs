using FuarProjesi.Models.Enums;

namespace FuarProjesi.Models.Interfaces
{
    public interface IEntity
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
    }
}

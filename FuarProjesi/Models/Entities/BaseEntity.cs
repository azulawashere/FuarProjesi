using FuarProjesi.Models.Enums;
using FuarProjesi.Models.Interfaces;

namespace FuarProjesi.Models.Entities
{
    public abstract class BaseEntity:IEntity
    {
        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}

using FuarProjesi.Models.Entities;
using FuarProjesi.Models.Hostesses.PureVms;
using FuarProjesi.Models.Hostesses.ResponseModels;

namespace FuarProjesi.Models.MapperClasses
{
    public static class HostessMapper
    {
       
        public static HostessVM GetHostessVM(Hostess hostess)
        {
            return new()
            {

                ID = hostess.ID,
                FirstName = hostess.FirstName,
                LastName = hostess.LastName,
                Age = hostess.Age,
                Languages = hostess.Languages
            };
        }
    }
}

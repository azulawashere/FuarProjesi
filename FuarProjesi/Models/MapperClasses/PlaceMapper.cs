using FuarProjesi.Models.Entities;
using FuarProjesi.Models.Places.PureVms;
using FuarProjesi.Models.Places.ResponseModels;

namespace FuarProjesi.Models.MapperClasses
{
    public static class PlaceMapper
    {
        public static PlaceResponseModel GetPlaceResponseModel(Place place)
        {
            return new()
            {
                ID = place.ID,
                PlaceName = place.PlaceName,
                Adress = place.Adress
            };
        }
        public static PlaceVM GetPlaceVM(Place place)
        {
            return new()
            {
                ID = place.ID,
                PlaceName = place.PlaceName,
                Adress = place.Adress
            };
        }
    }
}

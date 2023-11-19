using FuarProjesi.Models.Categories.PureVms;
using FuarProjesi.Models.Categories.ResponseModels;
using FuarProjesi.Models.Entities;
using FuarProjesi.Models.Places.PureVms;
using FuarProjesi.Models.Places.ResponseModels;

namespace FuarProjesi.Models.MapperClasses
{
    public static class PlaceMapper
    {
        public static PlaceResponseModel GetPlaceResponseModel(Entities.Place place)
        {
            return new()
            {
                ID = place.ID,
                PlaceName = place.PlaceName,
                Adress = place.Adress
            };
        }
        public static PlaceVM GetPlaceVM(Entities.Place place)
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

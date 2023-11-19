using FuarProjesi.Models.Places.ResponseModels;

namespace FuarProjesi.Models.Places.PageVms
{
    public class PlaceResponsePageVM
    {
        public List<PlaceResponseModel> Places { get; set; }
        public PlaceResponseModel Place { get; set; }
    }
}

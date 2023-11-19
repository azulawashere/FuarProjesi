using FuarProjesi.Models.Flats.ResponseModels;

namespace FuarProjesi.Models.Flats.PageVms
{
    public class FlatResponsePageVM
    {
        public List<FlatResponseModel> Flats { get; set; }
        public FlatResponseModel Flat { get; set; }
        public int PlaceID { get; set; }

    }
}

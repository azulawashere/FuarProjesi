using FuarProjesi.Models.Entities;
using FuarProjesi.Models.Flats.PureVms;
using FuarProjesi.Models.Flats.ResponseModels;


namespace FuarProjesi.Models.MapperClasses
{
    public static class FlatMapper
    {
        public static FlatResponseModel GetFlatResponseModel(Flat flat)
        {
            return new()
            {
                ID = flat.ID,
                FlatPrice = flat.FlatPrice,
                FlatNo = flat.FlatNo,
                FloorNo = flat.FloorNo,
                MSquare = flat.MSquare,
                FlatPopulation = flat.FlatPopulation             
            };
        }
        public static FlatVM GetFlatVM(Flat flat)
        {
            return new()
            {
                ID = flat.ID,
                FlatPrice = flat.FlatPrice,
                FlatNo = flat.FlatNo,
                FloorNo = flat.FloorNo,
                MSquare = flat.MSquare,
                FlatPopulation = flat.FlatPopulation
            };
        }
    }
}

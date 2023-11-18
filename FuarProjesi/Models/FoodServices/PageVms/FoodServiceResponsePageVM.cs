using FuarProjesi.Models.FoodServices.ResponseModels;

namespace FuarProjesi.Models.FoodServices.PageVms
{
    public class FoodServiceResponsePageVM
    {
        public List<FoodServiceResponseModel> FoodServices { get; set; }

        public FoodServiceResponseModel FoodService { get; set; }
    }
}

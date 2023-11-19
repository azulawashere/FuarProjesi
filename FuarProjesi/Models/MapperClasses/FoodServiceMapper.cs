using FuarProjesi.Models.Entities;
using FuarProjesi.Models.FoodServices.PureVms;
using FuarProjesi.Models.FoodServices.ResponseModels;

namespace FuarProjesi.Models.MapperClasses
{
    public static class FoodServiceMapper
    {
        public static FoodServiceResponseModel GetFoodServiceResponseModel(FoodService foodService)
        {
            return new()
            {
                ID = foodService.ID,
                ServiceName = foodService.ServiceName,
                ServicePrice = foodService.ServicePrice
            };
        }
        public static FoodServiceVM GetFoodServiceVM(FoodService foodService)
        {
            return new()
            {
                ID = foodService.ID,
                ServiceName = foodService.ServiceName,
                ServicePrice = foodService.ServicePrice
            };
        }
    }
}

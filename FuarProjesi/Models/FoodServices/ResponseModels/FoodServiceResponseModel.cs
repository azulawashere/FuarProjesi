using System.Reflection.Metadata.Ecma335;

namespace FuarProjesi.Models.FoodServices.ResponseModels
{
    public class FoodServiceResponseModel
    {
        public int ID { get; set; }
        public string ServiceName { get; set; }
        public decimal ServicePrice { get; set; }
    }
}

using FuarProjesi.Models.Admin.ResponseModels.CategoryResponseModels;

namespace FuarProjesi.Models.Admin.PageVms.CategoryPageVms
{
    public class CategoryResponsePageVM
    {
        public List<CategoryResponseModel> Categories { get; set; }
        public CategoryResponseModel Category { get; set; }
    }
}

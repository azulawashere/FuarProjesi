using FuarProjesi.Models.Categories.ResponseModels;

namespace FuarProjesi.Models.Categories.PageVms
{
    public class CategoryResponsePageVM
    {
        public List<CategoryResponseModel> Categories { get; set; }
        public CategoryResponseModel Category { get; set; }
    }
}

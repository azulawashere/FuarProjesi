using FuarProjesi.Models.Categories.PureVms;
using FuarProjesi.Models.Categories.ResponseModels;
using FuarProjesi.Models.Entities;

namespace FuarProjesi.Models.MapperClasses
{
    public static class CategoryMapper
    {
    
        public static CategoryVM GetCategoryVM(Category category)
        {
            return new()
            {
                ID = category.ID,
                CategoryName = category.CategoryName
                
            };
        }
    }
}

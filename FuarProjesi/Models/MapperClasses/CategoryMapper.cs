﻿using FuarProjesi.Models.Categories.PageVms;
using FuarProjesi.Models.Categories.PureVms;
using FuarProjesi.Models.Categories.ResponseModels;
using FuarProjesi.Models.Entities;

namespace FuarProjesi.Models.MapperClasses
{
    public static class CategoryMapper
    {
        public static CategoryResponseModel GetCategoryResponseModel(Category category) 
        {
            return new()
            {
                ID = category.ID,
                CategoryName = category.CategoryName
            };
        }
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
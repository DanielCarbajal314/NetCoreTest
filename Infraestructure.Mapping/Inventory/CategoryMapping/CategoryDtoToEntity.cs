using Domain.Entities.Inventory;
using Services.Interfaces.Inventory.CategoryManagement.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Mapping.Inventory.CategoryMapping
{
    public static class CategoryDtoToEntity
    {
        public static Category ToEntity(this NewCategory newCategory)
        {
            return new Category()
            {
                Name = newCategory.Name,
                Description = newCategory.Description
            };
        }
    }
}

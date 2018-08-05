using Domain.Entities.Inventory;
using Services.Interfaces.Inventory.CategoryManagement.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Mapping.Inventory.CategoryMapping
{
    public static class CategoryEntityToDTO
    {
        public static GeneralCategory ToDTO(this Category category)
        {
            return new GeneralCategory()
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description
            };
        }
    }
}

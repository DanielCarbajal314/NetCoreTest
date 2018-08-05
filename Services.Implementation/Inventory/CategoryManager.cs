using Domain.Entities.Inventory;
using Infraestructure.Context.Inventory;
using Infraestructure.Mapping.Inventory.CategoryMapping;
using Microsoft.EntityFrameworkCore;
using Services.Interfaces.Common;
using Services.Interfaces.Inventory.CategoryManagement;
using Services.Interfaces.Inventory.CategoryManagement.Requests;
using Services.Interfaces.Inventory.CategoryManagement.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementation.Inventory
{
    public class CategoryManager : ICategoryManager
    {
        public async Task<GeneralCategory> Create(NewCategory newRegistry)
        {
            using (InventoryDB db = new InventoryDB())
            {
                Category category = newRegistry.ToEntity();
                db.Categories.Add(category);
                await db.SaveChangesAsync();
                return category.ToDTO();
            }
        }

        public Task Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<GeneralCategory>> List(Page page)
        {
            using (InventoryDB db = new InventoryDB())
            {
                var entities = await db.Categories.Where(x => x.Deleted == false)
                         .Skip(page.Number * page.Size)
                         .Take(page.Size)
                         .ToListAsync();
                return entities.Select(x => x.ToDTO()).ToList();
            }
        }

        public Task<GeneralCategory> Update(UpdateCategory ÚpdateRegistry)
        {
            throw new NotImplementedException();
        }
    }
}

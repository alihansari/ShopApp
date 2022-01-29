using Microsoft.EntityFrameworkCore;
using shopapp.data.Abstract;
using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shopapp.data.Concrete.EfCore
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category>, ICategoryRepository
    {
        public EfCoreCategoryRepository(ShopContext context):base(context)
        {

        }
        private ShopContext ShopContext
        {
            get { return _context as ShopContext; }
        }
        public void DeleteFromCategory(int productId, int categoryId)
        {
            
                var cmd = "Delete from  productcategory where ProductId=@p0 and CategoryId=@p1";
                ShopContext.Database.ExecuteSqlRaw(cmd, productId, categoryId);
            
        }

        public Category GetByIdWithProducts(int categoryId)
        {
           
            
                return ShopContext.Categories
                               .Where(i => i.CategoryId == categoryId)
                               .Include(i => i.ProductCategories)
                               .ThenInclude(i => i.Product)
                               .FirstOrDefault();
            
        }
        

        
    }
}

using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace shopapp.business.Abstract
{
    public interface IProductService:IValidator<Product>
    {
        Product GetProductDetails(string url);
        Task<Product> GetById(int id);
        Product GetByIdWithCategories(int id);
        Task<List<Product>> GetAll();
        List<Product> GetProductsByCategory(string name,int page,int pageSize);
        bool Create(Product entity);
        Task<Product> CreateAsync(Product entity);
        void Update(Product entity);
        Task UpdateAsync(Product entityToUpdate,Product entity);
        void Delete(Product entity);
        Task DeleteAsync(Product entity);
        int GetCountByCategory(string category);
        List<Product> GetHomePageProducts();
        List<Product> GetSearchResult(string searchString);
        bool Update(Product entity, int[] categoryIds);
    }
}

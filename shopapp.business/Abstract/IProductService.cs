using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.business.Abstract
{
    public interface IProductService:IValidator<Product>
    {
        Product GetProductDetails(string url);
        Product GetById(int id);
        Product GetByIdWithCategories(int id);
        List<Product> GetAll();
        List<Product> GetProductsByCategory(string name,int page,int pageSize);
        bool Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
        int GetCountByCategory(string category);
        List<Product> GetHomePageProducts();
        List<Product> GetSearchResult(string searchString);
        bool Update(Product entity, int[] categoryIds);
    }
}

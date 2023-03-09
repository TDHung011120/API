using APIShop.Model.Models;
using Data.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace APIShop.Data.Respositories
{
    public interface IProductCategoryRepository :IRepository<ProductCategory>
    {
        //khai báo phương thức riêng cần tạo của table
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }

    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        private object dbContext;

        //Dùng các phương thức đã được viết sẵn dùng chung
        public ProductCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        // triển khai các phương thức mới thông qua interface riêng của table
        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(x => x.Alias == alias);
        }
    }
}
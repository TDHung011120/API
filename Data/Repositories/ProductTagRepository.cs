using APIShop.Model.Models;
using Data.Infrastructure;

namespace APIShop.Data.Repositories
{
    
    public interface IProductTagRepository : IRepository<ProductTag>
    {
        //khai báo phương thức riêng cần tạo của table

    }

    public class ProductTagRepository : RepositoryBase<ProductTag>, IProductTagRepository
    {
        //Dùng các phương thức đã được viết sẵn dùng chung
        public ProductTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        // triển khai các phương thức mới thông qua interface riêng của table

    }
}

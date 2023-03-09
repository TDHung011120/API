using APIShop.Model.Models;
using Data.Infrastructure;

namespace APIShop.Data.Repositories
{
    public interface IPostCategoryRepository : IRepository<PostCategory>
    {
        //khai báo phương thức riêng cần tạo của table
    }

    public class PostCategoryRepository : RepositoryBase<PostCategory>, IPostCategoryRepository
    {
        //Dùng các phương thức đã được viết sẵn dùng chung
        public PostCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        // triển khai các phương thức mới thông qua interface riêng của table
    }
}
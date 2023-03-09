using APIShop.Model.Models;
using Data.Infrastructure;

namespace APIShop.Data.Repositories
{
    
    public interface IPostTagRepository : IRepository<PostTag>
    {
        //khai báo phương thức riêng cần tạo của table

    }

    public class PostTagRepository : RepositoryBase<PostTag>, IPostTagRepository
    {
        //Dùng các phương thức đã được viết sẵn dùng chung
        public PostTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        // triển khai các phương thức mới thông qua interface riêng của table

    }
}

using APIShop.Model.Models;
using Data.Infrastructure;

namespace APIShop.Data.Repositories
{
    
    public interface ITagRepository :IRepository<Tag>
    {
        //khai báo phương thức riêng cần tạo của table

    }

    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        //Dùng các phương thức đã được viết sẵn dùng chung
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        // triển khai các phương thức mới thông qua interface riêng của table

    }
}

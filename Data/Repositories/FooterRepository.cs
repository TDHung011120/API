using Data.Infrastructure;
using Model.Models;

namespace APIShop.Data.Repositories
{
    public interface IFooterRepository : IRepository<Footer>
    {
        //khai báo phương thức riêng cần tạo của table
    }

    public class FooterRepository : RepositoryBase<Footer>, IFooterRepository
    {
        //Dùng các phương thức đã được viết sẵn dùng chung
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        // triển khai các phương thức mới thông qua interface riêng của table
    }
}
using APIShop.Model.Models;
using Data.Infrastructure;

namespace Web.Data.Repositories
{
    public interface IMenuGroupRepository :IRepository<MenuGroup>
    {
        //khai báo phương thức riêng cần tạo của table
    }

    public class MenuGroupRepository : RepositoryBase<MenuGroup>, IMenuGroupRepository
    {
        //Dùng các phương thức đã được viết sẵn dùng chung
        public MenuGroupRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        // triển khai các phương thức mới thông qua interface riêng của table
    }
}
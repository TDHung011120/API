using APIShop.Model.Models;
using Data.Infrastructure;

namespace Web.Data.Repositories
{
    public interface IMenuRepository: IRepository<Menu>
    {
        //khai báo phương thức riêng cần tạo của table
    }

    public class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
        //Dùng các phương thức đã được viết sẵn dùng chung
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        // triển khai các phương thức mới thông qua interface riêng của table
    }
}
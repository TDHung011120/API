using APIShop.Model.Models;
using Data.Infrastructure;

namespace APIShop.Data.Repositories
{
    public interface ISystemConfigRepository :IRepository<SystemConfig>
    {
        //khai báo phương thức riêng cần tạo của table
    }

    public class SystemConfigRepository : RepositoryBase<SystemConfig>, ISystemConfigRepository
    {
        //Dùng các phương thức đã được viết sẵn dùng chung
        public SystemConfigRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        // triển khai các phương thức mới thông qua interface riêng của table
    }
}
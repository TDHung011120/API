using APIShop.Model.Models;
using Data.Infrastructure;

namespace APIShop.Data.Repositories
{
    public interface ISupportOnlineRepository :IRepository<SupportOnline>
    {
        //khai báo phương thức riêng cần tạo của table
    }

    public class SupportOnlineRepository : RepositoryBase<SupportOnline>, ISupportOnlineRepository
    {
        //Dùng các phương thức đã được viết sẵn dùng chung
        public SupportOnlineRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        // triển khai các phương thức mới thông qua interface riêng của table
    }
}
using APIShop.Model.Models;
using Data.Infrastructure;

namespace Web.Data.Repositories
{
    public interface IOderDetailRepository :IRepository<OderDetail>
    {
        //khai báo phương thức riêng cần tạo của table
    }

    public class OderDetailRepository : RepositoryBase<OderDetail>, IOderDetailRepository
    {
        //Dùng các phương thức đã được viết sẵn dùng chung
        public OderDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        // triển khai các phương thức mới thông qua interface riêng của table
    }
}
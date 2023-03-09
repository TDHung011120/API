using APIShop.Model.Models;
using Data.Infrastructure;
namespace APIShop.Data.Repositories
{
    
    public interface IVisitorStatisticRepository:IRepository<VisitorStatistic>
    {
        //khai báo phương thức riêng cần tạo của table

    }

    public class VisitorStatisticRepository : RepositoryBase<VisitorStatistic>, IVisitorStatisticRepository
    {
        //Dùng các phương thức đã được viết sẵn dùng chung
        public VisitorStatisticRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        // triển khai các phương thức mới thông qua interface riêng của table

    }
}

using APIShop.Model.Models;
using Data.Infrastructure;

namespace APIShop.Data.Repositories
{
    
    public interface ISlideRepository : IRepository<Slide>
    {
        //khai báo phương thức riêng cần tạo của table

    }

    public class SlideRepository : RepositoryBase<Slide>, ISlideRepository
    {
        //Dùng các phương thức đã được viết sẵn dùng chung
        public SlideRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        // triển khai các phương thức mới thông qua interface riêng của table

    }
}

using APIShop.Model.Models;
using AutoMapper;
using Web.Models;

namespace Web.Mappings
{
    public class AutoMapperConfigurations
    {
        public static void Configre()
        {
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();
        }
    }
}
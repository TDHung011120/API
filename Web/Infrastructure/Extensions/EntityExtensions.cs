using APIShop.Model.Models;
using Web.Models;

namespace Web.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdatePostCategory(this PostCategory postCategory, PostCategoryViewModel postCategoryViewModel)
        {
            postCategory.ID = postCategoryViewModel.ID;
            postCategory.Alias = postCategoryViewModel.Alias;
            postCategory.Name = postCategoryViewModel.Name;
            postCategory.Description = postCategoryViewModel.Description;
            postCategory.DisplayOder = postCategoryViewModel.DisplayOder;
            postCategory.ParentID = postCategoryViewModel.ParentID;
            postCategory.Inage = postCategoryViewModel.Inage;
            postCategory.HomeFlag = postCategoryViewModel.HomeFlag;
            postCategory.CreateDate = postCategoryViewModel.CreateDate;
            postCategory.CreateBy = postCategoryViewModel.CreateBy;
            postCategory.UpdateBy = postCategoryViewModel.UpdateBy;
            postCategory.UpdateDate = postCategoryViewModel.UpdateDate;
            postCategory.Metakeyword = postCategoryViewModel.Metakeyword;
            postCategory.MetaDescription = postCategoryViewModel.MetaDescription;
            postCategory.Status = postCategoryViewModel.Status;
        }

        public static void UpdatePost(this Post post, PostViewModel postViewModel)
        {
            
            post.ID = postViewModel.ID;
            post.Name = postViewModel.Name;
            post.Alias = postViewModel.Alias;
            post.CategoryID = postViewModel.CategoryID;
            post.Description = postViewModel.Description;
            post.DisplayOder = postViewModel.DisplayOder;
            post.Content = postViewModel.Content;
            post.Image = postViewModel.Image;
            post.HomeFlag = postViewModel.HomeFlag;
            post.HotTag = postViewModel.HotTag;
            post.ViewCount = postViewModel.ViewCount;
            post.CreateDate = postViewModel.CreateDate;
            post.CreateBy = postViewModel.CreateBy;
            post.UpdateBy = postViewModel.UpdateBy;
            post.UpdateDate = postViewModel.UpdateDate;
            post.Metakeyword = postViewModel.Metakeyword;
            post.MetaDescription = postViewModel.MetaDescription;
            post.Status = postViewModel.Status;
        }
    }
}
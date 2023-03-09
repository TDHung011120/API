using System;

namespace Web.Models
{
    public class PostViewModel
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int CategoryID { get; set; }

        public string Alias { get; set; }

        public string Description { get; set; }
        public string Content { get; set; }
        public int? DisplayOder { get; set; }

        public string Image { get; set; }

        public bool? HomeFlag { get; set; }
        public bool? HotTag { get; set; }
        public int ViewCount { get; set; }

        public virtual PostCategoryViewModel PostCategory { get; set; }

        public virtual PostTagViewModel PostTags { get; set; }
        public DateTime? CreateDate { get; set; }

        public string CreateBy { set; get; }

        public DateTime? UpdateDate { set; get; }

        public string UpdateBy { set; get; }
        public string Metakeyword { get; set; }
        public string MetaDescription { get; set; }

        public bool Status { get; set; }
    }
}
﻿using APIShop.Model.Models;
using System;
using System.Collections.Generic;

namespace Web.Models
{
    public class ProductCategoryViewModel
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Alias { get; set; }

        public string Description { get; set; }

        public int? ParentID { get; set; }
        public int? DisplayOder { get; set; }
        public string Inage { get; set; }
        public bool? HotFlag { get; set; }

        public DateTime? CreateDate { get; set; }

        public string CreateBy { set; get; }

        public DateTime? UpdateDate { set; get; }

        public string UpdateBy { set; get; }
        public string Metakeyword { get; set; }
        public string MetaDescription { get; set; }

        public bool Status { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
    }
}
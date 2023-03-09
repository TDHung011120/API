using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using APIShop.Model.Models;

namespace APIShop.Model.Abstract
{
    public abstract class AudiTable : IAuditable
    {
        public DateTime? CreateDate { get; set; }

        [MaxLength(250)]
        public string CreateBy { set; get; }

        public DateTime? UpdateDate { set; get; }

        [MaxLength(256)]
        public string UpdateBy { set; get; }
        [MaxLength(256)]
        public string Metakeyword { get; set; }
        [MaxLength(256)]
        public string MetaDescription { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
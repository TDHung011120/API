using APIShop.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIShop.Model.Models
{
    [Table("ProductCategories")]
    public class ProductCategory : AudiTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [Required]
        [MaxLength(250)]
        public string Alias { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }

        public int? ParentID { get; set; }
        public int? DisplayOder { get; set; }
        public string Inage { get; set; }
        public bool? HotFlag { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
    }
}
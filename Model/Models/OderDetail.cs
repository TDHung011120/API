using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIShop.Model.Models
{
    [Table("OderDetails")]
    public class OderDetail
    {
        [Key]
        [Column(Order = 1)]
        public int OderID { get; set; }

        [Key]
        [Column(Order = 2)]
        public int ProductID { get; set; }

        public int Quantity { get; set; } //số lượng

        [ForeignKey("OderID")]
        public virtual Oder Oder { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }

        
    }
}
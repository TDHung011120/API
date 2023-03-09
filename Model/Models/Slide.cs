using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIShop.Model.Models
{
    [Table("Slides")]
    public class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string Description { get; set; }

        [MaxLength(500)]
        [Column(TypeName = "nvarchar")]
        public string Image { get; set; }

        [MaxLength(500)]
        [Column(TypeName = "varchar")]
        public string URL { get; set; }

        public int? DisplayOder { get; set; }
        public bool Status { get; set; }
    }
}
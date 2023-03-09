using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIShop.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        [Required]
        [MaxLength(250)]
        [Column(TypeName = "varchar")]
        public string Description { get; set; }
        [MaxLength(500)]
        public string URL { get; set; }
        
        public int? DisplayOder { get; set; }
        [Required]
        public int GroupID { get; set; }
        [Column(TypeName = "nvarchar")]
        public string Target { get; set; }
        [Required]
        public bool Status { get; set; }
        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroups { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIShop.Model.Models
{
    [Table("Oders")]
    public class Oder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(250)]
        public string CustomerName { get; set; }

        [Required]
        [MaxLength(250)]
        public string CustomerAddress { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(250)]
        public string CustomerEmail { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(10)]
        public string CustomerPhone { get; set; }
        [Required]
        [MaxLength(250)]
        public string CustomerMessage { get; set; }
        public DateTime? CreateDate { get; set; }

        [Required]
        
        [MaxLength(50)]
        public string CreateBy { get; set; }

        [Required]
        
        [MaxLength(50)]
        public string PayMethod { get; set; }

        [Required]
        
        [MaxLength(50)]
        public string PayStatus { get; set; }

        public bool Status { get; set; }

        public virtual IEnumerable<OderDetail> OderDetails { get; set; }
    }
}
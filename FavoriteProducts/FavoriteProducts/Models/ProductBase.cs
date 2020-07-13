using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FavoriteProducts.Models
{
    public class ProductBase
    {
        [Key]
        public int PID { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string ProductNum { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string ProductDescription { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string ProductType { get; set; }

    }
}

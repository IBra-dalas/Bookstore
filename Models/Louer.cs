using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NewResto.Models
{
    [Table("LouerUnLivre")]
    public class Louer
    {
        [Key]
        public int IdLocation { get; set; }
        public virtual Livre Livres { get; set; }
        public virtual Client UnClient { get; set; }
    }
}

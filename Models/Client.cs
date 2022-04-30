
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NewResto.Models
{
    [Table("Client")]
    public class Client
    {
        public string NomClient { get; set; }
        [Key]
        public string Email { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

using System.ComponentModel.DataAnnotations.Schema;

using System.Threading.Tasks;

namespace WebApplication2.Models
{
    [Table("Commande")]
    public class Commande
    {
        public int CommandeId { get; set; }
        [Required]
        [StringLength(50)]
        public int BookId { get; set; }

        [Required]
        [StringLength(50)]
        public string CommandName { get; set; }
    }
}

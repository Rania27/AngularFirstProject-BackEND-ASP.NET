using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplication2.Models
{
    [Table("Book")]
    public class Book
    {
        public int BookId { get; set; }

        [Required]
        [StringLength(50)]
        public string BookName { get; set; }

        [Required]
        [StringLength(50)]
        public string releaseDate { get; set; }

        [Required]
        [StringLength(50)]
        public string description { get; set; }

        [Required]
        public Double price { get; set; }

        [Required]
        public Double starRating { get; set; }

        [Required]
        [StringLength(100)]
        public string imageUrl { get; set; }


    }
}


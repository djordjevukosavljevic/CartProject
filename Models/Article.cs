using Microsoft.Build.Framework;
using RVACart.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace RVACart.Models
{
    public class Article
    {

        public long Id{ get; set; }

        [Required]
        public string Name{ get; set; }

        public string Slug { get; set; }

        public string Description { get; set; }

        [Required]
        public double Price { get; set; }
       
        public Category Category { get; set; }
        
        public int CategoryId { get; set; }

        
    }
}

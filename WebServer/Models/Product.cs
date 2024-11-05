using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace WebServer.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = default!;

        [StringLength(500)]
        public string Description { get; set; } = default!;

        [Required]
        [Range(0, float.MaxValue)]
        public int Vendorcode { get; set; }

        [Required]
        [Range(0, float.MaxValue)]
        public float Price { get; set; }

        [Required]
        [Range(0, float.MaxValue)]
        public int Quantity { get; set; }
    }
}

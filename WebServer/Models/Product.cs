using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebServer.Resources;

namespace WebServer.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessageResourceName = "RequiredError",
            ErrorMessageResourceType = typeof(SharedResources))]
        [StringLength(100)]
        public string Name { get; set; } = default!;

        [Required(ErrorMessageResourceName = "RequiredError",
            ErrorMessageResourceType = typeof(SharedResources))]
        [StringLength(500)]
        public string Description { get; set; } = default!;

        [Required(ErrorMessageResourceName = "RequiredError",
            ErrorMessageResourceType = typeof(SharedResources))]
        [Range(0, float.MaxValue)]
        public int Vendorcode { get; set; }

        [Required(ErrorMessageResourceName = "RequiredError",
            ErrorMessageResourceType = typeof(SharedResources))]
        [Range(0, float.MaxValue)]
        public float Price { get; set; }

        [Required(ErrorMessageResourceName = "RequiredError",
            ErrorMessageResourceType = typeof(SharedResources))]
        [Range(0, float.MaxValue)]
        public int Quantity { get; set; }
    }
}

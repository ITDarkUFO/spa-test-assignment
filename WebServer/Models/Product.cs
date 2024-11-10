using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebServer.Resources;
using WebServer.Resources.Models;

namespace WebServer.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessageResourceName = "RequiredError",
            ErrorMessageResourceType = typeof(SharedResources))]
        [StringLength(100, 
            ErrorMessageResourceName = "Name_LengthError",
            ErrorMessageResourceType = typeof(Resources.Models.Product))]
        public string Name { get; set; } = default!;

        [Required(ErrorMessageResourceName = "RequiredError",
            ErrorMessageResourceType = typeof(SharedResources))]
        [StringLength(500, 
            ErrorMessageResourceName = "Description_LengthError",
            ErrorMessageResourceType = typeof(Resources.Models.Product))]
        public string Description { get; set; } = default!;

        [Required(ErrorMessageResourceName = "RequiredError",
            ErrorMessageResourceType = typeof(SharedResources))]
        [Range(0, float.MaxValue,
            ErrorMessageResourceName = "Vendorcode_MinMaxError", 
            ErrorMessageResourceType = typeof(Resources.Models.Product))]
        public int Vendorcode { get; set; }

        [Required(ErrorMessageResourceName = "RequiredError",
            ErrorMessageResourceType = typeof(SharedResources))]
        [Range(0, float.MaxValue,
            ErrorMessageResourceName = "Price_MinMaxError",
            ErrorMessageResourceType = typeof(Resources.Models.Product))]
        public float Price { get; set; }

        [Required(ErrorMessageResourceName = "RequiredError",
            ErrorMessageResourceType = typeof(SharedResources))]
        [Range(0, float.MaxValue, 
            ErrorMessageResourceName = "Quantity_MinMaxError",
            ErrorMessageResourceType = typeof(Resources.Models.Product))]
        public int Quantity { get; set; }
    }
}

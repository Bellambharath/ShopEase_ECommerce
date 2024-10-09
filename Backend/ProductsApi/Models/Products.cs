using System.ComponentModel.DataAnnotations;

namespace ProductsApi.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
      
        public string ProductCategory { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public double ProductPrice { get; set; }
        public int Noofstocks { get; set; } = 1;
        public string Imageurl { get; set; } 
        public string ProductDescription { get; set; }
        public double ProductRating { get; set; } = 0.0;
        public string SellerName { get; set; } = string.Empty;



    }
}

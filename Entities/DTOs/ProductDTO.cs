using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public decimal? SalePrice { get; set; }
        public string Description { get; set; }
        public int ReviewCount { get; set; }
        public string Summary { get; set; }
        public string SKU { get; set; }
        public string CategoryName { get; set; }
        public string CoverPhoto { get; set; }
        public bool IsStock { get; set; }
        public bool IsSale { get; set; }
        public decimal Rating { get; set; }
        public List<string> ProductPictures { get; set; }
        public List<CommentDTO> Comments { get; set; }
    }
}

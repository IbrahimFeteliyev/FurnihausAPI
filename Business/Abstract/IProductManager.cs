using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductManager
    {
        void AddProduct(AddProductDTO product);
        void Remove(Product product);
        void Update(Product product);
        List<Product> GetAllProducts();
        List<ProductDTO> GetAllProductList();
        ProductDTO GetProductById(int id);
    }
}

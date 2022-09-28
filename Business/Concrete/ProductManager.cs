using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductManager
    {
        private readonly IProductDal _productDal;
        private readonly IProductPictureManager _productPictureManager;

        public ProductManager(IProductDal productDal, IProductPictureManager productPictureManager)
        {
            _productDal = productDal;
            _productPictureManager = productPictureManager;
        }


        public void AddProduct(AddProductDTO productDTO)
        {
            Product product = new()
            {
                Name = productDTO.Name,
                Brand = productDTO.Brand,
                Description = productDTO.Description,
                CategoryId = productDTO.CategoryId,
                Price = productDTO.Price,
                SalePrice = productDTO.SalePrice,
                SKU = productDTO.SKU,
                Summary = productDTO.Summary,
                CoverPhoto = productDTO.CoverPhoto
            };

            _productDal.Add(product);

            for (int i = 0; i < productDTO.ProductPictures.Count; i++)
            {
                productDTO.ProductPictures[i].ProductId = product.Id;
                _productPictureManager.AddProductPicture(productDTO.ProductPictures[i]);
            }
        }

        public List<ProductDTO> GetAllProductList()
        {
            return _productDal.GetAllProduct();
        }

        public List<Product> GetAllProducts()
        {
            return _productDal.GetAll();
        }

        public ProductDTO GetProductById(int id)
        {
            return _productDal.FindById(id);
        }

        public void RemoveProduct(AddProductDTO product, int id)
        {
            var current = _productDal.Get(x => x.Id == id);
            current.Name = product.Name;
            current.Description = product.Description;
            current.Price = product.Price;
            current.CoverPhoto = product.CoverPhoto;
            current.IsStock = product.IsStock;
            current.IsSale = product.IsSale;
            current.Brand = product.Brand;
            current.SalePrice = product.SalePrice;
            current.SKU = product.SKU;
            current.Summary = product.Summary;
            _productDal.Delete(current);
        }

        public void UpdateProduct(AddProductDTO product, int id)
        {
            var current = _productDal.Get(x => x.Id == id);
            current.Name = product.Name;
            current.Description = product.Description;
            current.Price = product.Price;
            current.CoverPhoto = product.CoverPhoto;
            current.IsStock = product.IsStock;
            current.IsSale = product.IsSale;
            current.Brand = product.Brand;
            current.SalePrice = product.SalePrice;
            current.SKU = product.SKU;
            current.Summary = product.Summary;
            _productDal.Update(current);
        }
    }
}

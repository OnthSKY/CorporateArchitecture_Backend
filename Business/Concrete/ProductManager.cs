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
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<ProductDetailsDto> GetAllProductDetails()
        {
            return _productDal.GetProductDetails();
        }

        public Product GetById(int desiredProductId)
        {
            return _productDal.Get(p => p.ProductId == desiredProductId);
        }
    }
}

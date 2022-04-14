using Business.Abstract;
using Business.Constants;
using Core.Results;
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
        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),Messages.ListingSuccessful);
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

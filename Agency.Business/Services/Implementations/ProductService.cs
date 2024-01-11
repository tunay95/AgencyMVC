using Agency.Business.Services.Interfaces;
using Agency.Business.ViewModels.ProductVM;
using Agency.Core.Entities;
using Agency.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Business.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;
        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }
        public async Task<Product> Create(CreateProductVM createProductVM)
        {
            Product product = new Product()
            {
                Title = createProductVM.Title,
                Description = createProductVM.Description,
            };
            await _repo.Create(product);
            await _repo.SaveChanges();
            return product;
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Update(UpdateProductVM updatedProduct)
        {
            throw new NotImplementedException();
        }
    }
}

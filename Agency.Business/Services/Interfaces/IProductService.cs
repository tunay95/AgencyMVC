using Agency.Business.ViewModels.ProductVM;
using Agency.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Business.Services.Interfaces
{
    public interface IProductService
    {
        Task<ICollection<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task<Product> Create(CreateProductVM product);
        Task<Product> Update(UpdateProductVM product);

        void Delete(Product product);
    }
}

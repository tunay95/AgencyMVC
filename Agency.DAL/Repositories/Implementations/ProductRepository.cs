using Agency.Core.Entities;
using Agency.DAL.Context;
using Agency.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Agency.DAL.Repositories.Interfaces.IProductRepository;

namespace Agency.DAL.Repositories.Implementations
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext dbcontext) : base(dbcontext)
        {

        }
    }
}

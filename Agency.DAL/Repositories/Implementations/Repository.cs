using Agency.Core.Entities;
using Agency.Core.Entities.Common;
using Agency.DAL.Context;
using Agency.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.DAL.Repositories.Implementations
{
    public class Repository<T> : IRepository<T> where T : BaseEntity, new()
    {
        private readonly AppDbContext _dbcontext;
        private readonly DbSet<T> _table;

        public DbSet<T> Table => _dbcontext.Set<T>();
        public Repository(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
            _table = _dbcontext.Set<T>();
        }

        public async Task Create(T entity)
        {
            await _table.AddAsync(entity);

        }

        public void Delete(T entity)
        {
            _table.AddAsync(entity);

        }

        public async Task<IQueryable<T>> GetAllAsync()
        {
            IQueryable<T> product = _table;
            return product;
        }

        public async Task<T> GetById(int id)
        {
            return await _table.FindAsync(id);
        }

        public async Task SaveChanges()
        {
            await _dbcontext.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            _table.Update(entity);
        }
    }
}

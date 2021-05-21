using ClassProject.Application.Interface;
using ClassProject.Domain.Entities;
using ClassProject.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject.Application.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> entity;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            entity = _context.Set<T>();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return await entity.Where(predicate).ToListAsync();
        }
        public async Task<IAsyncEnumerable<T>> GetAllAsync()
        {
            var result = entity.AsAsyncEnumerable();
            return await Task.FromResult(result);
        }

        public async Task<T> GetByIdAsync(int Id)
        {
            return await entity.FirstOrDefaultAsync(x => x.Id == Id);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}

using ClassProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject.Application.Interface
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<IAsyncEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
        Task<T> GetByIdAsync(int Id);
        void Update(T entity);
        void Delete(T entity);
    }
}

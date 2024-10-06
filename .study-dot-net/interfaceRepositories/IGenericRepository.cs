using System.Linq.Expressions;

namespace study_this_framework.interfaceRepositories
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> AsQueryable();

        Task<IEnumerable<T>> GetPagedAsync(Func<IQueryable<T>, IOrderedQueryable<T>> orderBy,
            Expression<Func<T, bool>> filter = null, int page = 1, int pageSize = 20,
            params Expression<Func<T, object>>[] includeProperties);

        Task<IEnumerable<T>> GetAllAsync(Func<IQueryable<T>, IOrderedQueryable<T>> orderBy,
            Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] includeProperties);

        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] includeProperties);

        void Delete(T entity);

        void Insert(T entity);

        void Update(T entity);

        void Insert(IEnumerable<T> entities);

        void Update(IEnumerable<T> entities);

        void Delete(IEnumerable<T> entities);



    }
}

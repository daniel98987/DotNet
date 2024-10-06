using Microsoft.EntityFrameworkCore;
using study_this_framework.interfaceRepositories;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace study_this_framework.repositories
{
    public class GenericRepository<T>: IGenericRepository<T> where T : class
    {
        private HospitalDbContext _db;

        public GenericRepository(HospitalDbContext db)
        {
            _db = db;
        }

        private static IQueryable<T> PerformInclusions(IEnumerable<Expression<Func<T, object>>> includeProperties, IQueryable<T> query) => includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));

        public IQueryable<T> AsQueryable() => _db.Set<T>().AsQueryable();

        public async Task<IEnumerable<T>> GetPagedAsync(Func<IQueryable<T>, IOrderedQueryable<T>> orderBy, Expression<Func<T, bool>> filter = null, int page = 1, int pageSize = 20,
            params Expression<Func<T, object>>[] includeProperties)
        {
            if (page < 1) throw new ApplicationException("La pagina debe ser mayor a cero");
            var query = AsQueryable();
            query = PerformInclusions(includeProperties, query);
            if (filter != null)
            {
                query = query.Where(filter);
            }
            query = orderBy(query);
            query = query.Skip((page - 1) * pageSize).Take(pageSize);
            return await query.ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync(Func<IQueryable<T>, IOrderedQueryable<T>> orderBy, Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] includeProperties)
        {
            var query = AsQueryable();
            query = PerformInclusions(includeProperties, query);
            if (filter != null)
            {
                query = query.Where(filter);
            }
            query = orderBy(query);
            return await query.ToListAsync();
        }

        public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] includeProperties)
        {
            var query = AsQueryable();
            query = PerformInclusions(includeProperties, query);
            var item = await query.FirstOrDefaultAsync(where);
            //if (item == null) DataEmpty(query);
            return item;
        }


        public void Delete(T entity) => _db.Set<T>().Remove(entity);

        public void Insert(T entity) => _db.Set<T>().Add(entity);

        public void Update(T entity) => _db.Entry(entity).State = EntityState.Modified;

        public void Insert(IEnumerable<T> entities) => entities.ToList().ForEach(x => _db.Entry(x).State = EntityState.Added);

        public void Update(IEnumerable<T> entities) => entities.ToList().ForEach(x => _db.Entry(x).State = EntityState.Modified);

        public void Delete(IEnumerable<T> entities) => entities.ToList().ForEach(x => _db.Entry(x).State = EntityState.Deleted);


    }
}

using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Create(T obj)
        {
            using var _context = new RestaurantContext();
            _context.Set<T>().AddAsync(obj);
            _context.SaveChanges();
        }

        public void Delete(T obj)
        {
            using var _context = new RestaurantContext();
            _context.Set<T>().Remove(obj);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var _context = new RestaurantContext();
            return _context.Set<T>().ToList();
        }

        public List<T> GetAll(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            using var _context = new RestaurantContext();
            return _context.Set<T>().Where(expression).ToList();
        }

        public T GetById(int id)
        {
            using var _context = new RestaurantContext();
            return _context.Set<T>().Find(id);
        }

        public void Update(T obj)
        {
            using var _context = new RestaurantContext();
            _context.Update(obj);
            _context.SaveChanges();
        }
    }
}

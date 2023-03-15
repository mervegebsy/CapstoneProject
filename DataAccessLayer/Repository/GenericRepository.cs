using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly Context _context;
        private readonly IUOWDal _UOW;

        

        public GenericRepository(Context context) 
        {
            _context = context;
          
        }

        public void Delete(T t)
        {
            _context.Remove(t);
            _UOW.Save();
            
        }

        public T GetByID(int id)
        {
            return _context.Set<T>().Find(id);

        }

        public List<T> GetList()
        {
            return _context.Set<T>().ToList();
        }

        public List<T> GetListByFilter(System.Linq.Expressions.Expression<Func<T, bool>> filter)
        {
            return _context.Set<T>().Where(filter).ToList();
        }

        public void Insert(T t)
        {
            _context.Add(t);
            _UOW.Save();
        }

        public void Update(T t)
        {
            _context.Update(t);
            _UOW.Save();
        }
    }
}

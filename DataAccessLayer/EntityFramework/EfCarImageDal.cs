using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCarImageDal : GenericRepository<CarImage>, ICarImageDal
    {
        private readonly Context _context;
        public EfCarImageDal(Context context) : base(context)
        {
            this._context = context;
        }
        public List<CarImage> GetCarImagesByCarId(int id)
        {
            var values = _context.CarImages.Where(x => x.CarId == id).ToList();
            return values;
        }
    }
}

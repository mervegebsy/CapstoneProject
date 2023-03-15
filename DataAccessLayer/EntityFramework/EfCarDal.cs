using CapstoneProject.DTOLayer.DTOs;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.DataAccessLayer.EntityFramework
{
    public class EfCarDal : GenericRepository<Car>, ICarDal
    {
        private readonly Context _context;
        public EfCarDal(Context context) : base(context)
        {
            this._context = context;
        }

        public List<CarDetailDTO> GetCarDetail()
        {
            var result = from c in _context.Cars
                         join b in _context.Brands on c.BrandId equals b.BrandId
                         join clr in _context.Colors on c.ColorId equals clr.ColorId
                         select new CarDetailDTO
                         {
                             CarName = c.CarName,
                             CarId = c.CarId,
                             BrandName = b.BrandName,
                             ColorName = clr.ColorName,
                             DailyPrice = c.DailyPrice,
                             ModelYear = c.ModelYear,
                             Description = c.Description
                         };
            return result.ToList();
        }
    }
}

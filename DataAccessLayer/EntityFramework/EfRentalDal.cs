using CapstoneProject.DTOLayer.DTOs;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.DataAccessLayer.EntityFramework
{
    public class EfRentalDal : GenericRepository<Rental>, IRentalDal
    {
        private readonly Context _context;


        public EfRentalDal(Context context) : base(context)
        {
            _context = context;
        }
        public List<RentailDetailDTO> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            var result = from r in filter == null ? _context.Rental : _context.Rental.Where(filter)
                         join c in _context.Cars on r.CarId equals c.CarId
                         join b in _context.Brands on c.BrandId equals b.BrandId
                         join cu in _context.Customers on r.CustomerId equals cu.Id
                         join u in _context.Users on cu.UserId equals u.Id
                         select new RentailDetailDTO
                         {
                             Id = r.Id,
                             UserName = u.FirstName + "" + u.LastName,
                             CarName = c.CarName,
                             CompanyName = cu.CompanyName,
                             BrandName = b.BrandName,
                             RentDate = r.RentDate,
                             ReturnDate = r.ReturnDate
                         };
            return result.ToList();
        }
    }
}

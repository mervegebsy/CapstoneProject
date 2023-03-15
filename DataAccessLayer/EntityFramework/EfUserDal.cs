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
    public class EfUserDal: GenericRepository<AppUser>, IUserDal
    {
        private readonly Context _context;
        public EfUserDal(Context context) : base(context)
        {
            _context = context;
        }

        public AppUser GetByMail(Expression<Func<AppUser, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<AppRole> GetRole(AppUser user)
        {
            var result = from appRole in _context.AppRoles
                         join appUserRole in _context.AppUserRoles
                         on appRole.Id equals appUserRole.Id
                         where appUserRole.UserId == user.Id
                         select new AppRole { Id = appRole.Id, Name = appRole.Name };
            return result.ToList();
        }
    }
}

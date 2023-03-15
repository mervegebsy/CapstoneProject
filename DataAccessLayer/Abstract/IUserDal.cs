using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IUserDal: IGenericDal<AppUser>
    {
        List<AppRole> GetRole(AppUser user);
        AppUser GetByMail(Expression<Func<AppUser, bool>> filter = null);
    }
}

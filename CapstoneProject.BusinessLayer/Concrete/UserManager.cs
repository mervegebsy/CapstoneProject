using CapstoneProject.BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<AppRole> GetAppRole(AppUser appUser)
        {
           return  _userDal.GetRole(appUser);
        }

        public AppUser GetByMail(string email)
        {
           return _userDal.GetByMail(x => x.Email == email);
        }

        public void TDelete(AppUser t)
        {
            _userDal.Delete(t);
        }

        public AppUser TGetByID(int id)
        {
            return _userDal.GetByID(id);
        }

        public List<AppUser> TGetList()
        {
            return _userDal.GetList();
        }

        public void TInsert(AppUser t)
        {
            _userDal.Insert(t);
        }

        public void TUpdate(AppUser t)
        {
            _userDal.Update(t);
        }
    }
}

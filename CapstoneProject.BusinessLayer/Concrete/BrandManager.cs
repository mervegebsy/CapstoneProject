using CapstoneProject.BusinessLayer.Abstract;
using CapstoneProject.BusinessLayer.ValidationResult.FluentValidation;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.BusinessLayer.Concrete
{
    public class BrandManager : IBrandService
    {
        
        IBrandDal _brandDal;
        BrandValidator _validationRules;

        public BrandManager(IBrandDal brandDal, BrandValidator validationRules)
        {
            _brandDal = brandDal;
            _validationRules = validationRules;
        }

        public void TDelete(Brand t)
        {
            _brandDal.Delete(t);
        }

        public Brand TGetByID(int id)
        {
            return _brandDal.GetByID(id);
        }

        public List<Brand> TGetList()
        {
            return _brandDal.GetList();
        }
        
        public void TInsert(Brand t)
        {
            _validationRules.Validate(t);
            _brandDal.Insert(t);
            
        }

        public void TUpdate(Brand t)
        {
            _brandDal.Update(t);
        }
    }
}

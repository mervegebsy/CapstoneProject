using CapstoneProject.BusinessLayer.Abstract;
using CapstoneProject.DTOLayer.DTOs;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.BusinessLayer.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public List<RentailDetailDTO> GetAllRentalDetail()
        {
            return _rentalDal.GetRentalDetails();
        }

        public List<RentailDetailDTO> GetByIdRentalDetail(int rentalId)
        {
            return _rentalDal.GetRentalDetails(x => x.Id == rentalId);
        }

        public void TDelete(Rental t)
        {
            _rentalDal.Delete(t);
        }

        public Rental TGetByID(int id)
        {
            return _rentalDal.GetByID(id);
        }

        public List<Rental> TGetList()
        {
            return _rentalDal.GetList();
        }

        public void TInsert(Rental t)
        {
            _rentalDal.Insert(t);
        }

        public void TUpdate(Rental t)
        {
            _rentalDal.Update(t);
        }
    }
}

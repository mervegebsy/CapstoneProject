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
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetListByFilter(x => x.DailyPrice >= min && x.DailyPrice <= max);
        }

        public List<CarDetailDTO> GetCarDetail()
        {
            return _carDal.GetCarDetail();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetListByFilter(x => x.BrandId == id);
        }

        public List<Car> GetCarsByColor(int id)
        {
            return _carDal.GetListByFilter(x => x.ColorId == id);
        }

        public void TDelete(Car t)
        {
            _carDal.Delete(t);
            
        }

        public Car TGetByID(int id)
        {
            return _carDal.GetByID(id);
        }

        public List<Car> TGetList()
        {
            return _carDal.GetList();
        }

        public void TInsert(Car t)
        {
            _carDal.Insert(t);
        }

        public void TUpdate(Car t)
        {
            _carDal.Update(t);
        }
    }
}

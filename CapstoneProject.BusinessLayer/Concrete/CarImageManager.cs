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
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public List<CarImage> GetCarImagesByCarId(int id)
        {
            return _carImageDal.GetCarImagesByCarId(id);
        }

        public void TDelete(CarImage t)
        {
            _carImageDal.Delete(t);
        }

        public CarImage TGetByID(int id)
        {
            return _carImageDal.GetByID(id);
        }

        public List<CarImage> TGetList()
        {
            return _carImageDal.GetList();
        }

        public void TInsert(CarImage t)
        {
            _carImageDal.Insert(t);
        }

        public void TUpdate(CarImage t)
        {
            _carImageDal.Update(t);
        }
    }
}

using CapstoneProject.DTOLayer.DTOs;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.BusinessLayer.Abstract
{
    public interface ICarService : IGenericService<Car>
    {
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColor(int id);
        List<CarDetailDTO> GetCarDetail();
        List<Car> GetByDailyPrice(decimal min, decimal max);
        

    }
}

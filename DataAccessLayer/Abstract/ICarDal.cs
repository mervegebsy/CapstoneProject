using CapstoneProject.DTOLayer.DTOs;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICarDal:IGenericDal<Car>
    {
        List<CarDetailDTO> GetCarDetail();

    }
}

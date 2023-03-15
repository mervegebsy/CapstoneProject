using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.BusinessLayer.Abstract
{
    public interface ICarImageService: IGenericService<CarImage>
    {
        List<CarImage> GetCarImagesByCarId(int id);
    }
}

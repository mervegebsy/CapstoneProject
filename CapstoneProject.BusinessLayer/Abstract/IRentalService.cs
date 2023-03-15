using CapstoneProject.DTOLayer.DTOs;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.BusinessLayer.Abstract
{
    public interface IRentalService: IGenericService<Rental>
    {
        List<RentailDetailDTO> GetAllRentalDetail();
        List<RentailDetailDTO> GetByIdRentalDetail(int rentalId);
    }
}

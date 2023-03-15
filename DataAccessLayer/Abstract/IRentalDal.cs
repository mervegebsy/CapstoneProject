using CapstoneProject.DTOLayer.DTOs;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRentalDal : IGenericDal<Rental>
    {
        List<RentailDetailDTO> GetRentalDetails(Expression<Func<Rental, bool>> filter = null);
        
    }
}

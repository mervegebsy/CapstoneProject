
using CapstoneProject.DataAccessLayer.EntityFramework;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.BusinessLayer.ValidationResult.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        
        public RentalValidator()
        {
            RuleFor(r => r.CarId).NotEmpty();
            RuleFor(r => r.CustomerId).NotEmpty();
            RuleFor(r => r.RentDate).NotEmpty();
        }
       
    }
   

}

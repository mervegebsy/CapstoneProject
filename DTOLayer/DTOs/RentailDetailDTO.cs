using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.DTOLayer.DTOs
{
    public class RentailDetailDTO
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string BrandName { get; set; }
        public string CarName { get; set; }
        public string UserName { get; set; }
        public string CompanyName { get; set; }
        public string CustomerName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}

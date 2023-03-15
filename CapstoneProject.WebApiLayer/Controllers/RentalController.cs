using CapstoneProject.BusinessLayer.Abstract;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneProject.WebApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalController : ControllerBase
    {
        IRentalService _rentalService;

        public RentalController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _rentalService.TGetByID(id);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _rentalService.TGetList();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Rental rental)
        {
            try
            {
                _rentalService.TInsert(rental);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest("Kaydedilemedi");
            }
        }
        [HttpPost("delete")]
        public IActionResult Delete(Rental rental)
        {
            try
            {
                _rentalService.TDelete(rental);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest("Silinemedi");
            }


        }
        [HttpPost("update")]
        public IActionResult Update(Rental rental)
        {
            try
            {
                _rentalService.TUpdate(rental);
                return Ok();
            }
            catch
            {
                return BadRequest("Güncellenemedi");
            }
        }
        [HttpGet("getbyidrentaldetail")]
        public IActionResult GetByIdRentalDetail(int id)
        {
            try
            {
                _rentalService.GetByIdRentalDetail(id);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpGet("getallrentaldetail")]
        public IActionResult GetAllRentalDetail()
        {
            try
            {
                _rentalService.GetAllRentalDetail();
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}

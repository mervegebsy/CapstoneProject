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
    public class CarController : ControllerBase
    {
        ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _carService.TGetByID(id);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carService.TGetList();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            try
            {
                _carService.TInsert(car);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest("Kaydedilemedi");
            }
        }
        [HttpPost("delete")]
        public IActionResult Delete(Car car)
        {
            try
            {
                _carService.TDelete(car);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest("Silinemedi");
            }


        }
        [HttpPost("update")]
        public IActionResult Update(Car car)
        {
            try
            {
                _carService.TUpdate(car);
                return Ok();
            }
            catch
            {
                return BadRequest("");
            }
        }
        [HttpGet("getcardetail")]
        public IActionResult GetCarDetail()
        {
            try
            {
                _carService.GetCarDetail();
                return Ok();
            }
            catch
            {
                return BadRequest("Car detail does not exist");
            }
        }
        [HttpGet("getbydailyprice")]
        public IActionResult GetByDailyPrice(decimal min, decimal max)
        {
            try
            {
                _carService.GetByDailyPrice(min,max);
                return Ok();
            }
            catch
            {
                return BadRequest("Daily price does not exist");
            }
        }
        [HttpGet("getcarsbycolorid")]
        public IActionResult GetCarsByColorId(int id)
        {
            try
            {
                _carService.GetCarsByColor(id);
                return Ok();
            }
            catch
            {
                return BadRequest("Car does not exist");
            }
        }
        [HttpGet("getcarsbybrandid")]
        public IActionResult GetCarsByBrandId(int id)
        {
            try
            {
                _carService.GetCarsByBrandId(id);
                return Ok();
            }
            catch
            {
                return BadRequest("Car does not exist");
            }
        }


    }
}


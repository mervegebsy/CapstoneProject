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
    public class CarImageController : ControllerBase
    {
        ICarImageService _carImageService;

        public CarImageController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _carImageService.TGetByID(id);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carImageService.TGetList();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(CarImage carImage)
        {
            try
            {
                _carImageService.TInsert(carImage);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest("Kaydedilemedi");
            }
        }
        [HttpPost("delete")]
        public IActionResult Delete(CarImage carImage)
        {
            try
            {
                _carImageService.TDelete(carImage);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest("Silinemedi");
            }


        }
        [HttpPost("update")]
        public IActionResult Update(CarImage carImage)
        {
            try
            {
                _carImageService.TUpdate(carImage);
                return Ok();
            }
            catch
            {
                return BadRequest("Güncellenemedi");
            }
        }
        [HttpGet("getimagesbycarid")]
        public IActionResult GetImagesById(int carId)
        {
            var result = _carImageService.GetCarImagesByCarId(carId);
            try
            {
                _carImageService.GetCarImagesByCarId(carId);
                return Ok();
            }
            catch
            {
                return BadRequest("Güncellenemedi");
            }
        }
    }
}

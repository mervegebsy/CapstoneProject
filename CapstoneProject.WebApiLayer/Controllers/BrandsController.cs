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
    public class BrandsController : ControllerBase
    {
        
        IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _brandService.TGetByID(id);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _brandService.TGetList();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Brand brand)
        {
            try
            {
                _brandService.TInsert(brand);
                return Ok();
            }
            catch(Exception e)
            {
                return BadRequest("Kaydedilemedi");
            }
        }
        [HttpPost("delete")]
        public IActionResult Delete(Brand brand)
        {
            try
            {
                _brandService.TDelete(brand);
                return Ok();
            }
            catch(Exception e)
            {
                return BadRequest("Silinemedi");
            }
            
            
        }
        [HttpPost("update")]
        public IActionResult Update(Brand brand)
        {
            try
            {
                _brandService.TUpdate(brand);
                return Ok();
            }
            catch
            {
                return BadRequest("Güncellenemedi");
            }
        }

    }
}

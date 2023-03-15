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
    public class ColorController : ControllerBase
    {
        IColorService _colorService;

        public ColorController(IColorService colorService)
        {
            _colorService = colorService;
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _colorService.TGetByID(id);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _colorService.TGetList();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Color color)
        {
            try
            {
                _colorService.TInsert(color);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest("Kaydedilemedi");
            }
        }
        [HttpPost("delete")]
        public IActionResult Delete(Color color)
        {
            try
            {
                _colorService.TDelete(color);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest("Silinemedi");
            }


        }
        [HttpPost("update")]
        public IActionResult Update(Color color)
        {
            try
            {
                _colorService.TUpdate(color);
                return Ok();
            }
            catch
            {
                return BadRequest("Güncellenemedi");
            }
        }
    }
}

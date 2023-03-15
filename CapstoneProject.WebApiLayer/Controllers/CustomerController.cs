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
    public class CustomerController : ControllerBase
    {
        ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _customerService.TGetByID(id);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _customerService.TGetList();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Customer customer)
        {
            try
            {
                _customerService.TInsert(customer);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest("Kaydedilemedi");
            }
        }
        [HttpPost("delete")]
        public IActionResult Delete(Customer customer)
        {
            try
            {
                _customerService.TDelete(customer);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest("Silinemedi");
            }


        }
        [HttpPost("update")]
        public IActionResult Update(Customer customer)
        {
            try
            {
                _customerService.TUpdate(customer);
                return Ok();
            }
            catch
            {
                return BadRequest("Güncellenemedi");
            }
        }
    }

}

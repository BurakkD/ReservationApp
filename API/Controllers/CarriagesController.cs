using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarriagesController : ControllerBase
    {
        ICarriageService _carriageService;
        

        public CarriagesController(ICarriageService carriageService)
        {
            _carriageService = carriageService;
            
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carriageService.GetAll();
            return Ok(result);
        }
       

        [HttpPost("add")]
        public IActionResult Add(Carriage carriage)
        {
            _carriageService.Add(carriage);
            return Ok("işlem başarılı");
        }

        [HttpPost("delete")]
        public IActionResult Delete(Carriage carriage)
        {
            _carriageService.Delete(carriage);
            return Ok("İşlem Başarılı");
        }

        [HttpPost("update")]
        public IActionResult Update(Carriage carriage)
        {
            _carriageService.Update(carriage);
            return Ok("İşlem Başarılı");
        }



    }
}

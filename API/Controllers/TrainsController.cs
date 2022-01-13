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
    public class TrainsController : ControllerBase
    {
        ITrainService _trainService;
        public TrainsController(ITrainService trainService)
        {
            _trainService = trainService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _trainService.GetAll();
            return Ok(result);
        }
        [HttpGet("get")]
        public IActionResult Get(Train train)
        {
           _trainService.Get(train);
            return Ok("işlem başarılı");
        }

        [HttpPost("add")]
        public IActionResult Add(Train train)
        {
            _trainService.Add(train);
            return Ok("işlem başarılı");
        }

        [HttpPost("delete")]
        public IActionResult Delete(Train train)
        {
            _trainService.Delete(train);
            return Ok("İşlem Başarılı");
        }

        [HttpPost("update")]
        public IActionResult Update(Train train)
        {
            _trainService.Update(train);
            return Ok("İşlem Başarılı");
        }


    }
}

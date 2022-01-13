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
    public class TicketsController : ControllerBase
    {

        ITicketService _ticketService;

        public TicketsController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _ticketService.GetAll();
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Ticket ticket)
        {

           _ticketService.Add(ticket);
            return Ok("işlem Başarılı");


        }

        [HttpPost("delete")]
        public IActionResult Delete(Ticket ticket)
        {
            _ticketService.Delete(ticket);
            return Ok("İşlem Başarılı");
        }

        [HttpPost("update")]
        public IActionResult Update(Ticket ticket)
        {
            _ticketService.Update(ticket);
            return Ok("İşlem Başarılı");
        }

    }
}

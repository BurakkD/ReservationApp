using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ITicketService
    {
        List<Ticket> GetAll();
        void Add(Ticket ticket);
        void Delete(Ticket ticket);
        void Update(Ticket ticket);
    }
}

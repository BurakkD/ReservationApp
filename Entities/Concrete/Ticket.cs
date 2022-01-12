using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Ticket:IEntity
    {

        public int TicketId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TrainId { get; set; }
        public int CarriageId { get; set; }

    }
}

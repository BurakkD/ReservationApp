using Core;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
   public class TicketValidation:AbstractValidator<Ticket>
    {
        public TicketValidation()
        {

            RuleFor(c => c.FirstName).NotEmpty();
            RuleFor(c => c.LastName).NotEmpty();
            RuleFor(c => c.TicketId).GreaterThan(0);
            RuleFor(c => c.CarriageId).GreaterThan(0);
            RuleFor(c => c.TrainId).GreaterThan(0);
            


        }

       
    }
}

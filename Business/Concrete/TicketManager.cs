using Business.Abstract;
using Core;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class TicketManager : ITicketService
    {
        ITicketDal _ticketDal;
        ICarriageService _carriageService;
        ITrainService _trainService;
        public TicketManager(ITicketDal ticketDal, ICarriageService carriageService, ITrainService trainService)
        {
            _ticketDal = ticketDal;
            _carriageService = carriageService;
            _trainService = trainService;
        }
        public void Add(Ticket ticket, Carriage carriage, Train train)
        {
            ValidationTool.Validate(new TicketValidation(), ticket);
            if (ticket.TrainId == 1)
            {
                if (ticket.CarriageId == 1)
                {
                    train.TrainId = 1;
                    carriage.CarriageId = 1;
                    _ticketDal.Add(ticket);
                    _carriageService.Update(carriage);                  
                    _trainService.Get(train);


                }
                if (ticket.CarriageId == 2)
                {
                    train.TrainId = 1;
                    carriage.CarriageId = 2;
                    _carriageService.Update(carriage);
                    _ticketDal.Add(ticket);
                    _trainService.Get(train);

                }
                if (ticket.CarriageId == 3)
                {
                    train.TrainId = 1;
                    carriage.CarriageId = 3;
                    _carriageService.Update(carriage);
                    _ticketDal.Add(ticket);
                    _trainService.Get(train);

                }
            }
            if (ticket.TrainId == 2)
            {
                if (ticket.CarriageId == 1)
                {
                    train.TrainId = 2;
                    carriage.CarriageId = 1;
                    _carriageService.Update(carriage);
                    _ticketDal.Add(ticket);
                    _trainService.Get(train);


                }
                if (ticket.CarriageId == 2)
                {
                    train.TrainId = 2;
                    carriage.CarriageId = 2;
                    _carriageService.Update(carriage);
                    _ticketDal.Add(ticket);
                    _trainService.Get(train);

                }
                if (ticket.CarriageId == 3)
                {
                    train.TrainId = 2;
                    carriage.CarriageId = 3;
                    _carriageService.Update(carriage);
                    _ticketDal.Add(ticket);
                    _trainService.Get(train);

                }

            }
            if (ticket.TrainId == 3)
            {
                if (ticket.CarriageId == 1)
                {
                    train.TrainId = 3;
                    carriage.CarriageId = 1;
                    _carriageService.Update(carriage);
                    _ticketDal.Add(ticket);
                    _trainService.Get(train);


                }
                if (ticket.CarriageId == 2)
                {
                    train.TrainId = 3;
                    carriage.CarriageId = 2;
                    _carriageService.Update(carriage);
                    _ticketDal.Add(ticket);
                    _trainService.Get(train);

                }
                if (ticket.CarriageId == 3)
                {
                    train.TrainId = 3;
                    carriage.CarriageId = 3;
                    _carriageService.Update(carriage);
                    _ticketDal.Add(ticket);
                    _trainService.Get(train);

                }

            }
            
        }

        public void Delete(Ticket ticket)
        {
            _ticketDal.Delete(ticket);
        }

        public List<Ticket> GetAll()
        {
            return _ticketDal.GetAll();
        }

        public void Update(Ticket ticket)
        {
            _ticketDal.Update(ticket);
            
        }
    }
}

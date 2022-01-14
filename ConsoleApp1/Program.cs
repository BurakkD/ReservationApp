using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Carriage carriagee = new Carriage();
            Ticket tickett = new Ticket();           
            Train trainn = new Train();
          
            CarriageManager carriageManager = new CarriageManager(new EfCarriageDal());
            TicketManager ticketManager = new TicketManager(new EfTicketDal(), new CarriageManager(new EfCarriageDal()),new TrainManager(new EfTrainDal()));
            TrainManager trainManager = new TrainManager(new EfTrainDal());

            
            tickett.FirstName = "Burak";
            tickett.LastName = "Öner";
            tickett.TicketId = 16;
            tickett.TrainId = 3;
            tickett.CarriageId = 3;

                                    
            ticketManager.Add(tickett);



           






        }
    }
}

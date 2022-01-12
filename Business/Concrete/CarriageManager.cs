using Business.Abstract;
using Core;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CarriageManager : ICarriageService
    {

        ICarriageDal _carriageDal;
        //EfCarriageDal efcarrigadal = new EfCarriageDal();
      


        public CarriageManager(ICarriageDal carriageDal)
        {
            _carriageDal = carriageDal;
        }
        public void Add(Carriage carriage)
        {


            _carriageDal.Add(carriage);
           

        }

        public void Delete(Carriage carriage)
        {
            _carriageDal.Delete(carriage);
        }

        public void GetById(Carriage carriage)
        {

           
                

        }

        public List<Carriage> GetAll(Carriage carriage)
        {
            
           return _carriageDal.GetAll();
           
                         
           
        }

        public void Update(Carriage carriage)
        {
            NewMethod(carriage);

        }

        private void NewMethod(Carriage carriage)
        {
            if (carriage.CarriageId == 1)
            {
                carriage.CarriageName = "Vagon1";
                carriage.CarriageCapacity = 100;
                var result = _carriageDal.Get(c => c.CarriageId == carriage.CarriageId);
                if (result.CarriageSeat < 70)
                {
                    carriage.CarriageSeat = result.CarriageSeat += 1;
                    _carriageDal.Update(carriage);
                    Console.WriteLine("Vagon İsmi:" + result.CarriageName);

                }
                else
                {

                    Console.WriteLine("Vagon Kapasitesi Dolmuştur");
                }
            }
          
            if (carriage.CarriageId == 2)
            {
                carriage.CarriageName = "Vagon2";
                carriage.CarriageCapacity = 90;
                var result = _carriageDal.Get(c => c.CarriageId == carriage.CarriageId);
                if (result.CarriageSeat < 63)
                {
                    carriage.CarriageSeat = result.CarriageSeat += 1;
                    _carriageDal.Update(carriage);
                    Console.WriteLine("Vagon İsmi:"+ carriage.CarriageName);

                }
                else
                {

                    Console.WriteLine("Vagon Kapasitesi Dolmuştur");
                }

            }
            if (carriage.CarriageId == 3)
            {
                carriage.CarriageName = "Vagon3";
                carriage.CarriageCapacity = 80;
                var result = _carriageDal.Get(c => c.CarriageId == carriage.CarriageId);
                if (result.CarriageSeat < 56)
                {
                    carriage.CarriageSeat = result.CarriageSeat += 1;
                    _carriageDal.Update(carriage);
                    Console.WriteLine("Vagon İsmi:"+ result.CarriageName);
                }

                else
                {

                    Console.WriteLine("Vagon Kapasitesi Dolmuştur");
                }
            }
        }

    }
}

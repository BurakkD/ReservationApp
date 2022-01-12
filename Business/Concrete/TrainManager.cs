using Business.Abstract;
using Core;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class TrainManager : ITrainService
    {
        ITrainDal _trainDal;
        public TrainManager(ITrainDal trainDal)
        {
            _trainDal = trainDal;
        }
        public void Add(Train train)
        {
           
        }

        public void Delete(Train train)
        {
            _trainDal.Delete(train);
        }

        public void Get(Train train)
        {
            var result = _trainDal.Get(t => t.TrainId == train.TrainId);
            Console.WriteLine("Tren Adı:"+result.TrainName);
        }

        public List<Train> GetAll()
        {
          return  _trainDal.GetAll();
        }

        public void Update(Train train)
        {
            _trainDal.Update(train);
        }
    }
}

using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ITrainService
    {
        List<Train> GetAll();
        void Add(Train train);
        void Delete(Train train);
        void Update(Train train);
        void Get(Train train);
    }
}

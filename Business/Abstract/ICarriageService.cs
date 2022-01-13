using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
   public interface ICarriageService
    {
        List<Carriage> GetAll();
        Carriage GetById(Carriage carriage);
        void Add(Carriage carriage);
         void Update(Carriage carriage);
        void Delete(Carriage carriage);
        

    }
}

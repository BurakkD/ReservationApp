using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Carriage:IEntity
    {
       
        public int CarriageId { get; set; }
        public string CarriageName { get; set; }
        public int CarriageCapacity { get; set; }
        public int CarriageSeat { get; set; }
    }
}

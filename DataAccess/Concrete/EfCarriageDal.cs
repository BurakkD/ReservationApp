using Core;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfCarriageDal : EntityFramework<Carriage, SQLConnect>, ICarriageDal
    {
       

        }
    }


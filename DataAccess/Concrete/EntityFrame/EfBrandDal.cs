﻿using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFrame
{
   public class EfBrandDal:EfRepositoryBase<Brand,NorthwindContext>,IBrandDal
    {



    }
}

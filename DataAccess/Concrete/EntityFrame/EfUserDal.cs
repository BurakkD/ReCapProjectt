using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFrame
{
    public class EfUserDal :EfRepositoryBase<User,NorthwindContext>, IUserDal
    {

        
    }
}

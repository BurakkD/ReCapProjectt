using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal userDal;

        public UserManager(IUserDal _userDal)
        {
            userDal = _userDal;
        }
        public IResult Add(User user)
        {
            userDal.Add(user);
            return new SuccessResult("işlem başarılı");
        }

        public IResult Delete(User user)
        {
            userDal.Delete(user);
            return new SuccessResult("işlem başarılı");
        }

        public IDataResult<List<User>> GettAll()
        {
            return new SuccessDataResult<List<User>>(userDal.GetAll(), "işlem başarılı");
        }

        public IResult Update(User user)
        {
            userDal.Update(user);
            return new SuccessResult("işlem başarılı");
        }

    }
}

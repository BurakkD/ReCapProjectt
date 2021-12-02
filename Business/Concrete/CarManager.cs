using Business.Abstract;
using Business.Const;
using Core.Utilities.Result;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _cardal;
       
        
        public CarManager(ICarDal cardal)
        {
            _cardal = cardal;
        }

        

        public IResult Add(Car car)
        {

           
           _cardal.Add(car);
           return new SuccessResult(Message.SuccessMessage);

        }

        public IResult Delete(Car car)
        {
            _cardal.Delete(car);
            return new SuccessResult(Message.SuccessMessage);
        }

        public IDataResult<List<Car>> GetAll()
        {
            
            return new SuccessDataResult<List<Car>>(_cardal.GetAll(),"başarılı");
            
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int Id)
        {
           return new SuccessDataResult<List<Car>>(_cardal.GetAll(c => c.BrandsId == Id),"işlem başarılı");
            
        }

        public IDataResult<List<Car>> GetCarsByColorId(int Id)
        {
            return new SuccessDataResult<List<Car>> (_cardal.GetAll(c => c.ColorsId == Id),"işlem başarılı");
        }
    }
}

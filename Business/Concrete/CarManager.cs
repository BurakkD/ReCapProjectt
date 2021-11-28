using Business.Abstract;
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

        

        public void Add(Car car)
        {
            if (car.Description.Length>2 )
            {
                _cardal.Add(car);
                
                
                Console.WriteLine(car.Id);
            }
        }

        public void Delete(Car car)
        {
            _cardal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _cardal.GetAll();
            
        }

        public List<Car> GetCarsByBrandId(int Id)
        {
           return _cardal.GetAll(c => c.BrandsId == Id);
            
        }

        public List<Car> GetCarsByColorId(int Id)
        {
            return _cardal.GetAll(c => c.ColorsId == Id);
        }
    }
}

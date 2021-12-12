using Business.Concrete;
using DataAccess.Concrete.EntityFrame;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //carManager();

            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //foreach (var item in colorManager.GetAll())
            //{
            //    Console.WriteLine(item.ColorName);
            //}
            //static void carManager()
            //{
            //    Car carss = new Car();
            //    CarManager carmanager = new CarManager(new EfCarDal());

            //    carss.Id = 6;
            //    carss.BrandsId = 6;
            //    carss.ColorsId = 6;
            //    carss.Description = "cıtroe";
            //    carmanager.Delete(carss);

            //    foreach (var item in carmanager.GetAll())
            //    {
            //        Console.WriteLine(item.Description);
            //    }
            //}

        }

        public static void carManager()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var item in carManager.GetAll().Data)
            {
                
                Console.WriteLine(item.Description);
            }
            

        }
    }
}

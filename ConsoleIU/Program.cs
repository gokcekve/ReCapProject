using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleIU
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());            

            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine(c.Description);
            }

            //TO ADD A NEW CAR:
            /*
            Car car = new Car()
            {
                Id = 7,
                BrandId = 2,
                ColorId = 5,
                DailyPrice = 150,
                Description = "family size",
                ModelYear = "2019"
            };
                        
            carManager.Add(car);
            Console.WriteLine("\n**The new car is added.");
            */       

        }
    }
}

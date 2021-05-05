using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=1, DailyPrice=100, ModelYear="2010", Description="standart model"},
                new Car{Id=2, BrandId=1, ColorId=2, DailyPrice=120, ModelYear="2015", Description="front-wheel"},
                new Car{Id=3, BrandId=2, ColorId=2, DailyPrice=150, ModelYear="2018", Description="8 seats"},
                new Car{Id=4, BrandId=3, ColorId=1, DailyPrice=250, ModelYear="2020", Description="8 bass speakers"},
                new Car{Id=5, BrandId=3, ColorId=3, DailyPrice=200, ModelYear="2019", Description="front-wheel"},
                new Car{Id=6, BrandId=4, ColorId=4, DailyPrice=100, ModelYear="2013", Description="standar model"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete=_cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}

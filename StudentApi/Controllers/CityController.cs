using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentApi.Models;

namespace StudentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        StudentCRMContext db;
        public CityController()
        {
            db = new StudentCRMContext();
        }
        [HttpGet]
        public List<City> GetAll()
        {
           return db.City.ToList();
        }

        [HttpGet("{id}")]
        public City Get(int id)
        {
           return db.City.Find(id);

        }

        [HttpPost]
        public City Post(City city)         
        {
            city.CityName = city.CityName;
            city.CountryId = city.CountryId;
            db.City.Add(city);
            
            db.SaveChanges();
            return city;
        }

        [HttpDelete]
        public City Dell(int id)
        {
            City city = db.City.Find(id);
            db.City.Remove(city);
            db.SaveChanges();
            return city;
        }

        

    }


}

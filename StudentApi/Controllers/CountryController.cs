using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using StudentApi.Models;

namespace StudentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        StudentCRMContext db;
        public CountryController()
        {
            db = new StudentCRMContext();
        }
        [HttpGet]
        public List<Country> GetAll()
        {
            return db.Country.ToList();
        }

        [HttpGet("id")]
        public Country Get(int id)
        {
            return db.Country.Find(id);
        }

        [HttpPost]
        public Country Add(Country country)
        {
            country.CountryName = country.CountryName;
            db.Country.Add(country);
            db.SaveChanges();
            return country;
        }

        [HttpDelete]
        public Country Dell(int id)
        {
           Country country= db.Country.Find(id);
            db.Country.Remove(country);
            db.SaveChanges();
            return country;
        }
      
      


    }
}

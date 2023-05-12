using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentApi.Models;

namespace StudentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniversityController : ControllerBase
    {
        StudentCRMContext db;

        public UniversityController()
        {
            db = new StudentCRMContext();
        }

        [HttpGet]
        public List<University> GetAll()
        {
            return db.University.ToList();
        }

        [HttpGet("id")]
        public University Get(int id)
        {
           return db.University.Find(id);
        }

        [HttpPost]
        public University Add(University university)
        {
            university.Name = university.Name;
            db.University.Add(university);
            db.SaveChanges();
            return university;

        }

        [HttpDelete]
        public University Dell(int id)
        {
            University university = db.University.Find(id);
            db.University.Remove(university);
            db.SaveChanges();
            return university;
        }


    }

}

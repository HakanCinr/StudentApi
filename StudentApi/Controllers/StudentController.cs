using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentApi.Models;
using StudentApi.Models.Dtos;
using System.Linq.Expressions;

namespace StudentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        StudentCRMContext db;

        public StudentController() 
        {
            db = new StudentCRMContext();
        }

        [HttpGet]
        public List<Student> GetAll()
        {
            return db.Students.ToList();
        }

        [HttpGet("{id}")]
            public Student Get(int id)
        {
            return db.Students.Find(id);
        }

        [HttpPost]
        public Student Post(Student student)
        {            
            student.Name = student.Name;
            student.Surname = student.Surname;
            student.Email = student.Email;
            student.Phone = student.Phone;
            student.Address = student.Address;
            
            db.Students.Add(student);
            db.SaveChanges();

            return student;
        }

        [HttpDelete]
        public Student Delete(int id)
        {
            Student student = db.Students.Find(id);
            db.Students.Remove(student);
            db.SaveChanges();
            return student;
        }

        [HttpPost("sfc")]
        public Student AddAll(StudentDto sfc)
        {
            Student student = new Student();
            Address address = new Address();
            City city = new City();
            Country country = new Country();
            University university = new University();

            student.Name = sfc.Name;
            student.Surname = sfc.Surname;
            student.Email = sfc.Email;
            student.Phone = sfc.Phone;
            address.AddressName = sfc.Address;
            address.Street = sfc.Street;
            address.Descripiton = sfc.Descripiton;
            city.CityName = sfc.City;
            country.CountryName = sfc.Country;
            university.Name = sfc.University;

            db.Students.Add(student);
            db.Address.Add(address);
            db.City.Add(city);
            db.Country.Add(country);
            db.University.Add(university);
            db.SaveChanges();

            return student;




        }


    }
}

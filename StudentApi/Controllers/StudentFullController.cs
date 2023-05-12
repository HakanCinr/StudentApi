using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentApi.Models;

namespace StudentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentFullController : ControllerBase
    {
        StudentCRMContext db;
        public StudentFullController()
        {
            db = new StudentCRMContext();
        }







    }
}

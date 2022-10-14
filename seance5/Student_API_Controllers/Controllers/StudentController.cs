using Microsoft.AspNetCore.Mvc;

namespace Student_API_Controllers.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class StudentController : ControllerBase
    {
        private static List<Student> _students = new List<Student>()
        {
            new Student { Id = 1, FirstName = "Paul", LastName = "Ochon", Birthdate = new DateTime(1950, 12, 1) },
            new Student { Id = 2, FirstName = "Daisy", LastName = "Drathey", Birthdate = new DateTime(1970, 12, 1) },
            new Student { Id = 3, FirstName = "Elie", LastName = "Coptaire", Birthdate = new DateTime(1980, 12, 1) }
        };


        [HttpGet("all")]
        public ActionResult<Student> listAll()
        {
            return Ok(_students);
        }

        [HttpPost("{student}")]
        public ActionResult ajout([FromBody]Student student)
        {
            _students.Add(student);
            return Ok(_students.Last());
        }

        [HttpGet("{id}")]
        public ActionResult getOne(int id)
        {
            return Ok(_students.Find(n => n.Id == id));
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using TEACHERAPI.Model.Entyties;
using TEACHERAPI.DBContex;
using TEACHERAPI.DTO;

namespace TEACHERAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherController : ControllerBase
    {
        private readonly TEACHERContext _aPIContex;

        public TeacherController(TEACHERContext aPIContex)
        {
            _aPIContex = aPIContex;
        }

        // GET ALL
        [HttpGet]
        public IActionResult GetAllTeachers()
        {
            var teachers = _aPIContex.Teachers
                .Select(t => new TeacherDTO
                {
                    Id = t.Id,
                    FirstName = t.FirstName,
                    LastName = t.LastName,
                    Email = t.Email,
                    PhoneNumber = t.PhoneNumber
                }).ToList();

            return Ok(teachers);
        }

        // GET BY ID
        [HttpGet("{id}")]
        public IActionResult GetTeacherById(int id)
        {
            var teacher = _aPIContex.Teachers
                .Where(t => t.Id == id)
                .Select(t => new TeacherDTO
                {
                    Id = t.Id,
                    FirstName = t.FirstName,
                    LastName = t.LastName,
                    Email = t.Email,
                    PhoneNumber = t.PhoneNumber
                }).FirstOrDefault();

            if (teacher == null)
                return NotFound($"Teacher with id {id} not found");

            return Ok(teacher);
        }

        // POST
        [HttpPost]
        public IActionResult CreateTeacher([FromBody] TeacherDTO teacherDto)
        {
            var teacher = new Teacher
            {
                FirstName = teacherDto.FirstName,
                LastName = teacherDto.LastName,
                Email = teacherDto.Email,
                PhoneNumber = teacherDto.PhoneNumber
            };

            _aPIContex.Teachers.Add(teacher);
            _aPIContex.SaveChanges();

            return Ok(teacher.Id);
        }

        // PUT
        [HttpPut("{id}")]
        public IActionResult UpdateTeacher(int id, [FromBody] TeacherDTO teacherDto)
        {
            var teacher = _aPIContex.Teachers.FirstOrDefault(t => t.Id == id);
            if (teacher == null)
                return NotFound($"Teacher with id {id} not found");

            teacher.FirstName = teacherDto.FirstName;
            teacher.LastName = teacherDto.LastName;
            teacher.Email = teacherDto.Email;
            teacher.PhoneNumber = teacherDto.PhoneNumber;

            _aPIContex.SaveChanges();
            return NoContent();
        }

        // DELETE
        [HttpDelete("{id}")]
        public IActionResult DeleteTeacher(int id)
        {
            var teacher = _aPIContex.Teachers.FirstOrDefault(t => t.Id == id);
            if (teacher == null)
                return NotFound($"Teacher with id {id} not found");

            _aPIContex.Teachers.Remove(teacher);
            _aPIContex.SaveChanges();

            return NoContent();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using MudBlazorWASM.Server.Data;


namespace MudBlazorWASM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly SchooldbContext _context;

        public StudentController(SchooldbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetStudent")]
        public async Task<ActionResult<List<Student>>> GetStudent()
        {
            var Students = await _context.Students.ToListAsync();
            return Ok(Students);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetSingleStudent(int id)
        {
            var stud = await _context.Students
            //.Include(s=> s.Grades)
            .FirstOrDefaultAsync(s => s.Studno == id);
            if (stud == null)
            {
                return NotFound("No Student with this Id. :/");
            }
            return Ok(stud);
        }

        [HttpPost]
        public async Task<ActionResult<List<Student>>> CreateStudent(Student stud)
        {

            _context.Students.Add(stud);
            await _context.SaveChangesAsync();

            return Ok(await GetDbStudents());
        }
        private async Task<List<Student>> GetDbStudents()
        {
            return await _context.Students.ToListAsync();
        }
        private async Task<List<Student>> GetDbStudents1()
        {
            return await _context.Students.ToListAsync();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Student>>> UpdateStudent(Student stud, int id)
        {

            var dbstud = await _context.Students
                .FirstOrDefaultAsync(s => s.Studno == id);
            if (dbstud == null)
                return NotFound("Sorry, No Student Found. :/");
            dbstud.Studno = stud.Studno;
            dbstud.Lastname = stud.Lastname;
            dbstud.Firstname = stud.Firstname;
            dbstud.Mi = stud.Mi;
           

            await _context.SaveChangesAsync();

            return Ok(await GetDbStudents());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Student>> DeleteStudent(int id)
        {

            var dbstud = await _context.Students
                .FirstOrDefaultAsync(s => s.Studno == id);
            if (dbstud == null)
                return NotFound("Sorry, No Student Found. :/");

            _context.Students.Remove(dbstud);

            await _context.SaveChangesAsync();

            return Ok(await GetDbStudents1());
        }


    }
}
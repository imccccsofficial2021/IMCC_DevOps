using Microsoft.AspNetCore.Mvc;
using MudBlazorWASM.Server.Data;


namespace MudBlazorWASM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly SchoolDB123Context _context;

        public StudentController(SchoolDB123Context context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetStudent")]
        public async Task<ActionResult<List<StudentList>>> GetStudent()
        {
            var Students = await _context.StudentLists.ToListAsync();
            return Ok(Students);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<StudentList>> GetSingleStudent(int id)
        {
            var stud = await _context.StudentLists
            //.Include(s=> s.Grades)
            .FirstOrDefaultAsync(s => s.STUDNO == id);
            if (stud == null)
            {
                return NotFound("No Student with this Id. :/");
            }
            return Ok(stud);
        }

        [HttpPost]
        public async Task<ActionResult<List<StudentList>>> CreateStudent(StudentList stud)
        {

            _context.StudentLists.Add(stud);
            await _context.SaveChangesAsync();

            return Ok(await GetDbStudents());
        }
        private async Task<List<StudentList>> GetDbStudents()
        {
            return await _context.StudentLists.ToListAsync();
        }
        private async Task<List<StudentList>> GetDbStudents1()
        {
            return await _context.StudentLists.ToListAsync();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<StudentList>>> UpdateStudent(StudentList stud, int id)
        {

            var dbstud = await _context.StudentLists
                .FirstOrDefaultAsync(s => s.STUDNO == id);
            if (dbstud == null)
                return NotFound("Sorry, No Student Found. :/");
            dbstud.ID = stud.ID;
            dbstud.LASTNAME = stud.LASTNAME;
            dbstud.FIRSTNAME = stud.FIRSTNAME;
            dbstud.MI = stud.MI;
           

            await _context.SaveChangesAsync();

            return Ok(await GetDbStudents());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<StudentList>> DeleteStudent(int id)
        {

            var dbstud = await _context.StudentLists
                .FirstOrDefaultAsync(s => s.STUDNO == id);
            if (dbstud == null)
                return NotFound("Sorry, No Student Found. :/");

            _context.StudentLists.Remove(dbstud);

            await _context.SaveChangesAsync();

            return Ok(await GetDbStudents1());
        }


    }
}
using Microsoft.AspNetCore.Mvc;
using MudBlazorWASM.Server.Data;

namespace MudBlazorWASM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollmentController : Controller
    {
        private readonly SchooldbContext _context;

        public EnrollmentController(SchooldbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetEnrollment")]
        public async Task<ActionResult<List<Admission>>> GetEnrollments()
        {
            var enroll = await _context.Admissions.ToListAsync();
            return Ok(enroll);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Admission>> GetSingleEnrollment(int id)
        {
            var stud = await _context.Admissions
            //.Include(s=> s.Grades)
            .FirstOrDefaultAsync(s => s.Enrid == id);
            if (stud == null)
            {
                return NotFound("No Enrollment with this Id. :/");
            }
            return Ok(stud);
        }

        [HttpPost]
        public async Task<ActionResult<List<Admission>>> CreateEnrollment(Admission stud)
        {

            _context.Admissions.Add(stud);
            await _context.SaveChangesAsync();

            return Ok(await GetDbEnrollment());
        }
        private async Task<List<Admission>> GetDbEnrollment()
        {
            return await _context.Admissions.ToListAsync();
        }
        private async Task<List<Admission>> GetDbEnrollment1()
        {
            return await _context.Admissions.ToListAsync();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Admission>>> UpdateEnrollment(Admission stud, int id)
        {

            var dbstud = await _context.Admissions
                .FirstOrDefaultAsync(s => s.Enrid == id);
            if (dbstud == null)
                return NotFound("Sorry, No Enrollment Found. :/");
            dbstud.Offerno = stud.Offerno;
            dbstud.Subjcode = stud.Subjcode;
            dbstud.Deptno = stud.Deptno;
            dbstud.Studno = stud.Studno;
            dbstud.Lastname = stud.Lastname;
            dbstud.Firstname = stud.Firstname;
            dbstud.Mi = stud.Mi;
            dbstud.Semcode = stud.Semcode;
            dbstud.Syr = stud.Syr;
            dbstud.Status = stud.Status;
            dbstud.CreatedBy = stud.CreatedBy;
            dbstud.DateCreated = stud.DateCreated;



            await _context.SaveChangesAsync();

            return Ok(await GetDbEnrollment());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Admission>> DeleteEnrollment(int id)
        {

            var dbstud = await _context.Admissions
                .FirstOrDefaultAsync(s => s.Enrid == id);
            if (dbstud == null)
                return NotFound("Sorry, No Student Found. :/");

            _context.Admissions.Remove(dbstud);

            await _context.SaveChangesAsync();

            return Ok(await GetDbEnrollment1());
        }


    }
}


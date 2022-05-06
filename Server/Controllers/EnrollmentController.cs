using Microsoft.AspNetCore.Mvc;
using MudBlazorWASM.Server.Data;

namespace MudBlazorWASM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollmentController : Controller
    {
        private readonly SchoolDB123Context _context;

        public EnrollmentController(SchoolDB123Context context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetEnrollment")]
        public async Task<ActionResult<List<Enrollment>>> GetEnrollments()
        {
            var enroll = await _context.Enrollments.ToListAsync();
            return Ok(enroll);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Enrollment>> GetSingleEnrollment(int id)
        {
            var stud = await _context.Enrollments
            //.Include(s=> s.Grades)
            .FirstOrDefaultAsync(s => s.ItemNo == id);
            if (stud == null)
            {
                return NotFound("No Enrollment with this Id. :/");
            }
            return Ok(stud);
        }

        [HttpPost]
        public async Task<ActionResult<List<Enrollment>>> CreateEnrollment(Enrollment stud)
        {

            _context.Enrollments.Add(stud);
            await _context.SaveChangesAsync();

            return Ok(await GetDbEnrollment());
        }
        private async Task<List<Enrollment>> GetDbEnrollment()
        {
            return await _context.Enrollments.ToListAsync();
        }
        private async Task<List<Enrollment>> GetDbEnrollment1()
        {
            return await _context.Enrollments.ToListAsync();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Enrollment>>> UpdateEnrollment(Enrollment stud, int id)
        {

            var dbstud = await _context.Enrollments
                .FirstOrDefaultAsync(s => s.ItemNo == id);
            if (dbstud == null)
                return NotFound("Sorry, No Enrollment Found. :/");
            dbstud.ItemNo = stud.ItemNo;
            dbstud.RegNo = stud.RegNo;
            dbstud.StudNo = stud.StudNo;
            dbstud.LastName = stud.LastName;
            dbstud.FirstName = stud.FirstName;
            dbstud.MiddleName = stud.MiddleName;
            dbstud.Department = stud.Department;
            dbstud.OfferNo = stud.OfferNo;
            dbstud.CourseNo = stud.CourseNo;
            dbstud.CourseDesc = stud.CourseDesc;
            dbstud.TeacherId = stud.TeacherId;
            dbstud.SectionId = stud.SectionId;
            dbstud.TimeId = stud.TimeId;
            dbstud.RoomId = stud.RoomId;
            dbstud.Days = stud.Days;
            dbstud.Units = stud.Units;
            dbstud.CreatedBy = stud.CreatedBy;
            dbstud.CreatedOn = stud.CreatedOn;



            await _context.SaveChangesAsync();

            return Ok(await GetDbEnrollment());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Enrollment>> DeleteEnrollment(int id)
        {

            var dbstud = await _context.Enrollments
                .FirstOrDefaultAsync(s => s.ItemNo == id);
            if (dbstud == null)
                return NotFound("Sorry, No Student Found. :/");

            _context.Enrollments.Remove(dbstud);

            await _context.SaveChangesAsync();

            return Ok(await GetDbEnrollment1());
        }


    }
}


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
            .FirstOrDefaultAsync(s => s.ItemNo == id);
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
        public async Task<ActionResult<Admission>> DeleteEnrollment(int id)
        {

            var dbstud = await _context.Admissions
                .FirstOrDefaultAsync(s => s.ItemNo == id);
            if (dbstud == null)
                return NotFound("Sorry, No Student Found. :/");

            _context.Admissions.Remove(dbstud);

            await _context.SaveChangesAsync();

            return Ok(await GetDbEnrollment1());
        }


    }
}


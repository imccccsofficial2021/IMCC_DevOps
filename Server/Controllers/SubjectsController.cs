#nullable disable
using Microsoft.AspNetCore.Mvc;
using MudBlazorWASM.Server.Data;

namespace MudBlazorWASM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly SchooldbContext _context;

        public SubjectsController(SchooldbContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("getallsubjects")]
        public async Task<ActionResult<List<Subject>>> GetAllSubjects()
        {
            var subjects = await _context.Subjects.ToListAsync();
            return Ok(subjects);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Subject>>> GetCourseNo(string code)
        {
            var subjects = await _context.Subjects
              .FirstOrDefaultAsync(s => s.Coursecode == code);
            if (subjects == null)
            {
                return NotFound("No Subject with this course number. :/");
            }
            return Ok(subjects);

        }

        [HttpPost]
        public async Task<ActionResult<List<Subject>>> CreateNewSubject(Subject subjectlist)
        {
            _context.Subjects.Add(subjectlist);
            await _context.SaveChangesAsync();

            return Ok(await GetDbListSubjects());
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Subject>>> UpdateAllSubjects(Subject subjectlist, string code)
        {
            var subjects = await _context.Subjects
                .FirstOrDefaultAsync(s => s.Coursecode == code);
            if (subjects == null)
                return NotFound("Sorry, Offer Number Not Found!");
            subjects.Coursecode = subjectlist.Coursecode;
            subjects.Coursedesc = subjectlist.Coursedesc;
            subjects.Lab = subjectlist.Lab;
            subjects.Lec = subjectlist.Lec;
            subjects.Units = subjectlist.Units;


            await _context.SaveChangesAsync();

            return Ok(await GetDbListSubjects());

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Subject>> DeleteSubject(string coursecode)
        {
            var subject = await _context.Subjects
                .FirstOrDefaultAsync(s => s.Coursecode == coursecode);
            if (subject == null)
                return NotFound("Sorry, Offer Number Not Found!");

            _context.Subjects.Remove(subject);
            await _context.SaveChangesAsync();

            return Ok(await GetDbListSubjects1());
        }

        private async Task<List<Subject>> GetDbListSubjects()
        {
            return await _context.Subjects.ToListAsync();
        }

        private async Task<List<Subject>> GetDbListSubjects1()
        {
            return await _context.Subjects.ToListAsync();
        }
    }
}

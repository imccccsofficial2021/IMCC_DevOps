#nullable disable
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MudBlazorWASM.Server.Data;
using MudBlazorWASM.Shared.Models;

namespace MudBlazorWASM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly SchoolDB123Context _context;

        public SubjectsController(SchoolDB123Context context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("getallsubjects")]
        public async Task<ActionResult<List<SubjectList>>> GetAllSubjects()
        {
            var subjects = await _context.SubjectLists.ToListAsync();
            return Ok(subjects);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<SubjectList>>> GetCourseNo(int id)
        {
            var subjects = await _context.SubjectLists
              .FirstOrDefaultAsync(s => s.ID == id);
            if (subjects == null)
            {
                return NotFound("No Subject with this course number. :/");
            }
            return Ok(subjects);

        }

        [HttpPost]
        public async Task<ActionResult<List<SubjectList>>> CreateNewSubject(SubjectList subjectlist)
        {
            _context.SubjectLists.Add(subjectlist);
            await _context.SaveChangesAsync();

            return Ok(await GetDbListSubjects());
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<SubjectList>>> UpdateAllSubjects(SubjectList subjectlist, int id)
        {
            var subjects = await _context.SubjectLists
                .FirstOrDefaultAsync(s => s.ID == id);
            if (subjects == null)
                return NotFound("Sorry, Offer Number Not Found!");
            subjects.ID = subjectlist.ID;
            subjects.COURSENO = subjectlist.COURSENO;
            subjects.COURSEDESC = subjectlist.COURSEDESC;
            subjects.CREDITS = subjectlist.CREDITS;
            subjects.Enrollments = subjectlist.Enrollments;
            

            await _context.SaveChangesAsync();

            return Ok(await GetDbListSubjects());

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<SubjectList>> DeleteSubject( int id)
        {
            var subject = await _context.SubjectLists
                .FirstOrDefaultAsync(s => s.ID == id);
            if (subject == null)
                return NotFound("Sorry, Offer Number Not Found!");

            _context.SubjectLists.Remove(subject);
            await _context.SaveChangesAsync();

            return Ok(await GetDbListSubjects1());
        }

        private async Task<List<SubjectList>> GetDbListSubjects()
        {
            return await _context.SubjectLists.ToListAsync();
        }

        private async Task<List<SubjectList>> GetDbListSubjects1()
        {
            return await _context.SubjectLists.ToListAsync();
        }
    }
}

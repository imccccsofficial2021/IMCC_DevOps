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
        public async Task<ActionResult<List<Subject>>> UpdateAllSubjects(Subject subjectlist, string id)
        {
            var subjects = await _context.Subjects
                .FirstOrDefaultAsync(s => s.Coursecode == id);
            if (subjects == null)
                return NotFound("Sorry, Offer Number Not Found!");
            subjects.Coursecode = subjectlist.Coursecode;
            subjects.Courseno = subjectlist.Courseno;
            subjects.Coursedesc = subjectlist.Coursedesc;
            subjects.Lec = subjectlist.Lec;
            subjects.Lab = subjectlist.Lab;
            subjects.Units = subjectlist.Units;
            subjects.Prereq = subjectlist.Prereq;
            subjects.Semcode = subjectlist.Semcode;
            subjects.Semester = subjectlist.Semester;
            subjects.Yrlevel = subjectlist.Yrlevel;
            subjects.Deptno = subjectlist.Deptno;
            subjects.Category = subjectlist.Category;
            subjects.Status = subjectlist.Status;
            subjects.Tyype = subjectlist.Tyype;

            await _context.SaveChangesAsync();

            return Ok(await GetDbListSubjects());

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Subject>> DeleteSubject(string code)
        {
            var subject = await _context.Subjects
                .FirstOrDefaultAsync(s => s.Coursecode == code);
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

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MudBlazorWASM.Server.Data;
using MudBlazorWASM.Shared.Models;

namespace MudBlazorWASM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradesController : ControllerBase
    {
        private readonly SchooldbContext _webAppDb;
        public GradesController(SchooldbContext webAppDb)
        {
            _webAppDb = webAppDb;
        }

        [HttpGet]
        [Route("GetAllGrades")]
        public async Task<ActionResult<HashSet<GradeSummary>>> GetAllGrades()
        {
            if (_webAppDb.GradeSummaries == null)
                return NotFound();

            var grades = await _webAppDb.GradeSummaries.ToListAsync();
            return Ok(grades);
        }

        [HttpGet]
        [Route("GetStudentID")]
        public async Task<ActionResult<HashSet<GradeSummary>>> GetStudentID(string offerno)
        {
            if (_webAppDb.GradeSummaries == null)
                return NotFound();

            var grades = await _webAppDb.GradeSummaries.FirstOrDefaultAsync(sh => sh.Offerno == offerno);
            return Ok(grades);
        }

        [HttpPost]
        [Route("AddNewGrade")]
        public async Task<ActionResult<HashSet<GradeSummary>>> CreateNewGrade([FromBody] GradeSummary summaryGrade)
        {
            _webAppDb.GradeSummaries.Add(summaryGrade);
            await _webAppDb.SaveChangesAsync();

            return Ok(await GetDbListGrades());
        }

        [HttpPut("{offerno}")]
        [Route("UpdateAllGrades")]
        public async Task<ActionResult<List<GradeSummary>>> UpdateAllGrades([FromBody] GradeSummary summaryGrade, string offerno)
        {
            var grades = await _webAppDb.GradeSummaries.FirstOrDefaultAsync(sh => sh.Offerno == offerno);
            if (grades == null)
                return NotFound("Sorry, Offer Number Not Found!");

            grades.Deptno = summaryGrade.Deptno;
            grades.Offerno = summaryGrade.Offerno;
            grades.Courseno = summaryGrade.Courseno;
            grades.Studno = summaryGrade.Studno;
            grades.Lastname = summaryGrade.Lastname;
            grades.Firstname = summaryGrade.Firstname;
            grades.Mi = summaryGrade.Mi;
            grades.Pre = summaryGrade.Pre;
            grades.Mid = summaryGrade.Mid;
            grades.Semi = summaryGrade.Semi;
            grades.Final = summaryGrade.Final;
            grades.Average = summaryGrade.Average;
            grades.Subjectdesc = summaryGrade.Subjectdesc;

            await _webAppDb.SaveChangesAsync();

            return Ok(await GetDbListGrades());

        }

        [HttpDelete("{offerno}")]
        public async Task<ActionResult<List<GradeSummary>>> DeleteGradesByOfferNo([FromBody] string offerno)
        {
            var grades = await _webAppDb.GradeSummaries
                .FirstOrDefaultAsync(sh => sh.Offerno == offerno);
            if (grades == null)
                return NotFound("Sorry, Offer Number Not Found!");

            _webAppDb.GradeSummaries.Remove(grades);
            await _webAppDb.SaveChangesAsync();

            return Ok(await GetDbListGrades());
        }

        private async Task<ActionResult<List<GradeSummary>>> GetDbListGrades()
        {
            return await _webAppDb.GradeSummaries.ToListAsync();
        }

    }
}

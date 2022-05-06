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
        private readonly SchoolDB123Context _webAppDb;
        public GradesController(SchoolDB123Context webAppDb)
        {
            _webAppDb = webAppDb;
        }

        [HttpGet]
        [Route("GetAllGrades")]
        public async Task<ActionResult<List<SummaryGrades>>> GetAllGrades()
        {
            if (_webAppDb.SummaryGradesList == null)
                return NotFound();

            var grades = await _webAppDb.SummaryGradesList.ToListAsync();
            return Ok(grades);
        }

        [HttpGet]
        [Route("GetStudentID")]
        public async Task<ActionResult<List<SummaryGrades>>> GetStudentID(int offerno)
        {
            if (_webAppDb.SummaryGradesList == null)
                return NotFound();

            var grades = await _webAppDb.SummaryGradesList.FirstOrDefaultAsync(sh => sh.Offerno == offerno);
            return Ok(grades);
        }

        [HttpPost]
        [Route("AddNewGrade")]
        public async Task<ActionResult<List<SummaryGrades>>> CreateNewGrade([FromBody] SummaryGrades summaryGrade)
        {
            _webAppDb.SummaryGradesList.Add(summaryGrade);
            await _webAppDb.SaveChangesAsync();

            return Ok(await GetDbListGrades());
        }

        [HttpPut("{offerno}")]
        public async Task<ActionResult<List<SummaryGrades>>> UpdateAllGrades([FromBody] SummaryGrades summaryGrade, int offerno)
        {
            var grades = await _webAppDb.SummaryGradesList.FirstOrDefaultAsync(sh => sh.Offerno == offerno);
            if (grades == null)
                return NotFound("Sorry, Offer Number Not Found!");

            grades.Deptno = summaryGrade.Deptno;
            grades.Offerno = summaryGrade.Offerno;
            grades.Courseno = summaryGrade.Courseno;
            grades.Studno = summaryGrade.Studno;
            grades.Last = summaryGrade.Last;
            grades.First = summaryGrade.First;
            grades.Mi = summaryGrade.Mi;
            grades.Term1 = summaryGrade.Term1;
            grades.Term2 = summaryGrade.Term2;
            grades.Term3 = summaryGrade.Term3;
            grades.Term4 = summaryGrade.Term4;
            grades.Average = summaryGrade.Average;
            grades.Subjects = summaryGrade.Subjects;

            await _webAppDb.SaveChangesAsync();

            return Ok(await GetDbListGrades());

        }

        [HttpDelete("{offerno}")]
        public async Task<ActionResult<List<SummaryGrades>>> DeleteGradesByOfferNo([FromBody] int offerno)
        {
            var grades = await _webAppDb.SummaryGradesList
                .FirstOrDefaultAsync(sh => sh.Offerno == offerno);
            if (grades == null)
                return NotFound("Sorry, Offer Number Not Found!");

            _webAppDb.SummaryGradesList.Remove(grades);
            await _webAppDb.SaveChangesAsync();

            return Ok(await GetDbListGrades());
        }

        private async Task<ActionResult<List<SummaryGrades>>> GetDbListGrades()
        {
            return await _webAppDb.SummaryGradesList.ToListAsync();
        }

    }
}

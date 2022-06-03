using Microsoft.AspNetCore.Mvc;
using MudBlazorWASM.Server.Data;

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
        public async Task<ActionResult<List<SubmittedGrade>>> GetAllGrades()
        {
            if (_webAppDb.SubmittedGrades == null)
                return NotFound();

            var grades = await _webAppDb.SubmittedGrades.ToListAsync();
            return Ok(grades);
        }

        public async Task<ActionResult<List<SubmittedGrade>>> GetAllOfferedSubjects()
        {
            if (_webAppDb.OfferedSubjects == null)
                return NotFound();

            var grades = await _webAppDb.OfferedSubjects.ToListAsync();
            return Ok(grades);
        }

        [HttpGet]
        [Route("GetStudentID")]
        public async Task<ActionResult<List<SubmittedGrade>>> GetStudentID(int offerno)
        {
            if (_webAppDb.SubmittedGrades == null)
                return NotFound();

            var grades = await _webAppDb.SubmittedGrades.FirstOrDefaultAsync(sh => sh.Offerno == offerno);
            return Ok(grades);
        }

        [HttpPost]
        [Route("AddNewGrade")]
        public async Task<ActionResult<List<SubmittedGrade>>> CreateNewGrade([FromBody] SubmittedGrade submitGrades)
        {
            _webAppDb.SubmittedGrades.Add(submitGrades);
            await _webAppDb.SaveChangesAsync();

            return Ok(await GetDbListGrades());
        }

        [HttpPut("{offerno}")]
        public async Task<ActionResult<List<SubmittedGrade>>> UpdateAllGrades([FromBody] SubmittedGrade submitGrades, int offerno)
        {
            var grades = await _webAppDb.SubmittedGrades.FirstOrDefaultAsync(sh => sh.Offerno == offerno);
            if (grades == null)
                return NotFound("Sorry, Offer Number Not Found!");

            grades.Offerno = submitGrades.Offerno;
            grades.Studno = submitGrades.Studno;
            grades.Lastname = submitGrades.Lastname;
            grades.Firstname = submitGrades.Firstname;
            grades.Mi = submitGrades.Mi;
            grades.Yrlevel = submitGrades.Yrlevel;
            grades.Coursecode = submitGrades.Coursecode;
            grades.Coursedesc = submitGrades.Coursedesc;
            grades.Units = submitGrades.Units;
            grades.Deptno = submitGrades.Deptno;
            grades.Prelim = submitGrades.Prelim;
            grades.Midterm = submitGrades.Midterm;
            grades.Prefinal = submitGrades.Prefinal;
            grades.Final = submitGrades.Final;
            grades.Average = submitGrades.Average;
            grades.Retake = submitGrades.Retake;
            grades.Teachid = submitGrades.Teachid;
            //grades.Date = DateTime.Now("");
            //grades.Time = DateTime.Now.ToLocalTime();
            //grades.Deptno = summaryGrade.Deptno;
            //grades.Offerno = summaryGrade.Offerno;
            //grades.Courseno = summaryGrade.Courseno;
            //grades.Studno = summaryGrade.Studno;
            //grades.Last = summaryGrade.Last;
            //grades.First = summaryGrade.First;
            //grades.Mi = summaryGrade.Mi;
            //grades.Term1 = summaryGrade.Term1;
            //grades.Term2 = summaryGrade.Term2;
            //grades.Term3 = summaryGrade.Term3;
            //grades.Term4 = summaryGrade.Term4;
            //grades.Average = summaryGrade.Average;
            //grades.Subjects = summaryGrade.Subjects;

            await _webAppDb.SaveChangesAsync();

            return Ok(await GetDbListGrades());

        }

        [HttpDelete("{offerno}")]
        public async Task<ActionResult<List<SubmittedGrade>>> DeleteGradesByOfferNo([FromBody] int offerno)
        {
            var grades = await _webAppDb.SubmittedGrades
                .FirstOrDefaultAsync(sh => sh.Offerno == offerno);
            if (grades == null)
                return NotFound("Sorry, Offer Number Not Found!");

            _webAppDb.SubmittedGrades.Remove(grades);
            await _webAppDb.SaveChangesAsync();

            return Ok(await GetDbListGrades());
        }

        private async Task<ActionResult<List<SubmittedGrade>>> GetDbListGrades()
        {
            return await _webAppDb.SubmittedGrades.ToListAsync();
        }

    }
}

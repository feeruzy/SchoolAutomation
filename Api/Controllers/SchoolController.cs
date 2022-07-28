using Microsoft.AspNetCore.Mvc;
using School.Core;
using School.Core.Helper;


namespace Api.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class SchoolController : ControllerBase
{
    private readonly ILogger<SchoolController> _logger;
    public SchoolController(ILogger<SchoolController> logger)
    {
        _logger = logger;
    }

    #region students
    [HttpGet]
    public IActionResult StudentList()
    {
        var userList = new ClassStudentManagement().ListStudent();
        return Ok(userList);
    }

    [HttpPut]
    public IActionResult CreateNewStudent(string fname, string lname, string address, string phone = "-", string parentPhone = "-", string description = "-")
    {
        try
        {
            var result = new ClassStudentManagement().createStudent(fname, lname, phone, address, parentPhone, description);
            return Ok($"user created with  id {result}");
        }
        catch (ApplicationException e)
        {
            return BadRequest(e.Message);
        }
        catch (Exception e)
        {
            _logger.LogError($"{e.Message} {e.InnerException?.Message}");
            return BadRequest("خطا در انجام عملیات.");
        }
    }
    [HttpPost]
    public IActionResult EditStudentInfo(int sId, string fname, string lastName, string address, string phone = "-", string parentPhone = "-", string description = "-")
    {
        try
        {
            new ClassStudentManagement().editStudent(sId, fname, lastName, phone, address, parentPhone, description);
            return Ok($"User {lastName} Edited ");
        }
        catch (ApplicationException e)
        {
            return BadRequest(e.Message);
        }
        catch (Exception e)
        {
            _logger.LogError($"{e.Message} {e.InnerException?.Message}");
            return BadRequest("خطا در انجام عملیات.");
        }

    }
    [HttpDelete]
    public IActionResult RemoveStudent(int userId)
    {
        try
        {
            new ClassStudentManagement().removeStudent(userId);
            return Ok($"student with id {userId} removed.");
        }

        catch (ApplicationException e)
        {
            return BadRequest(e.Message);
        }
        catch (Exception e)
        {
            _logger.LogError($"{e.Message} {e.InnerException?.Message}");
            return BadRequest("خطا در انجام عملیات.");
        }
    }
    #endregion

    #region year
    [HttpGet]
    public IActionResult YearList()
    {
        try
        {
            var yearList = new YearManager().ListYears();
            return Ok(yearList);
        }

        catch (ApplicationException e)
        {
            return BadRequest(e.Message);
        }
        catch (Exception e)
        {
            _logger.LogError($"{e.Message} {e.InnerException?.Message}");
            return BadRequest("خطا در انجام عملیات.");
        }
    }
    [HttpPut]
    public IActionResult AddYear(string name)
    {
        try
        {
            var newYearId = new YearManager().CreateYear(name);
            return Ok($"سال جدید با کد {newYearId} ثیت شد.");
        }

        catch (ApplicationException e)
        {
            return BadRequest(e.Message);
        }
        catch (Exception e)
        {
            _logger.LogError($"{e.Message} {e.InnerException?.Message}");
            return BadRequest("خطا در انجام عملیات.");
        }
    }
    [HttpPost]
    public IActionResult ChangeActiveYear(int id)
    {
        try
        {
            new YearManager().EditActivation(id);
            return Ok("سال تحصیلی قعال در سیستم تغییر کرد");
        }

        catch (ApplicationException e)
        {
            return BadRequest(e.Message);
        }
        catch (Exception e)
        {
            _logger.LogError($"{e.Message} {e.InnerException?.Message}");
            return BadRequest("خطا در انجام عملیات.");
        }
    }
    [HttpDelete]
    public IActionResult RemoveYear(int id)
    {
        try
        {
            new YearManager().removeYear(id);
            return Ok("سال تحصیلی موردنظر با موفقیت حذف شد.");
        }

        catch (ApplicationException e)
        {
            return BadRequest(e.Message);
        }
        catch (Exception e)
        {
            _logger.LogError($"{e.Message} {e.InnerException?.Message}");
            return BadRequest("خطا در انجام عملیات.");
        }
    }
    #endregion

    #region discipline
    [HttpGet]
    public IActionResult DisciplineList()
    {
        try
        {
            var DisciplineList = new DisciplineManagement().List();
            return Ok(DisciplineList);
        }

        catch (ApplicationException e)
        {
            return BadRequest(e.Message);
        }
        catch (Exception e)
        {
            _logger.LogError($"{e.Message} {e.InnerException?.Message}");
            return BadRequest("خطا در انجام عملیات.");
        }



    }
    [HttpPut]
    public IActionResult CreateDiscipline(string title, float kasrenomre)
    {
        try
        {
            var newItem = new ClassDiscipline()
            {
                Title = title,
                KasreNomre = kasrenomre,
            };
            var newId = new DisciplineManagement().CreateDisciplineItem(newItem);
            return Ok($"مورد انضباطی جدید با کد {newId} ثبت شد.");
        }

        catch (ApplicationException e)
        {
            return BadRequest(e.Message);
        }
        catch (Exception e) 
        {
          _logger.LogError($"{e.Message} {e.InnerException?.Message}");
            return BadRequest("خطا در انجام عملیات.");
        }
    }

    [HttpPost]
    public IActionResult EditDiscipline(int Id, string editedTitle, float kasrenomre)
    {
        try
        {
            new DisciplineManagement().EditDisciplineItem(Id, editedTitle, kasrenomre);
            return Ok("تغییرات با موفقیت انجام شد.");

        }
        catch (ApplicationException e)
        {
            return BadRequest(e.Message);
        }
        catch (Exception e)
        {
            _logger.LogError($"{e.Message} {e.InnerException?.Message}");
            return BadRequest("خطا در انجام عملیات.");
        }

    }
    [HttpDelete]
    public IActionResult RemoveDiscipline(int Id)
    {
        try
        {
            new DisciplineManagement().RemoveDisciplineItem(Id);
            return Ok("مورد انضباطی حذف شد.");
        }
        catch (ApplicationException e)
        {
            return BadRequest(e.Message);
        }
        catch (Exception e)
        {
            _logger.LogError($"{e.Message} {e.InnerException?.Message}");
            return BadRequest("خطا در انجام عملیات.");
        }

    }
    #endregion

    #region disciplineStudent
    [HttpGet]
    public IActionResult StudentDisciplineList(int studentId)
    {
        try
        {
            var itemlist = new ClassDisciplineStudentManager().List(studentId);
            return Ok(itemlist);
        }
        catch (ApplicationException e)
        {
            return BadRequest(e.Message);
        }
        catch (Exception e)
        {
            _logger.LogError($"{e.Message} {e.InnerException?.Message}");
            return BadRequest("خطا در انجام عملیات.");
        }

    }
    [HttpPut]
    public IActionResult CreateStudentDiscipline(int studentId, DateTime dt, int disciplineId)
    {

        try
        {
            var addestudentdiscipline = new ClassDisciplineStudentManager().AddEventForStudent(studentId, dt, disciplineId);
            return Ok("مورد انضباطی جدید ثبت شد.");
        }
        catch (ApplicationException e)
        {
            return BadRequest(e.Message);
        }
        catch (Exception e)
        {
            _logger.LogError($"{e.Message} {e.InnerException?.Message}");
            return BadRequest("خطا در انجام عملیات.");
        }

    }



    [HttpDelete]
    public IActionResult RemoveStudentDiscipline(int itemId)
    {
        try
        {
            new ClassDisciplineStudentManager().remveEventItem(itemId);
            return Ok("مورد انضباطی حذف شد.");
        }
        catch (ApplicationException e)
        {
            return BadRequest(e.Message);
        }
        catch (Exception e)
        {
            _logger.LogError($"{e.Message} {e.InnerException?.Message}");
            return BadRequest("خطا در انجام عملیات.");
        }
    }
    #endregion

    #region Login
    [HttpPost]
    public IActionResult Login(string username, string password)
    {
        if (username == "admin" && password == "12345") return Ok(new { token = new Auth().GenerateToken(username) });
        return NotFound(new { token = string.Empty, error = "incorrect username or password!" });
    }

    [HttpGet] public IActionResult checkToken(string token) => Content(new Auth().ValidateToken(token).ToString());
    #endregion

}


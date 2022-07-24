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
        var result = new ClassStudentManagement().createStudent(fname, lname, phone, address, parentPhone, description);
        return Ok($"user created with  id {result}");
    }
    [HttpPost] public IActionResult EditStudentInfo() => Ok();
    [HttpDelete]
    public IActionResult RemoveStudent(int userId)
    {
        new ClassStudentManagement().removeStudent(userId);
        return Ok($"student with id {userId} removed.");
    }
    #endregion

    #region year
    [HttpGet] public IActionResult YearList() => Ok();
    [HttpPut] public IActionResult AddYear() => Ok();
    [HttpPost] public IActionResult ChangeActiveYear() => Ok();
    [HttpDelete] public IActionResult RemoveYear() => Ok();
    #endregion

    #region discipline
    [HttpGet] public IActionResult DisciplineList() => Ok();
    [HttpPut] public IActionResult CreateDiscipline() => Ok();
    [HttpPost] public IActionResult EditDiscipline() => Ok();
    [HttpDelete] public IActionResult RemoveDiscipline() => Ok();
    #endregion

    #region disciplineStudent
    [HttpGet] public IActionResult StudentDisciplineList(int studentId) => Ok();
    [HttpPut] public IActionResult CreateStudentDiscipline() => Ok();
    [HttpDelete] public IActionResult RemoveStudentDiscipline() => Ok();
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

    // [HttpPost(Name = "createUser")]
    // public IActionResult createUser(string fname, string lname, string phone)
    // {

    // }

    // [HttpGet(Name = "greeting")]
    // public IActionResult nameAPI()
    // {

    // }

    // [HttpDelete(Name = "removeUser")]
    // public IActionResult removeUser(int userId)
    // {
    //     new UserManagement().removeUser(userId);
    //     return Ok($"user  with userId {userId} removed.");

    // }
}

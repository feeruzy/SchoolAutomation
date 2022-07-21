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
  [HttpGet] public IActionResult StudentList() => Ok();
  [HttpPut] public IActionResult CreateNewStudent() => Ok();
  [HttpPost] public IActionResult EditStudentInfo() => Ok();
  [HttpDelete] public IActionResult RemoveStudent() => Ok();
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
  //     var result = new UserManagement().CreateUser(fname, lname, phone, UserTypeEnum.Student);
  //     return Ok($"user created with  id {result}");
  // }

  // [HttpGet(Name = "greeting")]
  // public IActionResult nameAPI()
  // {
  //     var userList = new School.Core.UserManagement().List();
  //     return Ok(userList);
  // }

  // [HttpDelete(Name = "removeUser")]
  // public IActionResult removeUser(int userId)
  // {
  //     new UserManagement().removeUser(userId);
  //     return Ok($"user  with userId {userId} removed.");

  // }
}

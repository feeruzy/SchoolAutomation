using Microsoft.AspNetCore.Mvc;
using School.Core;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }


    [HttpPost(Name = "createUser")]
    public IActionResult createUser(string fname, string lname, string phone)
    {
        var result = new UserManagement().CreateUser(fname, lname, phone, UserTypeEnum.Student);
        return Ok($"user created with  id {result}");
    }

    [HttpGet(Name = "greeting")]
    public IActionResult nameAPI()
    {
        var userList = new School.Core.UserManagement().List();
        return Ok(userList);
    }

    [HttpDelete(Name = "removeUser")]
    public IActionResult removeUser(int userId)
    {
        new UserManagement().removeUser(userId);
        return Ok($"user  with userId {userId} removed.");
 
    }
}
using Microsoft.AspNetCore.Mvc;

namespace DotnetApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    public UserController()
    {
    }

    [HttpGet("GetUser/{testValue}")]
    //    public IEnumerable<User> GetUsers()

    public string[] GetUsers(string testValue)
    {
        return new string[] { "user1", "user2", testValue };
    }
}

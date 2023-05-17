using Microsoft.AspNetCore.Mvc;

namespace DotnetApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    DataContextDapper _dapper;
    public UserController(IConfiguration config)
    {
        _dapper = new DataContextDapper(config);
    }

    [HttpGet("TestConnection")]
    public DateTime TestConnention()
    {
        return _dapper.LoadDataSingle<DateTime>("SELECT GETDATE()");
    }
    
    [HttpGet("GetUser/{testValue}")]
    //    public IEnumerable<User> GetUsers()

    public string[] GetUsers(string testValue)
    {
        return new string[] { "user1", "user2", testValue };
    }
}

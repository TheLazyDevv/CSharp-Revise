using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIRevise.Entities;

namespace WebAPIRevise.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    List<User> users = new List<User>
    {
        new User { Name = "John Doe", Username = "johndoe", Age = 30, Email = "johndoe@example.com"},
        new User { Name = "Jane Smith", Username = "janesmith", Age = 25, Email = "janesmith@example.com"},
        new User { Name = "Bob Johnson", Username = "bobjohnson", Age = 40, Email = "bobjohnson@example.com"}
    };

    [HttpGet]

    public List<User> GetUsers()
    {
        return users;
    }

    [HttpGet("{id}")]

    public IActionResult GetUserById(Guid id)
    {
        var user = users.FirstOrDefault(u => u.Id == id);
        if (user == null)
        {
            return NotFound();
        }
        return Ok(user);
    }

    [HttpPost]
    public IActionResult Add()
    {
        return Ok();
    }

    [HttpPut]
    public IActionResult Update()
    {
        return Ok();
    }

    [HttpDelete]

    public IActionResult Delete()
    {
        return Ok();
    }
}

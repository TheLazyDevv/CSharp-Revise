using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIRevise.DTOs;
using WebAPIRevise.Entities;

namespace WebAPIRevise.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    List<User> users = new List<User>
    {
        new User { Id=1, Name = "John Doe", Username = "johndoe", Age = 30, Email = "johndoe@example.com"},
        new User { Id=2, Name = "Jane Smith", Username = "janesmith", Age = 25, Email = "janesmith@example.com"},
        new User { Id=3, Name = "Bob Johnson", Username = "bobjohnson", Age = 40, Email = "bobjohnson@example.com"}
    };

    [HttpGet]

    public List<User> GetUsers()
    {
        return users;
    }

    [HttpGet]
    [Route("GetById")]

    public IActionResult GetUserById(int id)
    {
        var user = users.FirstOrDefault(u => u.Id == id);
        if (user == null)
        {
            return NotFound();
        }
        return Ok(user);
    }

    [HttpPost]
    public List<User> Add([FromBody] User user)
    {
        users.Add(user);
        return users;
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, UpdateUserDto model)
    {
        var currentUser = users.FirstOrDefault(u => u.Id == id);
        if (currentUser == null)
        {
            return NotFound();
        }
        currentUser.Name = model.Name;
        currentUser.Username = model.Username;
        return Ok(currentUser);
    }

    [HttpDelete("{id}")]
    public List<User> Delete(int id)
    {
        var user = users.FirstOrDefault(u => u.Id == id);
        if (user == null)
        {
            return users;
        }
        users.Remove(user);
        return users;
    }
}

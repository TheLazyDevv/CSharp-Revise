using Microsoft.AspNetCore.Mvc;
using WebAPIRevise.DTOs.CustomerDTOs;
using WebAPIRevise.Entities;
using WebAPIRevise.Services;

namespace WebAPIRevise.Controllers;


[Route("api/[controller]")]
[ApiController]
public class CustomerController(ICustomerService customerService) : ControllerBase
{
    private readonly ICustomerService _customerService = customerService;

    [HttpPost]

    public IActionResult AddCustomer([FromBody]AddDTO customer)
    {
        var newCustomer = _customerService.Add(customer);
        return Ok(newCustomer);
    }

    [HttpGet]

    public IActionResult GetAllCustomer()
    {
        var customers = _customerService.GetAll();
        return Ok(customers);
    }

    [HttpGet("{id}")]

    public IActionResult GetById(string id)
    {
        var customer = _customerService.GetById(id);
        if (customer == null)
        {
            return NotFound();
        }
        return Ok(customer);
    }

    [HttpDelete("{id}")]

    public IActionResult Delete(string id)
    {
        var result = _customerService.Delete(id);
        if (!result)
        {
            return NotFound();
        }
        return Ok();
    }
}

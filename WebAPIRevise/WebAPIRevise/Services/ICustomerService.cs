using WebAPIRevise.DTOs.CustomerDTOs;
using WebAPIRevise.Entities;

namespace WebAPIRevise.Services;

public interface ICustomerService
{
    Customer Add(AddDTO customer);

    bool Update(Customer customer);

    List<Customer> GetAll();

    Customer GetById(string id);

    bool Delete(string id);

}

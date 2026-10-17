using WebAPIRevise.DTOs.CustomerDTOs;
using WebAPIRevise.Entities;
using WebAPIRevise.Repositories;

namespace WebAPIRevise.Services;

public class CustomerService(ICustomerRepository customerRepository) : ICustomerService
{

    private readonly ICustomerRepository _customerRepository = customerRepository;
    public Customer Add(AddDTO customer)
    {
        Customer newCustomer = new(){CustomerId= customer.CustomerId, CompanyName=customer.CompanyName};
        _customerRepository.Add(newCustomer);
        return newCustomer;
    }

    public bool Delete(string id)
    {
        _customerRepository.Delete(id);
        return true;
    }

    public List<Customer> GetAll()
    {
        var list = _customerRepository.GetAll();
        return list.ToList();
    }

    public Customer GetById(string id)
    {
        var customer = _customerRepository.GetById(id);
        return customer;
    }

    public bool Update(Customer customer)
    {
        _customerRepository.Update(customer);
        return true;
    }
}

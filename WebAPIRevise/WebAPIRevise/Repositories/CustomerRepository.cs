using Microsoft.EntityFrameworkCore;
using WebAPIRevise.Context;
using WebAPIRevise.Entities;

namespace WebAPIRevise.Repositories;

public class CustomerRepository(AppDbContext dbContext) : ICustomerRepository
{
    private readonly AppDbContext _dbContext = dbContext;
    public void Add(Customer customer)
    {
        _dbContext.Add(customer);
        _dbContext.SaveChanges();
    }

    public void Delete(string id)
    {
        var current = _dbContext.Customers.FirstOrDefault(c => c.CustomerId == id) ?? throw new Exception("Customer not found");
        if (current != null)
        {
            _dbContext.Remove(current);
            _dbContext.SaveChanges();
        }
    }

    public IQueryable<Customer> GetAll()
    {
        return _dbContext.Customers;
    }

    public Customer GetById(string id)
    {
        var current = _dbContext.Customers.FirstOrDefault(c => c.CustomerId == id) ?? throw new Exception("Customer not found");
        return current;
    }

    public void Update(Customer customer)
    {
        _dbContext.Update(customer);
        _dbContext.SaveChanges();
    }
}

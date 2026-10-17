using WebAPIRevise.Entities;

namespace WebAPIRevise.Repositories;

public interface ICustomerRepository
{
    void Add(Customer customer);

    void Update(Customer customer);

    IQueryable<Customer> GetAll();

    Customer GetById(string id);

    void Delete(string id);
}

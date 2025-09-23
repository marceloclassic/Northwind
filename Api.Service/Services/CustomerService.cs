using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Service.Services
{
    public class CustomerService : ICustomerService
    {
        public ICustomerRepository _repository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _repository = customerRepository;
        }

        public async Task<bool> Delete(string id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<CustomerEntity> Get(string id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<CustomerEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<CustomerEntity> Post(CustomerEntity register)
        {
            return await _repository.InsertAsync(register);
        }

        public async Task<CustomerEntity> Put(CustomerEntity register)
        {
            return await _repository.UpdateAsync(register);
        }
    }
}

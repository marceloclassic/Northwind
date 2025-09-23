using Api.Domain.Entities;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface ICustomerService
    {
        Task<CustomerEntity> Get(string id);
        Task<IEnumerable<CustomerEntity>> GetAll();
        Task<CustomerEntity> Post(CustomerEntity user);
        Task<CustomerEntity> Put(CustomerEntity user);
        Task<bool> Delete(string id);
    }
}

using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories
{
    public interface ICustomerRepository
    {
        Task<CustomerEntity> InsertAsync(CustomerEntity item);
        Task<CustomerEntity> UpdateAsync(CustomerEntity item);
        Task<bool> DeleteAsync(string id);
        Task<CustomerEntity> SelectAsync(string id);
        Task<IEnumerable<CustomerEntity>> SelectAsync();
        Task<bool> ExistAsync(string id);
    }
}

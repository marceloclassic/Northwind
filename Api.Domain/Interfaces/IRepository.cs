using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IRepository<T> 
    {
        Task<T> InsertAsync(T item);
        Task<T> UpdateAsync(T item);
        Task<bool> DeleteAsync(string id);
        Task<T> SelectAsync(string id);
        Task<IEnumerable<T>> SelectAsync();
        Task<bool> ExistAsync(string id);
    }
}

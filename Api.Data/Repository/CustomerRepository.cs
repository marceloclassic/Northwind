using Api.Data.Context;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        protected readonly MyContext _context;
        private DbSet<CustomerEntity> _dataset;
        public CustomerRepository(MyContext context)
        {
            _context = context;
            _dataset = _context.Set<CustomerEntity>();
        }
        public async Task<bool> DeleteAsync(string id)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(p => p.CustomerId.Equals(id));
                if (result == null)
                {
                    return false;
                }

                _dataset.Remove(result);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> ExistAsync(string id)
        {
            return await _dataset.AnyAsync(p => p.CustomerId.Equals(id));
        }

        public async Task<CustomerEntity> InsertAsync(CustomerEntity item)
        {
            try
            {
                _dataset.Add(item);

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }

        public async Task<CustomerEntity> SelectAsync(string id)
        {
            try
            {
                return await _dataset.SingleOrDefaultAsync(p => p.CustomerId.Equals(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<CustomerEntity>> SelectAsync()
        {
            try
            {
                return await _dataset.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<CustomerEntity> UpdateAsync(CustomerEntity item)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(p => p.CustomerId.Equals(item.CustomerId));
                if (result == null)
                {
                    return null;
                }

                _context.Entry(result).CurrentValues.SetValues(item);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }
    }
}

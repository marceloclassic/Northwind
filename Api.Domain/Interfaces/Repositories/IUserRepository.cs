using Api.Domain.Entities;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<UserEntity> FindByLogin(string email);
    }
}

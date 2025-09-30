using Domain.DTOs;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface ILoginService
    {
        Task<object> FindByLogin(LoginDto user);

    }
}

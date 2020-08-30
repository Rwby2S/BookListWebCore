using System.Threading.Tasks;
using Abp.Application.Services;
using BookListWebCore.Authorization.Accounts.Dto;

namespace BookListWebCore.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

using System.Threading.Tasks;
using Abp.Application.Services;
using BookListWebCore.Sessions.Dto;

namespace BookListWebCore.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

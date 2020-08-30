using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BookListWebCore.MultiTenancy.Dto;

namespace BookListWebCore.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

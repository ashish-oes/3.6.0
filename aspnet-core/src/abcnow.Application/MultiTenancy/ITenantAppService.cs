using Abp.Application.Services;
using Abp.Application.Services.Dto;
using abcnow.MultiTenancy.Dto;

namespace abcnow.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

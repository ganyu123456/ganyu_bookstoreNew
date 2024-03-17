using Abp.Application.Services;
using BookStoreAbpProject.MultiTenancy.Dto;

namespace BookStoreAbpProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}


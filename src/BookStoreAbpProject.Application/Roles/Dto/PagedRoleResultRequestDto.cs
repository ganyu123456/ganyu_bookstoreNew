using Abp.Application.Services.Dto;

namespace BookStoreAbpProject.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}


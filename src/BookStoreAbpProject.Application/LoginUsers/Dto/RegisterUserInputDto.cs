using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BookStoreAbpProject.BookWeb;

namespace BookStoreAbpProject.LoginUsers.Dto
{
    [AutoMapTo(typeof(LoginUser))]
    public class RegisterUserInputDto:EntityDto<string>
    {
        public string Name { get; set; }

        public string Password { get; set; }
        public string Email { get; set; }
    }
}

using Abp;
using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Localization;
using BookStoreAbpProject.BookWeb;
using BookStoreAbpProject.LoginUsers.Dto;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreAbpProject.LoginUsers
{
    public interface ILoginUserAppService:IApplicationService
    {
        Task<LoginUser> Login(LoginUserInputDto input);
    }
}

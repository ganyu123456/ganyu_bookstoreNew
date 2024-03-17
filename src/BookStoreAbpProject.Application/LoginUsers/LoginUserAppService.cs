using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.UI;
using Abp.Linq.Extensions;
using BookStoreAbpProject.BookWeb;
using BookStoreAbpProject.LoginUsers.Dto;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using AutoMapper;
using Abp.AutoMapper;
using Abp.Extensions;

namespace BookStoreAbpProject.LoginUsers
{
    public class LoginUserAppService : BookStoreAbpProjectAppServiceBase,ILoginUserAppService
    {
        IRepository<LoginUser,string> _repository;
        public LoginUserAppService(IRepository<LoginUser, string> repository)
        {
            _repository = repository;
        }
        public async Task<LoginUser> Login(LoginUserInputDto input)
        {
            var user = await _repository.GetAsync(input.Code);
            if (user == null)
            {
                throw new UserFriendlyException("未查询到用户信息！");
            }
            if (user.Password != input.Password)
            {
                throw new UserFriendlyException("密码输入有误！");
            }
            return user;
        }
        public async Task<bool> Register(RegisterUserInputDto input)
        {
            var count = _repository.GetAll().WhereIf(!string.IsNullOrEmpty(input.Id), t => t.Id == input.Id)
                .Count();
            if (count > 0)
            {
                throw new UserFriendlyException("用户账号已存在，无法注册！");
            }
            var loginUser = ObjectMapper.Map<LoginUser>(input);
            await _repository.InsertAsync(loginUser);
            return true ; 
        }
    }
}

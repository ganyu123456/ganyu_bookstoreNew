using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using BookStoreAbpProject.Configuration.Dto;

namespace BookStoreAbpProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : BookStoreAbpProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

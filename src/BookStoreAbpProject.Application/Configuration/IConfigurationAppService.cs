using System.Threading.Tasks;
using BookStoreAbpProject.Configuration.Dto;

namespace BookStoreAbpProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

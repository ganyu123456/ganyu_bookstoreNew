using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BookStoreAbpProject.Configuration;

namespace BookStoreAbpProject.Web.Host.Startup
{
    [DependsOn(
       typeof(BookStoreAbpProjectWebCoreModule))]
    public class BookStoreAbpProjectWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public BookStoreAbpProjectWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BookStoreAbpProjectWebHostModule).GetAssembly());
        }
    }
}

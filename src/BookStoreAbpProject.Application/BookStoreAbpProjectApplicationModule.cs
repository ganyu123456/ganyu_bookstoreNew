using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BookStoreAbpProject.Authorization;

namespace BookStoreAbpProject
{
    [DependsOn(
        typeof(BookStoreAbpProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class BookStoreAbpProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<BookStoreAbpProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(BookStoreAbpProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}

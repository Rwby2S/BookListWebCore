using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BookListWebCore.Authorization;

namespace BookListWebCore
{
    [DependsOn(
        typeof(BookListWebCoreCoreModule),
        typeof(AbpAutoMapperModule))]
    public class BookListWebCoreApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<BookListWebCoreAuthorizationProvider>();

            // 自定义类型映射
            Configuration.Modules.AbpAutoMapper().Configurators.Add(configuration =>
            {
                // XXXMapper.CreateMappers(configuration);


            });
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(BookListWebCoreApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BookListWebCore.Configuration;

namespace BookListWebCore.Web.Host.Startup
{
    [DependsOn(
       typeof(BookListWebCoreWebCoreModule))]
    public class BookListWebCoreWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public BookListWebCoreWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BookListWebCoreWebHostModule).GetAssembly());
        }
    }
}

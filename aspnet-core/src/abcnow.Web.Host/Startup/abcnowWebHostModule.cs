using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using abcnow.Configuration;

namespace abcnow.Web.Host.Startup
{
    [DependsOn(
       typeof(abcnowWebCoreModule))]
    public class abcnowWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public abcnowWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(abcnowWebHostModule).GetAssembly());
        }
    }
}

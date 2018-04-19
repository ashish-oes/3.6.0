using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using abcnow.Configuration.Dto;

namespace abcnow.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : abcnowAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

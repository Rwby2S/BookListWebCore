using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using BookListWebCore.Configuration.Dto;

namespace BookListWebCore.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : BookListWebCoreAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

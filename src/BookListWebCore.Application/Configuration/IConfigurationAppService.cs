using System.Threading.Tasks;
using BookListWebCore.Configuration.Dto;

namespace BookListWebCore.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

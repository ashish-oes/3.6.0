using System.Threading.Tasks;
using abcnow.Configuration.Dto;

namespace abcnow.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

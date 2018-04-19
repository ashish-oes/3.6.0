using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using abcnow.Roles.Dto;
using abcnow.Users.Dto;

namespace abcnow.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}

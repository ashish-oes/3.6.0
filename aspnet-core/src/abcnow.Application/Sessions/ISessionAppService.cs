using System.Threading.Tasks;
using Abp.Application.Services;
using abcnow.Sessions.Dto;

namespace abcnow.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

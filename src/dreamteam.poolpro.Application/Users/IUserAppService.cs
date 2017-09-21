using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using dreamteam.poolpro.Roles.Dto;
using dreamteam.poolpro.Users.Dto;

namespace dreamteam.poolpro.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}
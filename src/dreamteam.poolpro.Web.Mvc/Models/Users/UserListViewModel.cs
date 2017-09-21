using System.Collections.Generic;
using dreamteam.poolpro.Roles.Dto;
using dreamteam.poolpro.Users.Dto;

namespace dreamteam.poolpro.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
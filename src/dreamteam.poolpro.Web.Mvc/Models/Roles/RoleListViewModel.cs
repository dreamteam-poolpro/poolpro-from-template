using System.Collections.Generic;
using dreamteam.poolpro.Roles.Dto;

namespace dreamteam.poolpro.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}

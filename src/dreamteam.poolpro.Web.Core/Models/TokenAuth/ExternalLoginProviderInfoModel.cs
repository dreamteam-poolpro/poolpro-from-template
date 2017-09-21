using Abp.AutoMapper;
using dreamteam.poolpro.Authentication.External;

namespace dreamteam.poolpro.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}

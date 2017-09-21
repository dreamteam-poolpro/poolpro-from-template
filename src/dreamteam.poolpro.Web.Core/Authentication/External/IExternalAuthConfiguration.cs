using System.Collections.Generic;

namespace dreamteam.poolpro.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}

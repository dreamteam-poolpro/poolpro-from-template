using dreamteam.poolpro.Controllers;
using Microsoft.AspNetCore.Antiforgery;

namespace dreamteam.poolpro.Web.Host.Controllers
{
    public class AntiForgeryController : poolproControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
using Abp.AspNetCore.Mvc.Authorization;
using dreamteam.poolpro.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace dreamteam.poolpro.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : poolproControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
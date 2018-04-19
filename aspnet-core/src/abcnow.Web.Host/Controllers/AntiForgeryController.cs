using Microsoft.AspNetCore.Antiforgery;
using abcnow.Controllers;

namespace abcnow.Web.Host.Controllers
{
    public class AntiForgeryController : abcnowControllerBase
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

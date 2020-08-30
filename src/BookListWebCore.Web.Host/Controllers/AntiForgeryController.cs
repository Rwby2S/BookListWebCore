using Microsoft.AspNetCore.Antiforgery;
using BookListWebCore.Controllers;

namespace BookListWebCore.Web.Host.Controllers
{
    public class AntiForgeryController : BookListWebCoreControllerBase
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

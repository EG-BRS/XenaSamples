using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using XenaSamples.HybridFlow.MvcClient.Models;
using XenaSamples.HybridFlow.MvcClient.Xena;

namespace XenaSamples.HybridFlow.MvcClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly XenaHttpClient _client;

        public HomeController(XenaHttpClient client)
        {
            _client = client;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult Login()
        {
            ViewData["Message"] = "Secure page.";
            return View();
        }

        [Authorize]
        public async Task<IActionResult> Xena()
        {
            var accessToken = await HttpContext.GetTokenAsync("access_token");
            ViewData["Message"] = "Secure page.";
            var data = await _client.GetAsyc(accessToken, "/User/XenaUserMembership?pagesize=0");
            return View(new XenaViewModel {Data = data});
        }

        public IActionResult Logout()
        {
            return SignOut("Cookies", "oidc");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

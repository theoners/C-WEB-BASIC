using SIS.HTTP;
using SIS.MvcFramework;
using Suls.Services;
using Suls.ViewModels;

namespace Suls.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public HttpResponse Index()
        {
            if (this.IsUserLoggedIn())
            {
                return this.View("IndexLoggedIn");
            }
            return this.View();
        }


    }
}


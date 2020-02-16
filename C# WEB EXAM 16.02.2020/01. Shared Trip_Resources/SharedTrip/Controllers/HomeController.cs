namespace SharedTrip.Controllers
{
    using SIS.HTTP;
    using SIS.MvcFramework;

    public class HomeController : Controller
    {
        [HttpGet("/")]
        public HttpResponse HomeSlash()
        {
            return this.Index();
        }
        public HttpResponse Index()
        {
            if (this.IsUserLoggedIn())
            {
                return this.Redirect($"/Trips/All");
            }
            return this.View();
        }
    }
}
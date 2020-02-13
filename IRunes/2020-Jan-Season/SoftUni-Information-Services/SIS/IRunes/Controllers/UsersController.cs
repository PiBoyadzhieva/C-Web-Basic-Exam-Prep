using System.Net;
using SIS.HTTP;
using SIS.MvcFramework;

namespace IRunes.Controllers
{
    public class UsersController : Controller
    {
        public HttpResponse Login()
        {
            return this.View();
        }

        public HttpResponse Register()
        {
            return this.View();
        }

    }
}

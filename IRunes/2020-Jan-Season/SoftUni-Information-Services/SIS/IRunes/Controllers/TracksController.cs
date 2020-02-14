using IRunes.ViewModels.Tracks;
using SIS.HTTP;
using SIS.MvcFramework;

namespace IRunes.Controllers
{
    public class TracksController : Controller
    {
        public HttpResponse Create(string albumId)
        {
            var viewModel = new CreateViewModel
            {
                AlbumId = albumId
            };

            return this.View(viewModel);
        }

        [HttpPost]
        public HttpResponse Create(CreateInputModel input)
        {
            if (!this.IsUserLoggedIn())
            {
                return this.Redirect("/Users/Login");
            }

            if (input.Name.Length < 4 || input.Name.Length > 20)
            {
                return this.Error("Track name should be between 4 and 20 characters.");
            }

            if (!input.Link.StartsWith("http"))
            {
                return this.Error("Invalid link.");
            }

            if (input.Price < 0)
            {
                return this.Error("Price should be a positive number.");
            }


        }

        public HttpResponse Details()
        {
            return this.View();
        }

    }
}

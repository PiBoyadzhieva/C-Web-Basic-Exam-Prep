using IRunes.Models;

namespace IRunes.Services
{
    public class TracksService : ITracksService
    {
        public void Create(string albumId, string name, string link, decimal price)
        {
            var track = new Track
            {
                AlbumId = albumId,
                Name = name,
                Link = link,
                Price = price,
            };
        }
    }
}

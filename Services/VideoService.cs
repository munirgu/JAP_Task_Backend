using JAP_Task_Backend.Database;
using JAP_Task_Backend.DTO;
using JAP_Task_Backend.Enums;
using JAP_Task_Backend.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace JAP_Task_Backend.Services


{


    public class VideoService : IVideoService
    {
        private readonly ApplicationDbContext _context;

        public VideoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<VideoDto> GetTopTenVideos(VideoType videoType)
        {
            var videos = _context.Videos
                .Where(w => w.Type == videoType)
                .Select(s => new VideoDto
                {
                    Id = s.Id,
                    Title = s.Title,
                    Description = s.Description,
                    ReleaseDate = s.ReleaseDate,
                    ImageUrl = s.ImageUrl,
                    Rating = s.Ratings.Average(a => a.Score),
                    Actors = s.Actors.Select(x => x.Name).ToList()
                })
                .OrderByDescending(o => o.Rating)
                .Take(10)
                .ToList();
            return videos;

        }
    }
}

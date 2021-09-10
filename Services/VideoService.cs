using JAP_Task_Backend.Database;
using JAP_Task_Backend.DTO;
using JAP_Task_Backend.Enums;
using JAP_Task_Backend.Interfaces;
using JAP_Task_Backend.Models;
using System.Collections.Generic;
using System.Linq;

namespace JAP_Task_Backend.Services


{


    public class VideoService : IVideoService
    {
        private readonly ApplicationDbContext _context;
        private const int pageSize = 10;

        public VideoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<VideoDto> GetTopTenVideos(VideoType videoType, int currentPage = 1)
        {
            if (currentPage < 1)
                currentPage = 1;
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
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .ToList();
            return videos;

        }

        public List<VideoDto> SearchMovies(VideoType videoType, string quickSearch)
        {



            var videos = _context.Videos
                .Where(w => w.Type == videoType &&
                      (w.Title.ToLower().Contains(quickSearch.ToLower()) ||
                       w.Description.ToLower().Contains(quickSearch.ToLower())))
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
                .ToList();
            return videos;

        }


        public void RateVideo(int id, int score)
        {
            var rating = new Rating()
            {
                VideoId = id,
                Score = score
            };
            _context.Ratings.Add(rating);
            _context.SaveChanges();
        }

    }


}

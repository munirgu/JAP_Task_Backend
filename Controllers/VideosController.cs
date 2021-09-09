using JAP_Task_Backend.Enums;
using JAP_Task_Backend.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace JAP_Task_Backend.Controllers
{
    [ApiController]
    [Route("videos")]


    public class VideosController : Controller
    {
        private readonly IVideoService _videoService;

        public VideosController (IVideoService videoService) {

            _videoService = videoService;
        }

        [HttpGet("get-top-ten-movies")]
        public IActionResult GetTopTenMovies()
        {
            return Ok(_videoService.GetTopTenVideos(VideoType.Movie));
        }

        [HttpGet("get-top-ten-shows")]
        public IActionResult GetTopTenShows()
        {
            return Ok(_videoService.GetTopTenVideos(VideoType.TvShow));
        }


        [HttpGet("get-all-movie-videos")]
        public IActionResult GetAllMovieVideos()
        {
            return Ok(_videoService.GetAllVideos(VideoType.Movie));
        }

        [HttpGet("get-all-show-videos")]
        public IActionResult GetAllShowVideos()
        {
            return Ok(_videoService.GetAllVideos(VideoType.TvShow));
        }
    }
}


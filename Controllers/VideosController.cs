﻿using JAP_Task_Backend.Enums;
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
        public IActionResult GetTopTenMovies(int currentPage)
        {
            return Ok(_videoService.GetTopTenVideos(VideoType.Movie,currentPage));
        }

        [HttpGet("get-top-ten-shows")]
        public IActionResult GetTopTenShows(int currentPage)
        {
            return Ok(_videoService.GetTopTenVideos(VideoType.TvShow, currentPage));
        }




        [HttpGet("search-movie-videos")]
        public IActionResult SearchMovies(string quickSearch)
        {
            return Ok(_videoService.SearchMovies(VideoType.Movie,quickSearch ));
        }

        [HttpGet("search-show-videos")]
        public IActionResult SearchTvShows(string quickSearch)
        {
            return Ok(_videoService.SearchMovies(VideoType.TvShow, quickSearch));
        }
        


        [HttpPost("rate-video")]
        public IActionResult RateVideo(int id, int score)
        {
            _videoService.RateVideo(id, score);
            return Ok();
        }
    }
}

